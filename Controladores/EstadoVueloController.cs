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
  public  class EstadoVueloController
    {

        EstadoVueloView vista;
        string operacion = string.Empty;
        EstadoVueloDAO estadovueloDAO = new EstadoVueloDAO(); // este codigo se trae arriba para reutilizarlo en todo lps metodos
        EstadoVuelo user = new EstadoVuelo();

        public EstadoVueloController(EstadoVueloView view)
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
                bool elimino = estadovueloDAO.EliminarEstadoVuelo((int)vista.usuariosdatagriedviwe.CurrentRow.Cells[0].Value);
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

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.usuariosdatagriedviwe.SelectedRows.Count > 0)
            {
                vista.txtid.Text = vista.usuariosdatagriedviwe.CurrentRow.Cells["ID"].Value.ToString();
                vista.chbdisponible.Checked = (bool)vista.usuariosdatagriedviwe.CurrentRow.Cells["DISPONIBLE"].Value;
                vista.chbretrasado.Checked = (bool)vista.usuariosdatagriedviwe.CurrentRow.Cells["RETRASADO"].Value;
                vista.chbcancelado.Checked = (bool)vista.usuariosdatagriedviwe.CurrentRow.Cells["CANCELADO"].Value;
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
            vista.usuariosdatagriedviwe.DataSource = estadovueloDAO.GetEstadoVuelo();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            user.Disponible = vista.chbdisponible.Checked;
            user.Retrasado = vista.chbretrasado.Checked;
            user.Cancelado = vista.chbcancelado.Checked;





            if (operacion == "Nuevo")
            {
                bool inserto = estadovueloDAO.InsertarNuevoEstadoVuelo(user);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("Estado de vuelo guaradado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el estado de vuelo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.txtid.Text);
                bool modifico = estadovueloDAO.ActualizarEstadoVuelo(user);
                if (modifico)
                {

                    MessageBox.Show("Estado de vuelo modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR EL ESTADO DE VUELO", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }

        private void HabilitarControles()
        {

            vista.chbdisponible.Enabled = true;
            vista.chbretrasado.Enabled = true;
            vista.chbcancelado.Enabled = true;
            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }


        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.chbdisponible.Checked = false;
            vista.chbretrasado.Checked = false;
            vista.chbcancelado.Checked = false;
        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            ;
            vista.chbcancelado.Enabled = false;
            vista.chbdisponible.Enabled = false;
            vista.chbretrasado.Enabled = false;
            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }



    }
}
