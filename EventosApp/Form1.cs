using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventosApp.elementos;

namespace EventosApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            


            if (usutxt1.Text.Equals(""))
            {
                if (String.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa el usuario");
                }
            }
            else if (contratxt1.Text.Equals(""))
            {
                if (String.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa la contraseña");
                }
            }
            else if ((usutxt1.Text.Equals(UsuarioContra.usuario))==false)
            {
                MessageBox.Show("El usuario es incorrecto");
            }
            else if ((contratxt1.Text.Equals(UsuarioContra.contraseña))==false)
            {
                MessageBox.Show("La contraseña es incorrecta");
            }
            else
            {
                MessageBox.Show("Bienvenido " + usutxt1.Text + MessageBoxButtons.OK);
                menu portada = new menu();
                portada.Show();
                Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            registrarse crear = new registrarse();
            crear.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
