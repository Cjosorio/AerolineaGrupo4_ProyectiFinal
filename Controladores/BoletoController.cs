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
  public   class BoletoController
    {

        BoletoView vista;
        string operacion = string.Empty;
       BoletoDAO boletoDAO = new BoletoDAO(); // este codigo se trae arriba para reutilizarlo en todo lps metodos
      Boleto user = new Boleto();

        public BoletoController(BoletoView view)
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
            if (vista.BoletosdataGridView.SelectedRows.Count > 0)
            {
                bool elimino = boletoDAO.EliminarBoleto((int)vista.BoletosdataGridView.CurrentRow.Cells[0].Value);
                if (elimino)
                {
                    MessageBox.Show("El boleto se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el boleto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.BoletosdataGridView.SelectedRows.Count > 0)
            {
                vista.IDtextBox.Text = vista.BoletosdataGridView.CurrentRow.Cells["ID"].Value.ToString();
                vista.IDPsajerotextBox.Text = vista.BoletosdataGridView.CurrentRow.Cells["ID_PASAJEROS"].Value.ToString();
                vista.txtfecha.Text = vista.BoletosdataGridView.CurrentRow.Cells["FECHA_VUELO"].Value.ToString();
                vista.AsientocomboBox.Text = vista.BoletosdataGridView.CurrentRow.Cells["ASIENTO"].Value.ToString();
                vista.ClasecomboBox.Text = vista.BoletosdataGridView.CurrentRow.Cells["CLASE"].Value.ToString();
                vista.PreciotextBox.Text = vista.BoletosdataGridView.CurrentRow.Cells["PRECIO"].Value.ToString();
                HabilitarControles();
            }
        }

        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.BoletosdataGridView.DataSource = boletoDAO.GetBoleto();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txtfecha.Text == "")
            {
                vista.errorProvider1.SetError(vista.txtfecha, "Ingrese la fecha de su vuelo");
                vista.txtfecha.Focus();
                return;
            }

            if (vista.PreciotextBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.PreciotextBox, "Ingrese el precio del boleto");
                vista.PreciotextBox.Focus();
                return;
            }

            if (vista.ClasecomboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.ClasecomboBox, "Elija la clase donde desea volar");
                vista.ClasecomboBox.Focus();
                return;
            }

            if (vista.AsientocomboBox.Text == "")
            {
                vista.errorProvider1.SetError(vista.AsientocomboBox, "Elija el asiento donde desea viajar");
                vista.AsientocomboBox.Focus();
                return;
            }
            user.IDPasajero = vista.IDPsajerotextBox.Text;
            user.FechaVuelo = vista.txtfecha.Text;
            user.Precio = vista.PreciotextBox.Text;
            user.Asiento = vista.AsientocomboBox.Text;
            user.Clase = vista.ClasecomboBox.Text;


            if (operacion == "Nuevo")
            {
                bool inserto = boletoDAO.InsertarNuevoBoleto(user);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("El boleto se ha registrado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear el boleto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.IDtextBox.Text);
                bool modifico = boletoDAO.ActualizarBoleto(user);
                if (modifico)
                {

                    MessageBox.Show("El boleto se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR EL BOLETO", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }


        private void HabilitarControles()
        {
            vista.IDPsajerotextBox.Enabled = true;
            vista.PreciotextBox.Enabled = true;
            vista.txtfecha.Enabled = true;
            vista.PreciotextBox.Enabled = true;
            vista.AsientocomboBox.Enabled = true;
            vista.ClasecomboBox.Enabled = true;

            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }

        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.IDPsajerotextBox.Clear();
            vista.PreciotextBox.Clear();
            vista.txtfecha.Clear();
            vista.PreciotextBox.Clear();
            vista.AsientocomboBox.Text="";
            vista.ClasecomboBox.Text = "";

        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.IDPsajerotextBox.Enabled = false;
            vista.PreciotextBox.Enabled = false;
            vista.txtfecha.Enabled = false;
            vista.PreciotextBox.Enabled = false;
            vista.AsientocomboBox.Enabled = false;
            vista.ClasecomboBox.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }




    }
}
