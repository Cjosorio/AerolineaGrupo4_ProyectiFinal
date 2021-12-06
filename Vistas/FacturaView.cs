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
    public partial class FacturaView : Form
    {
        public FacturaView()
        {
            InitializeComponent();
           FacturaController controller = new FacturaController(this);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
