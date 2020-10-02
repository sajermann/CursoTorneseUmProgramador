﻿using System;
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
            MessageBox.Show("Inicializando o formulário pelo construtor");
            InitializeComponent();
        }

        private void BTOk_Click(object sender, EventArgs e)
        {
            TBResultado.Text = "Olá Bruno, este é o seu primeiro programa";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var frmForm = new FrmShow();
            frmForm.lblMensagem.Text = TBResultado.Text;
            frmForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Inicializando o formulário");
        }
    }
}
