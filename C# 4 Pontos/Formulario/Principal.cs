using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela1 tl1 = new Tela1();
            tl1.MdiParent = this;
            tl1.Show();
            this.tela1ToolStripMenuItem.Text = "Tela1";
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela2 tl2 = new Tela2();
            tl2.MdiParent = this;
            tl2.Show();
            this.tela2ToolStripMenuItem.Text = "Tela2";
        }

        private void tela3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela3 tl3 = new Tela3();
            tl3.MdiParent = this;
            tl3.Show();
            this.tela3ToolStripMenuItem.Text = "Tela3";
        }

        private void tela4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela4 tl4 = new Tela4();
            tl4.MdiParent = this;
            tl4.Show();
            this.tela4ToolStripMenuItem.Text = "Tela4";
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Marcelo Resende Vieira 2215111013 \nJefferson Alves 2215107370 \nMauricio Menezes 2215112944 \nKaue Oleano 2215109823 \nFelipe Gonçalves Santana 2215108868");
        }
    }
}
