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
   public class FacturaController
    {
        FacturaView vista;
        string operacion = string.Empty;
        FacturaDAO facturaDAO = new FacturaDAO(); // este codigo se trae arriba para reutilizarlo en todo lps metodos
        Factura user = new Factura();

        public FacturaController(FacturaView view)
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
                if (vista.DetalleDGrib.SelectedRows.Count > 0)
                {
                    bool elimino = facturaDAO.EliminarFactura((int)vista.DetalleDGrib.CurrentRow.Cells[0].Value);
                    if (elimino)
                    {
                        MessageBox.Show("La factura se ha eliminado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                        DesabilitarControles();
                        ListarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la factura", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.DetalleDGrib.SelectedRows.Count > 0)
            {
                vista.IdClienteText.Text = vista.DetalleDGrib.CurrentRow.Cells["ID_USUARIO"].Value.ToString();
                vista.IdBoletoText.Text = vista.DetalleDGrib.CurrentRow.Cells["ID_BOLETO"].Value.ToString();
                vista.PrecioText.Text = vista.DetalleDGrib.CurrentRow.Cells["PRECIO"].Value.ToString();
                vista.CantText.Text = vista.DetalleDGrib.CurrentRow.Cells["CANTIDAD"].Value.ToString();
                vista.ISVText.Text = vista.DetalleDGrib.CurrentRow.Cells["ISV"].Value.ToString();
                vista.SubText.Text = vista.DetalleDGrib.CurrentRow.Cells["SUBTOTAL"].Value.ToString();
                vista.TotalText.Text = vista.DetalleDGrib.CurrentRow.Cells["TOTAL"].Value.ToString();
                HabilitarControles();
            }
        }
        private void Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        private void ListarUsuarios()
        {
            vista.DetalleDGrib.DataSource = facturaDAO.GetFactura();
        }
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.NClienteText.Text == "")
            {
                vista.errorProvider1.SetError(vista.NClienteText, "Ingrese el nombre del usuario");
                vista.NClienteText.Focus();
                return;
            }

            if (vista.PrecioText.Text == "")
            {
                vista.errorProvider1.SetError(vista.PrecioText, "Ingrese el precio");
                vista.PrecioText.Focus();
                return;
            }

            if (vista.CantText.Text == "")
            {
                vista.errorProvider1.SetError(vista.CantText, "Ingrese la cantidad");
                vista.CantText.Focus();
                return;
            }


            user.Cantidad = vista.CantText.Text;
            user.Precio = vista.PrecioText.Text;
            user.ISV = vista.ISVText.Text;
            user.SubTotal = vista.SubText.Text;
            user.Total = vista.TotalText.Text;

            if (operacion == "Nuevo")
            {
                bool inserto = facturaDAO.InsertarNuevaFactura(user);
                //insertar un nuevo usuario
                if (inserto)
                {
                    MessageBox.Show("La facturea se ha creado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al crear una nueva factura", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //modificar usuario
            else if (operacion == "Modificar")
            {
                user.Id = Convert.ToInt32(vista.IdClienteText.Text);
                bool modifico = facturaDAO.ActualizarFactura(user);
                if (modifico)
                {

                    MessageBox.Show("La factura se ha modificado correctamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    DesabilitarControles();
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("ERROR AL MODIFICAR La factura", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LimpiarControles();
                }

            }

        }

        private void HabilitarControles()
        {
            vista.IdClienteText.Enabled = true;
            vista.IdBoletoText.Enabled = true;
            vista.IDText.Enabled = true;
            vista.PrecioText.Enabled = true;
            vista.CantText.Enabled = true;
            vista.SubText.Enabled = true;
            vista.TotalText.Enabled = true;
            vista.ISVText.Enabled = true;
            vista.DescText.Enabled = true;
            vista.IdPasajeroText.Enabled = true;
            vista.NClienteText.Enabled = true;


            vista.bttguardar.Enabled = true;
            vista.bttcancelar.Enabled = true;
            vista.bttmodificar.Enabled = false;
            vista.bttnuevo.Enabled = false;
        }

        //codigo para limpiar controles
        private void LimpiarControles()
        {
            vista.IdClienteText.Clear();
            vista.IdBoletoText.Clear();
            vista.IDText.Clear();
            vista.PrecioText.Clear();
            vista.CantText.Clear();
            vista.SubText.Clear();
            vista.TotalText.Clear();
            vista.ISVText.Clear();
            vista.DescText.Clear();
            vista.IdPasajeroText.Clear();
            vista.NClienteText.Clear();


        }

        //codigo para deshabilitar controles
        private void DesabilitarControles()
        {
            vista.IdClienteText.Enabled = false;
            vista.IdBoletoText.Enabled = false;
            vista.IDText.Enabled = false;
            vista.PrecioText.Enabled = false;
            vista.CantText.Enabled = false;
            vista.SubText.Enabled = false;
            vista.TotalText.Enabled = false;
            vista.ISVText.Enabled = false; ;
            vista.DescText.Enabled = false;
            vista.IdPasajeroText.Enabled = false;
            vista.NClienteText.Enabled = false;

            vista.bttguardar.Enabled = false;
            vista.bttcancelar.Enabled = false;
            vista.bttmodificar.Enabled = true;
            vista.bttnuevo.Enabled = true;
        }




    }
}

