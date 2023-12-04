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
    public partial class eventos : Form
    {
        public eventos()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void subir_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = int.Parse(codigotx.Text);
                for (int x = 0; x < codigotx.Text.Length; x++)
                {
                    if (!(char.IsNumber(codigotx.Text[x])))
                    {
                        MessageBox.Show("Error en codigo, solo se permiten numeros. ni tampoco numeros negativos");

                        return;
                    }

                }

                for (int i = 0; i < codigotx.Text.Length; i++)
                {
                    if (!(char.IsLetter(eventotx.Text[i])))
                    {
                        MessageBox.Show("Error en Evento, solo se permiten letras ");

                        return;
                    }
                }
                for (int i = 0; i < comidatx.TextLength; i++)
                {
                    if (!(char.IsLetter(comidatx.Text[i])))
                    {
                        MessageBox.Show("Error en comida, solo se permiten letras ");

                        return;
                    }
                }
                if (codigotx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa el codigo");
                    }
                }
                else if (personastx.Value < 30)
                {
                    MessageBox.Show("Erroren Personas los eventos son a partir de 30 personas");
                }               
                else if (eventotx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Ingresa que tipo de evento tendras");
                    }
                }
                else if (ubicaciontx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("error en unicacio, ¿En donde será?");
                    }
                }
                else if (comidatx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Error en comida, ¿los dejaras sin comer?");
                    }
                }
                else if (decoraciontx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Error en decoracion, todo es mas lindo arreglado");
                    }
                }
                else if (musicatx.Text.Equals(""))
                {
                    if (string.IsNullOrEmpty(""))
                    {
                        MessageBox.Show("Error en musica, hay que poner ambiente");
                    }
                }
                else
                {
                    DataGridViewRow renglon = (DataGridViewRow)eventitos.Rows[0].Clone();
                    renglon.Cells[0].Value = codigotx.Text;
                    renglon.Cells[1].Value = eventotx.Text;
                    renglon.Cells[2].Value = personastx.Text;
                    renglon.Cells[3].Value = fechatx.Text;
                    renglon.Cells[4].Value = ubicaciontx.Text;
                    renglon.Cells[5].Value = comidatx.Text;
                    renglon.Cells[6].Value = decoraciontx.Text;
                    renglon.Cells[7].Value = musicatx.Text;

                    eventitos.Rows.Add(renglon);
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
            if (eventitos.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglon", "Modificando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                codigotx.Text = eventitos.CurrentRow.Cells["codigo1"].Value.ToString();
                eventotx.Text = eventitos.CurrentRow.Cells["evento"].Value.ToString();
                personastx.Text = eventitos.CurrentRow.Cells["NoPersonas"].Value.ToString();
                fechatx.Text = eventitos.CurrentRow.Cells["fecha"].Value.ToString();
                ubicaciontx.Text = eventitos.CurrentRow.Cells["ubicacion"].Value.ToString();
                comidatx.Text = eventitos.CurrentRow.Cells["comida"].Value.ToString();
                decoraciontx.Text = eventitos.CurrentRow.Cells["decoracion"].Value.ToString();
                musicatx.Text = eventitos.CurrentRow.Cells["musica"].Value.ToString();
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Deseo eliminar el registro";
            string titulo = "eliminando el registro";

            if (!(eventitos.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        eventitos.Rows.Remove(eventitos.CurrentRow);
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

        private void eventitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void musicatx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comidatx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ubicaciontx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void decoraciontx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
