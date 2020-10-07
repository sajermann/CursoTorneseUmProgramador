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
            //comboBox1.Items.Clear();
            //comboBox1.DataSource = Estado.Lista();
            //comboBox1.Text = "[Selecione]";
            //foreach(Estado estado in Estado.Lista()){
            //    comboBox1.Items.Add(estado);
            //}


            //Maneira simples de utilizar DataGridView;
            /*
             * dataGridView1.DataSource = Estado.Lista();
             * 
             */

            //Maneira Complexa
            /*
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nome";

            var rows = new List<string[]>();
            foreach(Estado estado in Estado.Lista())
            {
                string[] row1 = new string[] { estado.Id.ToString(), estado.Nome };
                rows.Add(row1);
            }

            foreach(string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }
            */

            //Utilizando o Link (Melhor por ser controlável)
            var data = from estado in Estado.Lista()
                       where estado.Id == 1 || estado.Id == 2
                       orderby estado.Nome
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };
            dataGridView1.DataSource = data.ToList();

            atualizaHora();
        }

        private void atualizaHora()
        {
            labelDiaHora.Text = "Dia e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTexto().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();
        }
    }
    
}
