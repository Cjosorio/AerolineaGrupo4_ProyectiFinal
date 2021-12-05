using AerolineaGrupo4.Modelo.DAO;
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
  public  class PasajeroController
    {
        PasajeroView vista;

        PasajeroDAO pasajeroDAO = new PasajeroDAO();

        Pasajero pasajero = new Pasajero();

        string operacion = string.Empty;



        public PasajeroController(PasajeroView view)

        {

            vista = view;
            vista.bttnuevo.Click += new EventHandler(Nuevo);
            vista.bttguardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.bttmodificar.Click += new EventHandler(Modificar);
            vista.btteliminar.Click += new EventHandler(Eliminar);

        }
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.PasajerodataGridView.SelectedRows.Count > 0)
            {
                bool elimino = pasajeroDAO.EliminarPasajero((int)vista.PasajerodataGridView.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("El pasajero se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el pasajero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.PasajerodataGridView.SelectedRows.Count > 0)
            {
                vista.txtid.Text = vista.PasajerodataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.NombretextBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["NOMBRE"].Value.ToString();
                vista.ApellidotextBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["APELLIDOS"].Value.ToString();
                vista.EdadtextBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["EDAD"].Value.ToString();
                vista.GenerocomboBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["GENERO"].Value.ToString();
                vista.NacionalidadtextBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["NACIONALIDAD"].Value.ToString();
                vista.PasaportetextBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["PASAPORTE"].Value.ToString();
                vista.TelefonotextBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["TELEFONO"].Value.ToString();
                vista.EmailtextBox.Text = vista.PasajerodataGridView.CurrentRow.Cells["EMAIL"].Value.ToString();
                
                HabilitarControles();
            }
        }


        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.PasajerodataGridView.DataSource = pasajeroDAO.GetPasajeros();
        }

        //codigo para agreagr un nuevo usuarios
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }


        private void Guardar(object sender, EventArgs e)

        {

            if (vista.NombretextBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.NombretextBox, "Debe ingresar un Nombre");

                vista.NombretextBox.Focus();

                return;

            }

            if (vista.ApellidotextBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.ApellidotextBox, "Debe ingresar un Apellido");

                vista.ApellidotextBox.Focus();

                return;

            }

            if (vista.EdadtextBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.EdadtextBox, "Debe ingresar una Edad");

                vista.EdadtextBox.Focus();

                return;

            }

            if (vista.GenerocomboBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.GenerocomboBox, "Debe ingresar un Genero");

                vista.GenerocomboBox.Focus();

                return;

            }

            if (vista.NacionalidadtextBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.NacionalidadtextBox, "Debe ingresar una Nacionalidad");

                vista.NacionalidadtextBox.Focus();

                return;

            }

            if (vista.PasaportetextBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.PasaportetextBox, "Debe ingresar un Pasaporte");

                vista.PasaportetextBox.Focus();

                return;

            }

            if (vista.TelefonotextBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.TelefonotextBox, "Debe ingresar un Telefono");

                vista.TelefonotextBox.Focus();

                return;

            }

            if (vista.EmailtextBox.Text == "")

            {

                vista.errorProvider1.SetError(vista.EmailtextBox, "Debe ingresar un Email");

                vista.EmailtextBox.Focus();

                return;

            }



            pasajero.Nombre = vista.NombretextBox.Text;

            pasajero.Apellidos = vista.ApellidotextBox.Text;

            pasajero.Edad = vista.EdadtextBox.Text;

            pasajero.Genero = vista.GenerocomboBox.Text;

            pasajero.Nacionalidad = vista.NacionalidadtextBox.Text;

            pasajero.Pasaporte = vista.PasaportetextBox.Text;

            pasajero.Telefono = vista.TelefonotextBox.Text;

            pasajero.Email = vista.EmailtextBox.Text;

            if (operacion == "Nuevo")

            {

                bool inserto = pasajeroDAO.InsertarNuevoPasajero(pasajero);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("El Pasajero se ha registado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al registras el pasajero", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (operacion == "Modificar")
            {
                pasajero.Id = Convert.ToInt32(vista.txtid.Text);
                bool modifico = pasajeroDAO.ActualizarPasajero(pasajero);
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
                    LimpiarControles();
                }


            }


            }

        private void HabilitarControles()
        {
            vista.NombretextBox.Enabled = true;

            vista.ApellidotextBox.Enabled = true;

            vista.EdadtextBox.Enabled = true;

            vista.GenerocomboBox.Enabled = true;

            vista.NacionalidadtextBox.Enabled = true;

            vista.PasaportetextBox.Enabled = true;

            vista.TelefonotextBox.Enabled = true;

            vista.EmailtextBox.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;

        }

        private void LimpiarControles()
        {
            vista.NombretextBox.Clear();
            vista.ApellidotextBox.Clear();

            vista.EdadtextBox.Clear();

            vista.GenerocomboBox.Text = "";
            vista.NacionalidadtextBox.Clear();

            vista.PasaportetextBox.Clear();

            vista.TelefonotextBox.Clear();

            vista.EmailtextBox.Clear();

        }

        private void DesabilitarControles()
        {
            vista.NombretextBox.Enabled = false;
            vista.ApellidotextBox.Enabled = false;
            vista.EdadtextBox.Enabled = false;
            vista.GenerocomboBox.Enabled = false;
            vista.NacionalidadtextBox.Enabled = false;
            vista.PasaportetextBox.Enabled = false;
            vista.TelefonotextBox.Enabled = false;
            vista.EmailtextBox.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }




    }
}

