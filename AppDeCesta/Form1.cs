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
    public partial class FrmProntas : Form
    {

        Thread nt;

        //preços
        int total = 0;
        int basico = 42;
        int VBasico = 0;
        int grande = 103;
        int VGrande = 0;
        int surpresa = 130;
        int VSurpresa = 0;
        int francesa = 155;
        int VFrancesa = 0;
        int generoso = 162;
        int VGeneroso = 0;
        int premium = 260;
        int VPremium = 0;


        public FrmProntas()
        {
            InitializeComponent();
        }

        private void btnMinPronta_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharPronta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "informação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(@"pedido.txt");
                File.Delete(@"preço.txt");
                this.Close();
            }
        }

        private void BtnInicioPronta_Click(object sender, EventArgs e)
        
            {
                this.Close();
                nt = new Thread(frmInicio);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            private void frmInicio()
            {
                Application.Run(new frmInicio());
            }

        private void btnMontePronta_Click(object sender, EventArgs e)
        
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

        private void btnCarroPronta_Click(object sender, EventArgs e)
        
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

        private void ckbBasico_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBasico.Checked)
            {
                nudBasico.Value = 1;
            }
            else
            {
                nudBasico.Value = 0;
            }
        }
        private void nudBasico_ValueChanged(object sender, EventArgs e)
        {
            if (nudBasico.Value >= 1)
            {

                VBasico = (Convert.ToInt32(nudBasico.Value) * basico);
                total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                ckbBasico.Checked = true;

                lblTotalPronta.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudBasico.Value == 0)
                {
                    VBasico = 0;
                    total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                    ckbBasico.Checked = false;

                    lblTotalPronta.Text = ("R$" + total + ",00");
                }
            }
           
        }
        private void ckbGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGrande.Checked)
            {
                nudGrande.Value = 1;
            }
            else
            {
                nudGrande.Value = 0;
            }
        }
        private void nudGrande_ValueChanged(object sender, EventArgs e)
        {
            if (nudGrande.Value >= 1)
            {
                VGrande = (Convert.ToInt32(nudGrande.Value) * grande);
                total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                ckbGrande.Checked = true;

                lblTotalPronta.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudGrande.Value == 0)
                {
                    VGrande = 0;
                    total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                    ckbGrande.Checked = false;

                    lblTotalPronta.Text = ("R$" + total + ",00");
                }
            }
        }
        private void ckbSurpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSurpresa.Checked)
            {
                nudSurpresa.Value = 1;
            }
            else
            {
                nudSurpresa.Value = 0;
            }
        }
        private void nudSurpresa_ValueChanged(object sender, EventArgs e)
        {
            if (nudSurpresa.Value >= 1)
            {
                VSurpresa = (Convert.ToInt32(nudSurpresa.Value) * surpresa);
                total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                ckbSurpresa.Checked = true;

                lblTotalPronta.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudSurpresa.Value == 0)
                {
                    VSurpresa = 0;
                    total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                    ckbSurpresa.Checked = false;

                    lblTotalPronta.Text = ("R$" + total + ",00");
                }
            }
        }
        private void ckbFrancesa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFrancesa.Checked)
            {
                nudFracesa.Value = 1;
            }
            else
            {
                nudFracesa.Value = 0;
            }
        }
        private void nudFracesa_ValueChanged(object sender, EventArgs e)
        {
            if (nudFracesa.Value >= 1)
            {
                VFrancesa = (Convert.ToInt32(nudFracesa.Value) * francesa);
                total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                ckbFrancesa.Checked = true;

                lblTotalPronta.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudFracesa.Value == 0)
                {
                    VFrancesa = 0;
                    total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                    ckbFrancesa.Checked = false;

                    lblTotalPronta.Text = ("R$" + total + ",00");
                }
            }
        }
        private void ckbGeneroso_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbGeneroso.Checked)
            {
                nudGeneroso.Value = 1;
            }
            else
            {
                nudGeneroso.Value = 0;
            }
        }
        private void nudGeneroso_ValueChanged(object sender, EventArgs e)
        {
            if (nudGeneroso.Value >= 1)
            {
                VGeneroso = (Convert.ToInt32(nudGeneroso.Value) * generoso);
                total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                ckbGeneroso.Checked = true;

                lblTotalPronta.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudGeneroso.Value == 0)
                {
                    VGeneroso = (Convert.ToInt32(nudGeneroso.Value) * generoso);
                    total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                    ckbGeneroso.Checked = false;

                    lblTotalPronta.Text = ("R$" + total + ",00");
                }
            }
        }
        private void ckbPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPremium.Checked)
            {
                nudPremium.Value = 1;
            }
            else
            {
                nudPremium.Value = 0;
            }
        }
        private void nudPremium_ValueChanged(object sender, EventArgs e)
        {
            if (nudPremium.Value >= 1)
            {
                VPremium = (Convert.ToInt32(nudPremium.Value) * premium);
                total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                ckbPremium.Checked = true;

                lblTotalPronta.Text = ("R$" + total + ",00");
            }
            else
            {
                VPremium = 0;
                total = VBasico + VGrande + VSurpresa + VFrancesa + VGeneroso + VPremium;

                ckbPremium.Checked = false;

                lblTotalPronta.Text = ("R$" + total + ",00");
            }
        }
        private void btnAddPronta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja inserir estes itens no carrinho?", "Informação",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nudBasico.Value >= 1)
                {
                    lstAgenda.Items.Add("Cesta de café da manhã básico (" + nudBasico.Value + "un)");
                }
                if (nudGrande.Value >= 1)
                {
                    lstAgenda.Items.Add("Cesta de café da manhã grande (" + nudGrande.Value + "un)");
                }
                if (nudSurpresa.Value >= 1)
                {
                    lstAgenda.Items.Add("Cesta de café da manhã surpresa (" + nudSurpresa.Value + "un)");
                }
                if (nudFracesa.Value >= 1)
                {
                    lstAgenda.Items.Add("Cesta de café da manhã francesa (" + nudFracesa.Value + "un)");
                }
                if (nudGeneroso.Value >= 1)
                {
                    lstAgenda.Items.Add("Cesta de café da manhã genereso (" + nudGeneroso.Value + "un)");
                }
                if (nudPremium.Value >= 1)
                {
                    lstAgenda.Items.Add("Cesta de café da manhã premium (" + nudPremium.Value + "un)");
                }
                if (total >= 1 )
                {
                    lstAgenda1.Items.Add("R$" + total + ",00");
                }

                FileInfo salvarArquivo = new FileInfo(@"./Pedido.txt");
                if (lstAgenda.Items.Count > 0)
                {
                    if (!salvarArquivo.Exists)
                    {
                        using (StreamWriter sa = salvarArquivo.CreateText())
                        {
                            for (int i = 0; i < lstAgenda.Items.Count; i++)
                            {
                                sa.WriteLine(lstAgenda.Items[i].ToString());
                            }
                        }
                        MessageBox.Show("Pedido adicionado ao carrinho com sucesso!",
                           "informação",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                    }

                }

                FileInfo salvarPreco = new FileInfo(@"./Preço.txt");
                if (lstAgenda1.Items.Count > 0)
                {
                    if (!salvarPreco.Exists)
                    {
                        using (StreamWriter sa = salvarPreco.CreateText())
                        {
                            for (int i = 0; i < lstAgenda1.Items.Count; i++)
                            {
                                sa.WriteLine(lstAgenda1.Items[i].ToString());
                            }
                        }
                    }

                }
            }

            {
                nt = new Thread(frmCarro);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
                this.Close();
            }

        }
    }
}
