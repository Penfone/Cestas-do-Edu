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
    public partial class frmMonte : Form
    {
        Thread nt;

        //preços
        int total = 0;
        int paoFrances = 2;
        int VPaoFrances = 0;
        int paoForma = 5;
        int VPaoForma = 0;
        int paoCaseiro = 7;
        int VPaoCaseiro = 0;
        int paoMel = 1;
        int VPaoMel = 0;
        int trufa = 3;
        int VTrufa = 0;
        int bolinho = 2;
        int VBolinho = 0;
        int sonho = 5;
        int VSonho = 0;
        int bomba = 7;
        int VBomba = 0;
        int paoQueijo = 3;
        int VPaoQueijo = 0;
        int croissant = 7;
        int VCroissant = 0;
        int batata = 4;
        int VBatata = 0;
        int queijoM = 8;
        int VQueijoM = 0;
        int queijoP = 11;
        int VQueijoP = 0;
        int presunto = 8;
        int VPresunto = 0;
        int mortadela = 10;
        int VMortadela = 0;
        int peitoPeru = 12;
        int VPeitoPeru = 0;
        int barra = 3;
        int VBarra = 0;
        int sand = 8;
        int VSand = 0;
        int yogurte = 6;
        int VYogurt = 0;
        int leite = 2;
        int VLeite = 0;
        int suco = 7;
        int VSuco = 0;
        int energetico = 9;
        int VEnergetico = 0;
        int vinho = 12;
        int VVinho = 0;
        int cha = 5;
        int VCha = 0;

        public frmMonte()
        {
            InitializeComponent();
        }

        private void btnMinMonte_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFecharMonte_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "informação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete(@"pedido.txt");
                File.Delete(@"preço.txt");
                this.Close();
            }
        }

        private void btnInicioMonte_Click(object sender, EventArgs e)
        
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
        
        private void btnProntaMonte_Click(object sender, EventArgs e)
        
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

        private void btnCarroMonte_Click(object sender, EventArgs e)
        
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

        private void ckbPaoFrances_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPaoFrances.Checked)
            {
                nudPaoFrances.Value = 1;
            }
            else
            {
                 nudPaoFrances.Value = 0;
            }     

        }
        private void nudPaoFrances_ValueChanged(object sender, EventArgs e)
         {
            if (nudPaoFrances.Value >= 1)
            {
                VPaoFrances = (Convert.ToInt32(nudPaoFrances.Value) * paoFrances);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPaoFrances.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudPaoFrances.Value == 0)
                {
                    VPaoFrances = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbPaoFrances.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }
         }
        private void ckbPaoForma_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPaoForma.Checked)
            {
                nudPaoForma.Value = 1;
            }
            else
            {
                nudPaoForma.Value = 0;
            }
        }
        private void nudPaoForma_ValueChanged(object sender, EventArgs e)
        {
            if (nudPaoForma.Value >= 1)
            {
                VPaoForma = (Convert.ToInt32(nudPaoForma.Value) * paoForma);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPaoForma.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudPaoForma.Value == 0)
                {
                    VPaoForma = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbPaoForma.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }
        }
        private void ckbPaoCaseiro_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPaoCaseiro.Checked)
            {
                nudPaoCaseiro.Value = 1;
            }
            else
            {
                nudPaoCaseiro.Value = 0;
            }
        }
        private void nudPaoCaseiro_ValueChanged(object sender, EventArgs e)
        {
            if (nudPaoCaseiro.Value >= 1)
            {
                VPaoCaseiro = (Convert.ToInt32(nudPaoCaseiro.Value) * paoCaseiro);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPaoCaseiro.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudPaoCaseiro.Value == 0)
                {
                    VPaoCaseiro = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbPaoCaseiro.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }
        }
        private void ckbPaoMel_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPaoMel.Checked)
            {
                nudPaoMel.Value = 1;
            }
            else
            {
                nudPaoMel.Value = 0;
            }
        }
        private void nudPaoMel_ValueChanged(object sender, EventArgs e)
        {
            if (nudPaoMel.Value >= 1)
            {
                VPaoMel = (Convert.ToInt32(nudPaoMel.Value) * paoMel);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPaoMel.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VPaoMel = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPaoMel.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            
        }
        private void ckbTrufa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTrufa.Checked)
            {
                nudTrufa.Value = 1;
            }
            else
            {
                nudTrufa.Value = 0;
            }
        }
        private void nudTrufa_ValueChanged(object sender, EventArgs e)
        {
            if (nudTrufa.Value >= 1)
            {
                VTrufa = (Convert.ToInt32(nudTrufa.Value) * trufa);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbTrufa.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudPaoMel.Value == 0)
                {
                    VTrufa = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbTrufa.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbBolinho_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBolinho.Checked)
            {
                nudBolinho.Value = 1;
            }
            else
            {
                nudBolinho.Value = 0;
            }
        }
        private void nudBolinho_ValueChanged(object sender, EventArgs e)
        {
            if (nudBolinho.Value >= 1)
            {
                 VBolinho = (Convert.ToInt32(nudBolinho.Value) * bolinho);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbBolinho.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VBolinho = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbBolinho.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }

        }
        private void ckbSonho_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSonho.Checked)
            {
                nudSonho.Value = 1;
            }
            else
            {
                nudSonho.Value = 0;
            }
        }
        private void nudSonho_ValueChanged(object sender, EventArgs e)
        {
            if (nudSonho.Value >= 1)
            {
                VSonho = (Convert.ToInt32(nudSonho.Value) * sonho);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbSonho.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudSonho.Value == 0)
                {
                    VSonho = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbSonho.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbBomba_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBomba.Checked)
            {
                nudBomba.Value = 1;
            }
            else
            {
                nudBomba.Value = 0;
            }
        }
        private void nudBomba_ValueChanged(object sender, EventArgs e)
        {
            if (nudBomba.Value >= 1)
            {
                VBomba = (Convert.ToInt32(nudBomba.Value) * bomba);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbBomba.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VBomba = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbBomba.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }

        }
        private void ckbPaoQueijo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPaoQueijo.Checked)
            {
                nudPaoQueijo.Value = 1;
            }
            else
            {
                nudPaoQueijo.Value = 0;    
            }
        }
        private void nudPaoQueijo_ValueChanged(object sender, EventArgs e)
        {
            if (nudPaoQueijo.Value >= 1)
            {
                VPaoQueijo = (Convert.ToInt32(nudPaoQueijo.Value) * paoQueijo);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPaoQueijo.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VPaoQueijo = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPaoQueijo.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }

        }
        private void ckbCroissant_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCroissant.Checked)
            {
                nudCroissant.Value = 1;
            }
            else
            {
                nudCroissant.Value = 0;
            }
        }
        private void nudCroissant_ValueChanged(object sender, EventArgs e)
        {
            if (nudCroissant.Value >= 1)
            {
                VCroissant = (Convert.ToInt32(nudCroissant.Value) * croissant);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbCroissant.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudCroissant.Value == 0)
                {
                    VCroissant = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbCroissant.Checked = false;


                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbBatata_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBatata.Checked)
            {
                nudBatata.Value = 1;
            }
            else
            {
                nudBatata.Value = 0;
            }
        }
        private void nudBatata_ValueChanged(object sender, EventArgs e)
        {
            if (nudBatata.Value >= 1)
            {
                VBatata = (Convert.ToInt32(nudBatata.Value) * batata);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbBatata.Checked = true;


                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VBatata = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbBatata.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }

        }
        private void ckbQueijoM_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQueijoM.Checked)
            {
                nudQueijoM.Value = 1;
            }
            else
            {
                nudQueijoM.Value = 0;
            }
        }
        private void nudQueijoM_ValueChanged(object sender, EventArgs e)
        {
            if (nudQueijoM.Value >= 1)
            {
                VQueijoM = (Convert.ToInt32(nudQueijoM.Value) * queijoM);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbQueijoM.Checked = true;


                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VQueijoM = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbQueijoM.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
        }
        private void ckbQueijoP_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQueijoP.Checked)
            {
                nudQueijoP.Value = 1;
            }
            else
            {
                nudQueijoP.Value = 0;
            }
        }
        private void nudQueijoP_ValueChanged(object sender, EventArgs e)
        {
            if (nudQueijoP.Value >= 1)
            {
                VQueijoP = (Convert.ToInt32(nudQueijoP.Value) * queijoP);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbQueijoP.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudQueijoP.Value == 0)
                {
                    VQueijoP = (Convert.ToInt32(nudQueijoP.Value) * queijoP);
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbQueijoP.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPresunto.Checked)
            {
                nudPresunto.Value = 1;
            }
            else
            {
                nudPresunto.Value = 0;
            }
        }
        private void nudPresunto_ValueChanged(object sender, EventArgs e)
        {
            if (nudPresunto.Value >= 1)
            {
                VPresunto = (Convert.ToInt32(nudPresunto.Value) * presunto);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPresunto.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudPresunto.Value == 0)
                {
                    VPresunto = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbPresunto.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbMortadela_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMortadela.Checked)
            {
                nudMortadela.Value = 1;
            }
            else
            {
                nudMortadela.Value = 0;
            }
        }
        private void nudMortadela_ValueChanged(object sender, EventArgs e)
        {
            if (nudMortadela.Value >= 1)
            {
                VMortadela = (Convert.ToInt32(nudMortadela.Value) * mortadela);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbMortadela.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudMortadela.Value == 0)
                {
                    VMortadela = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbMortadela.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }
 
        }
        private void ckbPeito_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPeito.Checked)
            {
                nudPeito.Value = 1;
            }
            else
            {
                nudPeito.Value = 0;
            }
        }
        private void nudPeito_ValueChanged(object sender, EventArgs e)
        {
            if (nudPeito.Value >= 1)
            {
                VPeitoPeru = (Convert.ToInt32(nudPeito.Value) * peitoPeru);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbPeito.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudPeito.Value == 0)
                {
                    VPeitoPeru = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbPeito.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }
 
        }
        private void ckbBarra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBarra.Checked)
            {
                nudBarra.Value = 1;
            }
            else
            {
                nudBarra.Value = 0;
            }
        }
        private void nudBarra_ValueChanged(object sender, EventArgs e)
        {
            if (nudBarra.Value >= 1)
            {
                 VBarra = (Convert.ToInt32(nudBarra.Value) * barra);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbBarra.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudBarra.Value == 0)
                {
                    VBarra = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbBarra.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbSand_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSand.Checked)
            {
                nudSand.Value = 1;
            }
            else
            {
                nudSand.Value = 0;
            }
        }
        private void nudSand_ValueChanged(object sender, EventArgs e)
        {
            if (nudSand.Value >= 1)
            {
                VSand = (Convert.ToInt32(nudSand.Value) * sand);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbSand.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudSand.Value == 0)
                {
                    VSand = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbSand.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbYogurte_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbYogurte.Checked)
            {
                nudYogurte.Value = 1;
            }
            else
            {
                nudYogurte.Value = 0;
            }
        }
        private void nudYogurte_ValueChanged(object sender, EventArgs e)
        {
            if (nudYogurte.Value >= 1)
            {
                VYogurt = (Convert.ToInt32(nudYogurte.Value) * yogurte);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbYogurte.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VYogurt = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbYogurte.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }

        }
        private void ckbLeite_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLeite.Checked)
            {
                nudLeite.Value = 1;
            }
            else
            {
                nudLeite.Value = 0;
            }
        }
        private void nudLeite_ValueChanged(object sender, EventArgs e)
        {
            if (nudLeite.Value >= 1)
            {
                VLeite = (Convert.ToInt32(nudLeite.Value) * leite);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbLeite.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudLeite.Value == 0)
                {
                    VLeite = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbLeite.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbSuco_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSuco.Checked)
            {
                nudSuco.Value = 1;
            }
            else
            {
                nudSuco.Value = 0;
            }
        }
        private void nudSuco_ValueChanged(object sender, EventArgs e)
        {
            if (nudSuco.Value >= 1)
            {
                VSuco = (Convert.ToInt32(nudSuco.Value) * suco);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbSuco.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudSuco.Value == 0)
                {
                    VSuco = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbSuco.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbEnergetico_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEnergetico.Checked)
            {
                nudEnergetico.Value = 1;
            }
            else
            {
                nudEnergetico.Value = 0; 
            }
        }
        private void nudEnergetico_ValueChanged(object sender, EventArgs e)
        {
            if (nudEnergetico.Value >= 1)
            {
                VEnergetico = (Convert.ToInt32(nudEnergetico.Value) * energetico);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbEnergetico.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudEnergetico.Value == 0)
                {
                    VEnergetico = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbEnergetico.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }

        }
        private void ckbVinho_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVinho.Checked)
            {
                nudVinho.Value = 1;
            }
            else
            {
                nudVinho.Value = 0;
            }
        }
        private void nudVinho_ValueChanged(object sender, EventArgs e)
        {
            if (nudVinho.Value >= 1)
            {
                VVinho = (Convert.ToInt32(nudVinho.Value) * vinho);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbVinho.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                VVinho = 0;
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbVinho.Checked = false;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            
        }
        private void ckbCha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCha.Checked)
            {
                nudCha.Value = 1;
            }
            else
            {
                nudCha.Value = 0;
            }
        }
        private void nudCha_ValueChanged(object sender, EventArgs e)
        {
            if (nudCha.Value >= 1)
            {
                VCha = (Convert.ToInt32(nudCha.Value) * cha);
                total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                        VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                        VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                ckbCha.Checked = true;

                lblTotalMonte.Text = ("R$" + total + ",00");
            }
            else
            {
                if (nudCha.Value == 0)
                {
                    VCha = 0;
                    total = VPaoFrances + VPaoForma + VPaoCaseiro + VPaoMel + VTrufa + VBolinho + VSonho + VBomba +
                            VPaoQueijo + VCroissant + VBatata + VQueijoM + VQueijoP + VPresunto + VMortadela + VPeitoPeru +
                            VBarra + VSand + VYogurt + VLeite + VSuco + VEnergetico + VVinho + VCha;

                    ckbCha.Checked = false;

                    lblTotalMonte.Text = ("R$" + total + ",00");
                }
            }
 
        }

        private void btnAddMonte_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Deseja inserir estes itens no carrinho?", "Informação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (nudPaoFrances.Value >= 1)
                {
                    lstAgenda.Items.Add("Pão Francês (" + nudPaoFrances.Value + "un)");
                }
                if (nudPaoForma.Value >= 1)
                {
                    lstAgenda.Items.Add("Pão de Forma (" + nudPaoForma.Value + "un)");
                }
                if (nudPaoCaseiro.Value >= 1)
                {
                    lstAgenda.Items.Add("Pão Caseiro (" + nudPaoCaseiro.Value + "un)");
                }
                if (nudPaoMel.Value >= 1)
                {
                    lstAgenda.Items.Add("Pão de Mel (" + nudPaoMel.Value + "un)");
                }
                if (nudTrufa.Value >= 1)
                {
                    lstAgenda.Items.Add("Trufa (" + nudTrufa.Value + "un)");
                }
                if (nudBolinho.Value >= 1)
                {
                    lstAgenda.Items.Add("Bolinho (" + nudBolinho.Value + "un)");
                }
                if (nudSonho.Value >= 1)
                {
                    lstAgenda.Items.Add("Sonho (" + nudSonho.Value + "un)");
                }
                if (nudBomba.Value >= 1)
                {
                    lstAgenda.Items.Add("Bomba de chocolate (" + nudBomba.Value + "un)");
                }
                if (nudPaoQueijo.Value >= 1)
                {
                    lstAgenda.Items.Add("Pão de Queijo (" + nudPaoQueijo.Value + "un)");
                }
                if (nudCroissant.Value >= 1)
                {
                    lstAgenda.Items.Add("Croissant (" + nudCroissant.Value + "un)");
                }
                if (nudBatata.Value >= 1)
                {
                    lstAgenda.Items.Add("Batata (" + nudBatata.Value + "un)");
                }
                if (nudQueijoM.Value >= 1)
                {
                    lstAgenda.Items.Add("Queijo Mussarela(150g) (" + nudQueijoM.Value + "un)");
                }
                if (nudQueijoP.Value >= 1)
                {
                    lstAgenda.Items.Add("Queijo Provolone(150g) (" + nudQueijoP.Value + "un)");
                }
                if (nudPresunto.Value >= 1)
                {
                    lstAgenda.Items.Add("Presunto(150g) (" + nudPresunto.Value + "un)");
                }
                if (nudMortadela.Value >= 1)
                {
                    lstAgenda.Items.Add("Mortadela(150g) (" + nudMortadela.Value + "un)");
                }
                if (nudPeito.Value >= 1)
                {
                    lstAgenda.Items.Add("Peito de Peru(150g) (" + nudPeito.Value + "un)");
                }
                if (nudBarra.Value >= 1)
                {
                    lstAgenda.Items.Add("Barra (" + nudBarra.Value + "un)");
                }
                if (nudSand.Value >= 1)
                {
                    lstAgenda.Items.Add("Sanduíche natural (" + nudSand.Value + "un)");
                }
                if (nudYogurte.Value >= 1)
                {
                    lstAgenda.Items.Add("Yogurte (" + nudYogurte.Value + "un)");
                }
                if (nudLeite.Value >= 1)
                {
                    lstAgenda.Items.Add("Achocolatado(200ml) (" + nudLeite.Value + "un)");
                }
                if (nudSuco.Value >= 1)
                {
                    lstAgenda.Items.Add("Suco natural(200ml) (" + nudSuco.Value + "un)");
                }
                if (nudEnergetico.Value >= 1)
                {
                    lstAgenda.Items.Add("Energético(500ml) (" + nudEnergetico.Value + "un)");
                }
                if (nudVinho.Value >= 1)
                {
                    lstAgenda.Items.Add("Vinho(1l) (" + nudVinho.Value + "un)");
                }
                if (nudCha.Value >= 1)
                {
                    lstAgenda.Items.Add("Chá Gelado(750ml) (" + nudCha.Value + "un)");
                }
                if (total > 0)
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

                {
                    nt = new Thread(frmCarro);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                    this.Close();
                }
            }
            
        }
    }
}
