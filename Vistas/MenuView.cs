using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AerolineaGrupo4.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();
    
        }
        UsuarioView users;
        EstadoVueloView estadovuelo;
        PasajeroView pasajero;
        BoletoView boleto;
        VueloView vuelo;
        AvionView avion;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (users== null)
            {
                users = new UsuarioView();
                users.MdiParent = this;
                users.FormClosed += Users_FormClosed;
                users.Show();
            }
            else
            {
                users.Activate();
            }
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            users = null;
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            if (estadovuelo == null)
            {
                estadovuelo = new EstadoVueloView();
                estadovuelo.MdiParent = this;
                estadovuelo.FormClosed += Estadovuelo_FormClosed;
                estadovuelo.Show();
            }
            else
            {
                estadovuelo.Activate();
            }
        }

        private void Estadovuelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            estadovuelo = null;
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (pasajero == null)
            {
                pasajero = new PasajeroView();
                pasajero.MdiParent = this;
                pasajero.FormClosed += Pasajero_FormClosed;
                pasajero.Show();
            }
            else
            {
                pasajero.Activate();
            }
        }

        private void Pasajero_FormClosed(object sender, FormClosedEventArgs e)
        {
            pasajero = null;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (boleto == null)
            {
                boleto = new BoletoView();
                boleto.MdiParent = this;
                boleto.FormClosed += Boleto_FormClosed;
                boleto.Show();
            }
            else
            {
                boleto.Activate();
            }
        }

        private void Boleto_FormClosed(object sender, FormClosedEventArgs e)
        {
            boleto = null;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (vuelo == null)
            {
                vuelo = new VueloView();
                vuelo.MdiParent = this;
                vuelo.FormClosed += Vuelo_FormClosed;
                vuelo.Show();
            }
            else
            {
                vuelo.Activate();
            }
        }

        private void Vuelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            vuelo = null;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (avion == null)
            {
                avion = new AvionView();
                avion.MdiParent = this;
                avion.FormClosed += Avion_FormClosed;
                avion.Show();
            }
            else
            {
                avion.Activate();
            }
        }

        private void Avion_FormClosed(object sender, FormClosedEventArgs e)
        {
            avion = null;
        }
    }
}
