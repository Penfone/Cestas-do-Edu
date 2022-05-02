using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace AppDeCesta
{
    public partial class frmCarro : Form
    {
        Thread nt;
   

        public frmCarro()
        {
            InitializeComponent();
        }

        private void btnMinInicio_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharInicio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "informação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(@"pedido.txt");
                File.Delete(@"preço.txt");

                this.Close();
            }
        }

        private void btnInicioCarro_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Se voltar para a tela de inicio os dados do carrinho serão resetados, você tem certeza que quer sair?", "Informação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                File.Delete(@"pedido.txt");
                File.Delete(@"preço.txt");
                this.Close();
                nt = new Thread(frmInicio);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
        }

            private void frmInicio()
            {
                Application.Run(new frmInicio());
            }
        

        private void frmProntas()
        {
            Application.Run(new FrmProntas());
        }

        private void frmCarro_Load(object sender, EventArgs e)
        {
            FileInfo abrirArquivo = new FileInfo(@"./pedido.txt");
            if (abrirArquivo.Exists)
            {
                using (StreamReader aa = abrirArquivo.OpenText())
                {
                    lstAgenda.Items.Clear();
                    string linha = "";
                    while ((linha = aa.ReadLine()) != null)
                    {
                        lstAgenda.Items.Add(linha);
                    }
                }
            }

            FileInfo salvarPreço = new FileInfo(@"./preço.txt");
            if (salvarPreço.Exists)
            {
                using (StreamReader aa = salvarPreço.OpenText())
                {
                    lstAgenda1.Items.Clear();
                    string linha = "";
                    while ((linha = aa.ReadLine()) != null)
                    {
                        lstAgenda1.Items.Add(linha);
                    }
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Deseja remover todos os items do carrinho?", "Informação",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    lstAgenda.Items.Clear();
                    lstAgenda1.Items.Clear();
                }

                File.Delete(@"pedido.txt");
                File.Delete(@"preço.txt");

            }

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if ((txbDest.Text != "") && (txbEnd.Text != "") && (txbNum.Text != "") && 
                (txbBairro.Text != "") && (cmbPg.Text != "") )
            {
                MessageBox.Show("Seu pedido está sendo preparado, e em breve será entregue", "Informação",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Deseja comprar mais items?", "Informação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nt = new Thread(frmInicio);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                    this.Close();
                    File.Delete(@"pedido.txt");
                    File.Delete(@"preço.txt");
                }
                else
                {
                    this.Close();
                    File.Delete(@"pedido.txt");
                    File.Delete(@"preço.txt");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Informação",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
