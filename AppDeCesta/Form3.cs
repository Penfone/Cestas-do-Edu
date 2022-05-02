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
    public partial class frmInicio : Form
    {
        Thread nt;
        public frmInicio()
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
     
        private void btnProntaInicio_Click(object sender, EventArgs e)
    
            {
                this.Close();
                nt = new Thread(frmProntas);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            private void frmProntas()
            {
                Application.Run(new FrmProntas());
            }

        private void btnMonteInicio_Click(object sender, EventArgs e)
        
            {
                this.Close();
                nt = new Thread(frmMonte);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            private void frmMonte()
            {
                Application.Run(new frmMonte());
            }

        private void btnAddInicio_Click(object sender, EventArgs e)
        
            {
                this.Close();
                nt = new Thread(frmCarro);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            private void frmCarro()
            {
                Application.Run(new frmCarro());
            }

    }
}
