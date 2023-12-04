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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menu_Load(object sender, EventArgs e)
        {
            menu video = new menu();
            perrito.URL = @"F:\menuF.mp4";
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eventos even = new eventos();
            even.Show();
            Hide();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trabajadores trab = new trabajadores();
            trab.Show();
            Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 reg = new Form1();
            reg.Show();
            Hide();
        }
    }
}
