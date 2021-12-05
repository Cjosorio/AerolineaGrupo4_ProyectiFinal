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
    public partial class AvionView : Form
    {
        public AvionView()
        {
            InitializeComponent();
            AvionController controller = new AvionController(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btu_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
