using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FrmTexto : Form
    {
        public FrmTexto()
        {
            InitializeComponent();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            File.WriteAllText(@"C:\Arquivos\texto-" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".txt", textBox1.Text);
            MessageBox.Show("Arquivo Salvo");
            textBox1.Text = string.Empty;
        }
    }
}
