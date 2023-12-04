using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosApp.elementos
{
    public partial class trabajadores : Form
    {
        public trabajadores()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < nombretx.TextLength; x++)
                {
                    if (!(char.IsLetter(nombretx.Text[x])))
                    {
                        MessageBox.Show("Error en nombre, solo se permiten letras");

                        return;
                    }

                }
                for (int x = 0; x < numerotx.TextLength; x++)
                {
                    if (!(char.IsNumber(numerotx.Text[x])))
                    {
                        MessageBox.Show("Error en numero, solo se permiten numeros");

                        return;
                    }

                }
                for (int x = 0; x < controltx.TextLength; x++)
                {
                    if (!(char.IsNumber(controltx.Text[x])))
                    {
                        MessageBox.Show("Error en control, solo se permiten numeros");

                        return;
                    }

                }
                for (int x = 0; x < areatx.TextLength; x++)
                {
                    if (!(char.IsLetter(areatx.Text[x])))
                    {
                        MessageBox.Show("Error en Area, solo se permiten letras");

                        return;
                    }

                }
                if (nombretx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa tu nombre porfavor");
                    }
                }
                else if (numerotx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa tu numero porfavor");
                    }
                }
                else if (fechatx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa tu Cumpleaños porfavor");
                    }
                }
                else if (curptx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Tu CURP porfavor");
                    }
                }
                else if (rfctx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Tu RFC porfavor");
                    }
                }
                else if (correotx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Tu correo porfavor");
                    }
                }
                else if (areatx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Tu Area porfavor");
                    }
                }
                else if (controltx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Tu Numero de Control porfavor");
                    }
                }
                else if (numerotx.TextLength < 10)
                {
                    MessageBox.Show("Tu numero tiene pocos digitos (deben ser 10)");
                }
                else if (numerotx.TextLength >10)
                {
                    MessageBox.Show("Tu numero tiene muchos digitos (deben ser 10)");
                }
                else if (curptx.TextLength < 18)
                {
                    MessageBox.Show("Tu numero CURP tiene pocos digitos (deben ser 18)");
                }
                else if (curptx.TextLength > 18)
                {
                    MessageBox.Show("Tu CURP tiene muchos digitos (deben ser 18)");
                }
                else if (rfctx.TextLength > 13)
                {
                    MessageBox.Show("Tu RFC tiene muchos digitos (deben ser 13)");
                }
                else if (rfctx.TextLength < 13)
                {
                    MessageBox.Show("Tu RFC tiene pocos digitos (deben ser 13)");
                }
                else
                {
                    DataGridViewRow renglon = (DataGridViewRow)chambeadores.Rows[0].Clone();
                    renglon.Cells[0].Value = nombretx.Text;
                    renglon.Cells[1].Value = numerotx.Text;
                    renglon.Cells[2].Value = fechatx.Text;
                    renglon.Cells[3].Value = curptx.Text;
                    renglon.Cells[4].Value = rfctx.Text;
                    renglon.Cells[5].Value = correotx.Text;
                    renglon.Cells[6].Value = areatx.Text;
                    renglon.Cells[7].Value = controltx.Text;

                    chambeadores.Rows.Add(renglon);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando estudiante",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (chambeadores.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                nombretx.Text = chambeadores.CurrentRow.Cells["Nombre"].Value.ToString();
                numerotx.Text = chambeadores.CurrentRow.Cells["numero1"].Value.ToString();
                fechatx.Text = chambeadores.CurrentRow.Cells["Cumpleaños"].Value.ToString();
                curptx.Text = chambeadores.CurrentRow.Cells["CURP"].Value.ToString();
                rfctx.Text = chambeadores.CurrentRow.Cells["RFC"].Value.ToString();
                correotx.Text = chambeadores.CurrentRow.Cells["Correo"].Value.ToString();
                areatx.Text = chambeadores.CurrentRow.Cells["Area"].Value.ToString();
                correotx.Text = chambeadores.CurrentRow.Cells["Correo"].Value.ToString();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Deseo eliminar el registro";
            string titulo = "eliminando el registro";

            if (!(chambeadores.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        chambeadores.Rows.Remove(chambeadores.CurrentRow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Estudiante Eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("debes seleccionar un rengoln", "Eliminado Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            menu reg = new menu();
            reg.Show();
            Hide();
        }

        private void trabajadores_Load(object sender, EventArgs e)
        {
            trabajadores vide = new trabajadores();
            fondo.URL = @"F:\material\fondorosa.mp4";
        }

        private void chambeadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void japi_Enter(object sender, EventArgs e)
        {

        }
    }
}
