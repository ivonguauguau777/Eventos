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

namespace EventosApp.elementos
{
    public partial class registrarse : Form
    {
        public registrarse()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private bool validacion(string password)
        {
            mayuscula.Checked = false; minuscula.Checked = false; numero.Checked = false; carespecial.Checked = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >= 8)
                {
                    minimo.Checked = true;
                }
                if ((Char.IsUpper(password, i)))
                {
                    mayuscula.Checked = true;
                }
                else if ((Char.IsLower(password, i)))
                {
                    minuscula.Checked = true;
                }
                else if (Char.IsNumber(password, i))
                {
                    numero.Checked = true;
                }
                else
                {
                    carespecial.Checked = true;
                }
                if ((mayuscula.Checked) && (minuscula.Checked) && (numero.Checked) && (carespecial.Checked) && (password.Length >= 8) &&  (password.Length <= 16))
                {
                    return true;                                
                }
                
            }
            return false;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void contraseñatxt_TextChanged(object sender, EventArgs e)
        {
            UsuarioContra.usuario = usuariotxt.Text;
            UsuarioContra.contraseña = contraseñatxt.Text;

            int elementos = UsuarioContra.usuario.Count();
            int telementos = telltxt.Text.Count();
            int conelementos = UsuarioContra.contraseña.Count();

            for (int i = 0; i < nombretxt.TextLength; i++)
            {
                if (!(char.IsLetter(nombretxt.Text[i])))
                {
                    MessageBox.Show("Solo se permiten letras en nombre");
                    return;
                }
            }
            for (int x = 0; x < papelltxt.TextLength; x++)
            {
                if (!(char.IsLetter(papelltxt.Text[x])))
                {
                    MessageBox.Show("Solo se permiten letras en tu apellido paterno");
                    return;
                }
            }
            for (int x = 0; x < mapelltxt.TextLength; x++)
            {
                if (!(char.IsLetter(mapelltxt.Text[x])))
                {
                    MessageBox.Show("Solo se permiten letras en tu appellido materno");

                    return;
                }
            }
            for (int x = 0; x < telltxt.TextLength; x++)
            {
                if (!(char.IsNumber(telltxt.Text[x])))
                {
                    MessageBox.Show("Solo se permiten numeros en el telefono");

                    return;
                }
            }

            if (nombretxt.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu nombre");
                }
            }
            else if ((radioButton1.Checked == false) && (radioButton2.Checked == false))
            {
                MessageBox.Show("Se lecciona tu sexo");
            }
            else if (papelltxt.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu apellido paterno");
                }
            }
            else if (mapelltxt.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu apellido materno");
                }
            }
            else if (telltxt.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu numero de telefono");
                }
            }
            else if (correotxt.Text.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu correo electronico");
                }
            }
            else if (elementos <= 3)
            {
                MessageBox.Show("El usuario es muy corto," + "\n" + " pon mas de 3 elementos");
            }
            else if (telementos > 10)
            {
                MessageBox.Show("tu numero de telefono es muy largo");
            }
            else if (telementos < 10)
            {
                MessageBox.Show("tu numero de telefono es muy corto");
            }
            else if (UsuarioContra.usuario.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu usuario");
                }
            }
            else if ((conelementos < 6) && (conelementos > 15))
            {
                MessageBox.Show("La contraseña es entre 6 y 15 elementos");
            }
            else if (UsuarioContra.contraseña.Equals(""))
            {
                if (string.IsNullOrEmpty(""))
                {
                    MessageBox.Show("Ingresa tu contraseña");
                }
            }         
            else
            {
                if (validacion(contraseñatxt.Text))
                {
                    button1.Enabled = true;
                    Form1 nueva = new Form1();
                    nueva.Show();
                    Hide();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            reg.Show();
            Hide();
        }
    }
}
