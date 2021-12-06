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
    public class VueloController
    {

        VueloView vista;
        string operacion = string.Empty;
        VueloDAO vueloDAO = new VueloDAO(); // este codigo se trae arriba para reutilizarlo en todo lps metodos
        Vuelo user = new Vuelo();

        public VueloController(VueloView view)
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
            if (vista.dataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = vueloDAO.EliminarVuelo((int)vista.dataGridView1.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("El vuelo se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el vuelo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.dataGridView1.SelectedRows.Count > 0)
            {
                vista.IdtextBox.Text = vista.dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                vista.horastextBox.Text = vista.dataGridView1.CurrentRow.Cells["HORA_SALIDA"].Value.ToString();
                vista.horallegadatextBox.Text = vista.dataGridView1.CurrentRow.Cells["HORA_LLEGADA"].Value.ToString();
                vista.OrigentextBox.Text = vista.dataGridView1.CurrentRow.Cells["ORIGEN"].Value.ToString();
                vista.DestinotextBox.Text = vista.dataGridView1.CurrentRow.Cells["DESTINO"].Value.ToString();
                HabilitarControles();
            }
        }

        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.dataGridView1.DataSource = vueloDAO.GetVuelo();
        }

        //codigo para agreagr un nuevo usuarios
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.horastextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.horastextBox, "Ingrese la hora de salida del vuelo");
                vista.horastextBox.Focus();
                return;
            }

            if (vista.horallegadatextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.horallegadatextBox, "Ingrese la hora de llega del vuelo");
                vista.horallegadatextBox.Focus();
                return;
            }

            if (vista.OrigentextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.OrigentextBox, "Ingrese el origen del vuelo");
                vista.OrigentextBox.Focus();
                return;
            }


            if (vista.DestinotextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.DestinotextBox, "Ingrese el origen del vuelo");
                vista.DestinotextBox.Focus();
                return;
            }

            user.Destino = vista.DestinotextBox.Text;
            user.Hora_Llegada = vista.horallegadatextBox.Text;
            user.Hora_Salidad = vista.horastextBox.Text;
            user.Origen = vista.OrigentextBox.Text;


            if (operacion == "Nuevo")
            {
                bool inserto = vueloDAO.InsertarNuevoVuelo(user);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("El vuelo se ha creado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear el reporte del vuelo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.IdtextBox.Text);
                bool modifico = vueloDAO.ActualizarVuelo(user);
                if (modifico)
                {

                    MessageBox.Show("El vuelo se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR EL VUELO", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }


        private void HabilitarControles()
        {
            vista.OrigentextBox.Enabled = true;
            vista.DestinotextBox.Enabled = true;
            vista.horastextBox.Enabled = true;
            vista.horallegadatextBox.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }

        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.OrigentextBox.Clear();
            vista.DestinotextBox.Clear();
            vista.horastextBox.Clear();
            vista.horallegadatextBox.Clear();

        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.OrigentextBox.Enabled = false;
            vista.DestinotextBox.Enabled = false;
            vista.horastextBox.Enabled = false;
            vista.horallegadatextBox.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }


    }
}

