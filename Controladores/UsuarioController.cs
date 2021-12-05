﻿using AerolineaGrupo4.Modelo.DAO;
using AerolineaGrupo4.Modelo.Entidades;
using AerolineaGrupo4.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AerolineaGrupo4.Controladores
{
   public  class UsuarioController
    {
        UsuarioView vista;
        string operacion = string.Empty;
        UsuarioDAO usuarioDAO = new UsuarioDAO(); // este codigo se trae arriba para reutilizarlo en todo lps metodos
        Usuario user = new Usuario();

        public UsuarioController(UsuarioView view)
        {
            vista = view;
            vista.bttnuevo.Click += new EventHandler(Nuevo);
            vista.bttguardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.bttmodificar.Click += new EventHandler(Modificar);
            vista.btteliminar.Click += new EventHandler(Eliminar);
        }

        //codigo para elimianr un registro
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                bool elimino = usuarioDAO.EliminarUsuario((int)vista.usuariosdatagriedviwe.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("El usuario se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //codigo para modificar un usuario
        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                vista.txtid.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ID"].Value.ToString();
                vista.txtnomb.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.txtemail.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["EMAIL"].Value.ToString();
                vista.txtclave.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["CLAVE"].Value.ToString();
                HabilitarControles();
            }
        }

        //codigo para acceder al datagriewview y ver los usuarios reflejados en el data
        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.usuariosdatagriedviwe.DataSource = usuarioDAO.GetUsuario();
        }

        //codigo para agreagr un nuevo usuarios
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        //codigo para guardar un usuario
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txtnomb.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtnomb, "Ingrese el nombre del usuario");
                vista.txtnomb.Focus();
                return;
            }

            if (vista.txtemail.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtemail, "Ingrese el email del usuario");
                vista.txtemail.Focus();
                return;
            }

            if (vista.txtclave.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtclave, "Ingrese la clave correcta");
                vista.txtclave.Focus();
                return;
            }


            user.Nombre = vista.txtnomb.Text;
            user.Email = vista.txtemail.Text;
            user.Clave = vista.txtclave.Text;


            if (operacion == "Nuevo")
            {
                bool inserto = usuarioDAO.InsertarNuevoUsuario(user);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("El usuario se ha creado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear el usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.txtid.Text);
                bool modifico = usuarioDAO.ActualizarUsuario(user);
                if (modifico)
                {

                    MessageBox.Show("El usuario se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR USUARIO", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }

        //codigo para tener los botones desactivados 
        private void HabilitarControles()
        {
            vista.txtnomb.Enabled = true;
            vista.txtemail.Enabled = true;
            vista.txtclave.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }

        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.txtnomb.Clear();
            vista.txtemail.Clear();
            vista.txtclave.Clear();

        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.txtnomb.Enabled = false;
            vista.txtemail.Enabled = false;
            vista.txtclave.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }

    }
}
