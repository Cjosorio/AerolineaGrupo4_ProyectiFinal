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
    public partial class UsuarioView : Form
    {
        public UsuarioView()
        {
            InitializeComponent();
        }

        private void UsuarioView_Load(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController(this);
        }

        private void bttcancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
