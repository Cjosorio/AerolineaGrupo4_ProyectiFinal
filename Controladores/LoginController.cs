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
    public class LoginController
    {
        LoginView vista;

        public LoginController(LoginView view)
        {
            vista = view;
            vista.bttaceptar.Click += new EventHandler(ValidarUsuario);
        }

        private void ValidarUsuario(object serder, EventArgs e)
        {
            UsuarioDAO userDAO = new UsuarioDAO();
            Usuario user = new Usuario();
            user.Email = vista.txtemail.Text;
            user.Clave = vista.txtclave.Text;

            bool valido = userDAO.ValidarUsuario(user);
            if (valido)
            {
                //MessageBox.Show("Usuario correcto");

                MenuView menu = new MenuView();
                vista.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }






    }
}
