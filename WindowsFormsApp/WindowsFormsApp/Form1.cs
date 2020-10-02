using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
           // MessageBox.Show("Inicializando o formulário pelo construtor");
            InitializeComponent();
        }

        private void BTOk_Click(object sender, EventArgs e)
        {
            TBResultado.Text = "Olá Bruno, este é o seu primeiro programa - " + ((Estado)comboBox1.SelectedItem).Id;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var frmForm = new FrmShow();
            frmForm.lblMensagem.Text = TBResultado.Text;
            frmForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach(Estado estado in Estado.Lista()){
                comboBox1.Items.Add(estado);

            }
        }
    }
    public class Estado
    {
        public int Id;
        public string Nome;

        public override string ToString()
        {
            return this.Nome;

        }
        public static List<Estado> Lista()
        {
            var lista = new List<Estado>();
            var e1 = new Estado();
            e1.Id = 1;
            e1.Nome = "SP";
            lista.Add(e1);

            e1 = new Estado();
            e1.Id = 2;
            e1.Nome = "MG";
            lista.Add(e1);

            e1 = new Estado();
            e1.Id = 3;
            e1.Nome = "RJ";
            lista.Add(e1);

            return lista;
        }
    }
}
