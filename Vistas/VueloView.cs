using AerolineaGrupo4.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaGrupo4.Vistas
{
    public partial class VueloView : Form
    {
        public VueloView()
        {
            InitializeComponent();
            VueloController controller = new VueloController(this);
        }

        private void VueloView_Load(object sender, EventArgs e)
        {

        }

        private void bttcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
