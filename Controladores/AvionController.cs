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
    class AvionController
    {
        AvionView vista;
        string operacion = string.Empty;
        AvionDAO avionDAO = new AvionDAO(); // este codigo se trae arriba para reutilizarlo en todo loss metodos
        Avion avion = new Avion();

        public AvionController(AvionView view)
        {
            vista = view;
            vista.Btu_Nuevo.Click += new EventHandler(Nuevo);
            vista.Btu_Guardar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.Btu_Modificar.Click += new EventHandler(Modificar);
            vista.Btu_Eliminar.Click += new EventHandler(Eliminar);

        }
        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                bool elimino = avionDAO.EliminarAvion((int)vista.usuariosdatagriedviwe.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("La Especificacion se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }

                else
                {
                    MessageBox.Show("No se pudo eliminar la Especificacion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.usuariosdatagriedviwe.DataSource = avionDAO.GetAvion();
        }
        private void Guardar(object sender, EventArgs e)
        {
            if (vista.Txt_CapacidadAvion.Text == "")
            {
                vista.errorProvider1.SetError(vista.Txt_CapacidadAvion, "Ingrese La capacidad del avion");
                vista.Txt_CapacidadAvion.Focus();
                return;
            }

            if (vista.Cbx_ModeloAvion.Text == "")
            {
                vista.errorProvider1.SetError(vista.Cbx_ModeloAvion, "Ingrese el Modelo de avion que necesita");
                vista.Cbx_ModeloAvion.Focus();
                return;
            }

            if (vista.Cbx_EstadoAvion.Text == "")
            {
                vista.errorProvider1.SetError(vista.Cbx_EstadoAvion, "Ingrese Las siglas del Avion");
                vista.Cbx_EstadoAvion.Focus();
                return;
            }

            if (vista.Cbx_SiglasAvion.Text == "")
            {
                vista.errorProvider1.SetError(vista.Cbx_SiglasAvion, "Ingrese Las siglas del Avion");
                vista.Cbx_SiglasAvion.Focus();
                return;
            }




            avion.Capacidad = vista.Txt_CapacidadAvion.Text;
            avion.Modeloavion = vista.Cbx_ModeloAvion.Text;
            avion.Estado = vista.Cbx_EstadoAvion.Text;
            avion.Siglas = vista.Cbx_SiglasAvion.Text;



            if (operacion == "Nuevo")
            {
                bool inserto = avionDAO.InsertarNuevoAvion(avion);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("Especificacion Creada Correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear la Especificacion", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                avion.Id = Convert.ToInt32(vista.Txt_Id.Text);
                bool modifico = avionDAO.ActualizarAvion(avion);
                if (modifico)
                {

                    MessageBox.Show("La Especificacion se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR LA ESPECIFICACION", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }
        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                vista.Txt_Id.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ID"].Value.ToString();
                vista.Cbx_ModeloAvion.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["MODELO"].Value.ToString();
                vista.Txt_CapacidadAvion.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["CAPACIDAD"].Value.ToString();
                vista.Cbx_EstadoAvion.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ESTADO"].Value.ToString();
                vista.Cbx_SiglasAvion.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["SIGLAS"].Value.ToString();

                //vista.chbadmi.Checked = (bool)vista.usuariosdatagriedviwe.CurrentRow.Cells["ESADMINISTRADOR"].Value;
                HabilitarControles();
            }
        }

        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";


        }
        private void HabilitarControles()
        {
            vista.Txt_CapacidadAvion.Enabled = true;
            vista.Cbx_EstadoAvion.Enabled = true;
            vista.Cbx_ModeloAvion.Enabled = true;
            vista.Cbx_SiglasAvion.Enabled = true;
            vista.Btu_Guardar.Enabled = true;
            vista.Btu_Cancelar.Enabled = true;
            vista.Btu_Modificar.Enabled = false;
            vista.Btu_Nuevo.Enabled = true;
        }


        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.Txt_CapacidadAvion.Clear();
            vista.Cbx_SiglasAvion.Text = "";
            vista.Cbx_ModeloAvion.Text = "";
            vista.Cbx_EstadoAvion.Text = "";


        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.Txt_CapacidadAvion.Enabled = false;
            vista.Cbx_EstadoAvion.Enabled = false;
            vista.Cbx_ModeloAvion.Enabled = false;
            vista.Cbx_SiglasAvion.Enabled = false;

            vista.Btu_Guardar.Enabled = false;
            vista.Btu_Cancelar.Enabled = false;
            vista.Btu_Modificar.Enabled = true;
            vista.Btu_Nuevo.Enabled = true;
        }







    }
}
