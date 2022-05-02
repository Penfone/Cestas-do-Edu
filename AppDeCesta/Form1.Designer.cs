
namespace AppDeCesta
{
    partial class FrmProntas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProntas));
            this.nudBasico = new System.Windows.Forms.NumericUpDown();
            this.nudFracesa = new System.Windows.Forms.NumericUpDown();
            this.nudGrande = new System.Windows.Forms.NumericUpDown();
            this.nudGeneroso = new System.Windows.Forms.NumericUpDown();
            this.nudSurpresa = new System.Windows.Forms.NumericUpDown();
            this.nudPremium = new System.Windows.Forms.NumericUpDown();
            this.lstSurpresa = new System.Windows.Forms.ListBox();
            this.lstBasico = new System.Windows.Forms.ListBox();
            this.lstFrancesa = new System.Windows.Forms.ListBox();
            this.lstGeneroso = new System.Windows.Forms.ListBox();
            this.lstGrande = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstPremium = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnInicioPronta = new System.Windows.Forms.Button();
            this.btnMontePronta = new System.Windows.Forms.Button();
            this.btnCarroPronta = new System.Windows.Forms.Button();
            this.lblTotalPronta = new System.Windows.Forms.Label();
            this.btnAddPronta = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.ckbBasico = new System.Windows.Forms.CheckBox();
            this.ckbGrande = new System.Windows.Forms.CheckBox();
            this.ckbSurpresa = new System.Windows.Forms.CheckBox();
            this.ckbFrancesa = new System.Windows.Forms.CheckBox();
            this.ckbGeneroso = new System.Windows.Forms.CheckBox();
            this.ckbPremium = new System.Windows.Forms.CheckBox();
            this.btnMinPronta = new System.Windows.Forms.Button();
            this.btnFecharPronta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstAgenda = new System.Windows.Forms.ListBox();
            this.lstAgenda1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudBasico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFracesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGeneroso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudBasico
            // 
            this.nudBasico.Location = new System.Drawing.Point(288, 193);
            this.nudBasico.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBasico.Name = "nudBasico";
            this.nudBasico.Size = new System.Drawing.Size(56, 27);
            this.nudBasico.TabIndex = 6;
            this.nudBasico.ValueChanged += new System.EventHandler(this.nudBasico_ValueChanged);
            // 
            // nudFracesa
            // 
            this.nudFracesa.Location = new System.Drawing.Point(288, 447);
            this.nudFracesa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFracesa.Name = "nudFracesa";
            this.nudFracesa.Size = new System.Drawing.Size(56, 27);
            this.nudFracesa.TabIndex = 7;
            this.nudFracesa.ValueChanged += new System.EventHandler(this.nudFracesa_ValueChanged);
            // 
            // nudGrande
            // 
            this.nudGrande.Location = new System.Drawing.Point(801, 193);
            this.nudGrande.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGrande.Name = "nudGrande";
            this.nudGrande.Size = new System.Drawing.Size(56, 27);
            this.nudGrande.TabIndex = 8;
            this.nudGrande.ValueChanged += new System.EventHandler(this.nudGrande_ValueChanged);
            // 
            // nudGeneroso
            // 
            this.nudGeneroso.Location = new System.Drawing.Point(801, 447);
            this.nudGeneroso.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGeneroso.Name = "nudGeneroso";
            this.nudGeneroso.Size = new System.Drawing.Size(56, 27);
            this.nudGeneroso.TabIndex = 9;
            this.nudGeneroso.ValueChanged += new System.EventHandler(this.nudGeneroso_ValueChanged);
            // 
            // nudSurpresa
            // 
            this.nudSurpresa.Location = new System.Drawing.Point(1264, 193);
            this.nudSurpresa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSurpresa.Name = "nudSurpresa";
            this.nudSurpresa.Size = new System.Drawing.Size(56, 27);
            this.nudSurpresa.TabIndex = 10;
            this.nudSurpresa.ValueChanged += new System.EventHandler(this.nudSurpresa_ValueChanged);
            // 
            // nudPremium
            // 
            this.nudPremium.Location = new System.Drawing.Point(1264, 447);
            this.nudPremium.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPremium.Name = "nudPremium";
            this.nudPremium.Size = new System.Drawing.Size(56, 27);
            this.nudPremium.TabIndex = 11;
            this.nudPremium.ValueChanged += new System.EventHandler(this.nudPremium_ValueChanged);
            // 
            // lstSurpresa
            // 
            this.lstSurpresa.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSurpresa.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstSurpresa.FormattingEnabled = true;
            this.lstSurpresa.ItemHeight = 23;
            this.lstSurpresa.Items.AddRange(new object[] {
            "Contém items aleatórios no valor ",
            "de R$130,00 reais"});
            this.lstSurpresa.Location = new System.Drawing.Point(1009, 266);
            this.lstSurpresa.Name = "lstSurpresa";
            this.lstSurpresa.Size = new System.Drawing.Size(311, 142);
            this.lstSurpresa.TabIndex = 15;
            // 
            // lstBasico
            // 
            this.lstBasico.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBasico.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstBasico.FormattingEnabled = true;
            this.lstBasico.ItemHeight = 23;
            this.lstBasico.Items.AddRange(new object[] {
            "Pão francês (5un)",
            "Queijo mussarela (150g)",
            "Presunto (150g)",
            "Bolinhos (5un)",
            "Achocolatado (200ml) (3un)"});
            this.lstBasico.Location = new System.Drawing.Point(33, 266);
            this.lstBasico.Name = "lstBasico";
            this.lstBasico.Size = new System.Drawing.Size(311, 142);
            this.lstBasico.TabIndex = 17;
            // 
            // lstFrancesa
            // 
            this.lstFrancesa.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFrancesa.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstFrancesa.FormattingEnabled = true;
            this.lstFrancesa.ItemHeight = 23;
            this.lstFrancesa.Items.AddRange(new object[] {
            "Pão francês (8un)",
            "Trufas (10un)",
            "Bomba de chocolate (3un)",
            "Croissant (3un)",
            "Batatas chips (3un)",
            "Queijo mussarela (150g)",
            "Queijo provolone (150g)",
            "Peito de peru (150g)",
            "Vinho (1l) (1un)"});
            this.lstFrancesa.Location = new System.Drawing.Point(33, 520);
            this.lstFrancesa.Name = "lstFrancesa";
            this.lstFrancesa.Size = new System.Drawing.Size(311, 142);
            this.lstFrancesa.TabIndex = 18;
            // 
            // lstGeneroso
            // 
            this.lstGeneroso.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGeneroso.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstGeneroso.FormattingEnabled = true;
            this.lstGeneroso.ItemHeight = 23;
            this.lstGeneroso.Items.AddRange(new object[] {
            "Pão de forma (pacote)",
            "Mortadela (150g)",
            "Queijo provolone (150g)",
            "Sonho (3un)",
            "Batata chips (3un)",
            "Energético (500ml) (2un)",
            "Chá gelado (750ml)",
            "Bomba de chocolate (3un)",
            "Pão de mel (8un)",
            "Trufas (10un)",
            "Yogurte (3un)",
            "Barra de cereal (5un)"});
            this.lstGeneroso.Location = new System.Drawing.Point(546, 520);
            this.lstGeneroso.Name = "lstGeneroso";
            this.lstGeneroso.Size = new System.Drawing.Size(311, 142);
            this.lstGeneroso.TabIndex = 19;
            // 
            // lstGrande
            // 
            this.lstGrande.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGrande.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstGrande.FormattingEnabled = true;
            this.lstGrande.ItemHeight = 23;
            this.lstGrande.Items.AddRange(new object[] {
            "Pão francês (10un)",
            "Queijo mussarela (150g)",
            "Queijo provolone(150g)",
            "Presunto (150g)",
            "Bolinhos (5un)",
            "Yogurte (2un)",
            "Suco natural (200ml) (2un)",
            "Pão de mel (5un)",
            "Pão de queijo (5un)"});
            this.lstGrande.Location = new System.Drawing.Point(546, 266);
            this.lstGrande.Name = "lstGrande";
            this.lstGrande.Size = new System.Drawing.Size(311, 142);
            this.lstGrande.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 22;
            this.label8.Text = "R$42,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(778, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 23;
            this.label9.Text = "R$103,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(778, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "R$175,00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(265, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "R$162,00";
            // 
            // lstPremium
            // 
            this.lstPremium.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPremium.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lstPremium.FormattingEnabled = true;
            this.lstPremium.ItemHeight = 23;
            this.lstPremium.Items.AddRange(new object[] {
            "Pão caseiro",
            "Queijo provolonoe (150g)",
            "Peito de peru (150g)",
            "Bomba de chocolate (5un)",
            "Trufas (10un)",
            "Sonho (5un)",
            "Croissant (5un)",
            "Pão de queijo (10un)",
            "Yogurte (4un)",
            "Vinho (1l) (2un)",
            "Energético (500ml) (3un)"});
            this.lstPremium.Location = new System.Drawing.Point(1009, 520);
            this.lstPremium.Name = "lstPremium";
            this.lstPremium.Size = new System.Drawing.Size(311, 142);
            this.lstPremium.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1241, 490);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 26;
            this.label12.Text = "R$260,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1241, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "R$130,00";
            // 
            // BtnInicioPronta
            // 
            this.BtnInicioPronta.AutoSize = true;
            this.BtnInicioPronta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicioPronta.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicioPronta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BtnInicioPronta.Location = new System.Drawing.Point(10, 703);
            this.BtnInicioPronta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInicioPronta.Name = "BtnInicioPronta";
            this.BtnInicioPronta.Size = new System.Drawing.Size(153, 50);
            this.BtnInicioPronta.TabIndex = 98;
            this.BtnInicioPronta.Text = "Tela inicial";
            this.BtnInicioPronta.UseVisualStyleBackColor = true;
            this.BtnInicioPronta.Click += new System.EventHandler(this.BtnInicioPronta_Click);
            // 
            // btnMontePronta
            // 
            this.btnMontePronta.AutoSize = true;
            this.btnMontePronta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMontePronta.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMontePronta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnMontePronta.Location = new System.Drawing.Point(226, 703);
            this.btnMontePronta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMontePronta.Name = "btnMontePronta";
            this.btnMontePronta.Size = new System.Drawing.Size(169, 50);
            this.btnMontePronta.TabIndex = 99;
            this.btnMontePronta.Text = "Monte sua cesta";
            this.btnMontePronta.UseVisualStyleBackColor = true;
            this.btnMontePronta.Click += new System.EventHandler(this.btnMontePronta_Click);
            // 
            // btnCarroPronta
            // 
            this.btnCarroPronta.AutoSize = true;
            this.btnCarroPronta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarroPronta.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarroPronta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCarroPronta.Location = new System.Drawing.Point(452, 703);
            this.btnCarroPronta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCarroPronta.Name = "btnCarroPronta";
            this.btnCarroPronta.Size = new System.Drawing.Size(153, 50);
            this.btnCarroPronta.TabIndex = 100;
            this.btnCarroPronta.Text = "Carrinho";
            this.btnCarroPronta.UseVisualStyleBackColor = true;
            this.btnCarroPronta.Click += new System.EventHandler(this.btnCarroPronta_Click);
            // 
            // lblTotalPronta
            // 
            this.lblTotalPronta.AutoSize = true;
            this.lblTotalPronta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPronta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPronta.Location = new System.Drawing.Point(952, 724);
            this.lblTotalPronta.Name = "lblTotalPronta";
            this.lblTotalPronta.Size = new System.Drawing.Size(94, 29);
            this.lblTotalPronta.TabIndex = 101;
            this.lblTotalPronta.Text = "R$0,00";
            // 
            // btnAddPronta
            // 
            this.btnAddPronta.AutoSize = true;
            this.btnAddPronta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPronta.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPronta.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddPronta.Location = new System.Drawing.Point(1122, 703);
            this.btnAddPronta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPronta.Name = "btnAddPronta";
            this.btnAddPronta.Size = new System.Drawing.Size(226, 50);
            this.btnAddPronta.TabIndex = 102;
            this.btnAddPronta.Text = "Adicionar ao carrinho";
            this.btnAddPronta.UseVisualStyleBackColor = true;
            this.btnAddPronta.Click += new System.EventHandler(this.btnAddPronta_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label33.Location = new System.Drawing.Point(870, 724);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(76, 29);
            this.label33.TabIndex = 103;
            this.label33.Text = "Total:";
            // 
            // ckbBasico
            // 
            this.ckbBasico.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBasico.ForeColor = System.Drawing.Color.Peru;
            this.ckbBasico.Location = new System.Drawing.Point(33, 193);
            this.ckbBasico.Name = "ckbBasico";
            this.ckbBasico.Size = new System.Drawing.Size(235, 67);
            this.ckbBasico.TabIndex = 104;
            this.ckbBasico.Text = "Cesta de café da manhã básico";
            this.ckbBasico.UseVisualStyleBackColor = true;
            this.ckbBasico.CheckedChanged += new System.EventHandler(this.ckbBasico_CheckedChanged);
            // 
            // ckbGrande
            // 
            this.ckbGrande.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGrande.ForeColor = System.Drawing.Color.Peru;
            this.ckbGrande.Location = new System.Drawing.Point(546, 193);
            this.ckbGrande.Name = "ckbGrande";
            this.ckbGrande.Size = new System.Drawing.Size(235, 67);
            this.ckbGrande.TabIndex = 105;
            this.ckbGrande.Text = "Cesta de café da manhã grande";
            this.ckbGrande.UseVisualStyleBackColor = true;
            this.ckbGrande.CheckedChanged += new System.EventHandler(this.ckbGrande_CheckedChanged);
            // 
            // ckbSurpresa
            // 
            this.ckbSurpresa.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSurpresa.ForeColor = System.Drawing.Color.Peru;
            this.ckbSurpresa.Location = new System.Drawing.Point(1009, 193);
            this.ckbSurpresa.Name = "ckbSurpresa";
            this.ckbSurpresa.Size = new System.Drawing.Size(235, 67);
            this.ckbSurpresa.TabIndex = 106;
            this.ckbSurpresa.Text = "Cesta de café da manhã surpresa";
            this.ckbSurpresa.UseVisualStyleBackColor = true;
            this.ckbSurpresa.CheckedChanged += new System.EventHandler(this.ckbSurpresa_CheckedChanged);
            // 
            // ckbFrancesa
            // 
            this.ckbFrancesa.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFrancesa.ForeColor = System.Drawing.Color.Peru;
            this.ckbFrancesa.Location = new System.Drawing.Point(33, 447);
            this.ckbFrancesa.Name = "ckbFrancesa";
            this.ckbFrancesa.Size = new System.Drawing.Size(235, 67);
            this.ckbFrancesa.TabIndex = 107;
            this.ckbFrancesa.Text = "Cesta de café da manhã francesa";
            this.ckbFrancesa.UseVisualStyleBackColor = true;
            this.ckbFrancesa.CheckedChanged += new System.EventHandler(this.ckbFrancesa_CheckedChanged);
            // 
            // ckbGeneroso
            // 
            this.ckbGeneroso.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbGeneroso.ForeColor = System.Drawing.Color.Peru;
            this.ckbGeneroso.Location = new System.Drawing.Point(546, 447);
            this.ckbGeneroso.Name = "ckbGeneroso";
            this.ckbGeneroso.Size = new System.Drawing.Size(235, 67);
            this.ckbGeneroso.TabIndex = 108;
            this.ckbGeneroso.Text = "Cesta de café da manhã generoso";
            this.ckbGeneroso.UseVisualStyleBackColor = true;
            this.ckbGeneroso.CheckedChanged += new System.EventHandler(this.ckbGeneroso_CheckedChanged);
            // 
            // ckbPremium
            // 
            this.ckbPremium.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPremium.ForeColor = System.Drawing.Color.Peru;
            this.ckbPremium.Location = new System.Drawing.Point(1009, 447);
            this.ckbPremium.Name = "ckbPremium";
            this.ckbPremium.Size = new System.Drawing.Size(235, 67);
            this.ckbPremium.TabIndex = 109;
            this.ckbPremium.Text = "Cesta de café da manhã premium";
            this.ckbPremium.UseVisualStyleBackColor = true;
            this.ckbPremium.CheckedChanged += new System.EventHandler(this.ckbPremium_CheckedChanged);
            // 
            // btnMinPronta
            // 
            this.btnMinPronta.BackColor = System.Drawing.Color.White;
            this.btnMinPronta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinPronta.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinPronta.ForeColor = System.Drawing.Color.Sienna;
            this.btnMinPronta.Location = new System.Drawing.Point(1091, 12);
            this.btnMinPronta.Name = "btnMinPronta";
            this.btnMinPronta.Size = new System.Drawing.Size(125, 27);
            this.btnMinPronta.TabIndex = 111;
            this.btnMinPronta.Text = "Minimizar";
            this.btnMinPronta.UseVisualStyleBackColor = false;
            this.btnMinPronta.Click += new System.EventHandler(this.btnMinPronta_Click);
            // 
            // btnFecharPronta
            // 
            this.btnFecharPronta.BackColor = System.Drawing.Color.White;
            this.btnFecharPronta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharPronta.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharPronta.ForeColor = System.Drawing.Color.Sienna;
            this.btnFecharPronta.Location = new System.Drawing.Point(1221, 12);
            this.btnFecharPronta.Name = "btnFecharPronta";
            this.btnFecharPronta.Size = new System.Drawing.Size(125, 27);
            this.btnFecharPronta.TabIndex = 110;
            this.btnFecharPronta.Text = "Fechar";
            this.btnFecharPronta.UseVisualStyleBackColor = false;
            this.btnFecharPronta.Click += new System.EventHandler(this.btnFecharPronta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(452, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 123);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // lstAgenda
            // 
            this.lstAgenda.FormattingEnabled = true;
            this.lstAgenda.ItemHeight = 19;
            this.lstAgenda.Location = new System.Drawing.Point(632, 703);
            this.lstAgenda.Name = "lstAgenda";
            this.lstAgenda.Size = new System.Drawing.Size(232, 42);
            this.lstAgenda.TabIndex = 113;
            this.lstAgenda.Visible = false;
            // 
            // lstAgenda1
            // 
            this.lstAgenda1.FormattingEnabled = true;
            this.lstAgenda1.ItemHeight = 19;
            this.lstAgenda1.Location = new System.Drawing.Point(112, 82);
            this.lstAgenda1.Name = "lstAgenda1";
            this.lstAgenda1.Size = new System.Drawing.Size(232, 42);
            this.lstAgenda1.TabIndex = 114;
            this.lstAgenda1.Visible = false;
            // 
            // FrmProntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 764);
            this.Controls.Add(this.lstAgenda1);
            this.Controls.Add(this.lstAgenda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMinPronta);
            this.Controls.Add(this.btnFecharPronta);
            this.Controls.Add(this.ckbPremium);
            this.Controls.Add(this.ckbGeneroso);
            this.Controls.Add(this.ckbFrancesa);
            this.Controls.Add(this.ckbSurpresa);
            this.Controls.Add(this.ckbGrande);
            this.Controls.Add(this.ckbBasico);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btnAddPronta);
            this.Controls.Add(this.lblTotalPronta);
            this.Controls.Add(this.btnCarroPronta);
            this.Controls.Add(this.btnMontePronta);
            this.Controls.Add(this.BtnInicioPronta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstGrande);
            this.Controls.Add(this.lstPremium);
            this.Controls.Add(this.lstGeneroso);
            this.Controls.Add(this.lstFrancesa);
            this.Controls.Add(this.lstBasico);
            this.Controls.Add(this.lstSurpresa);
            this.Controls.Add(this.nudPremium);
            this.Controls.Add(this.nudSurpresa);
            this.Controls.Add(this.nudGeneroso);
            this.Controls.Add(this.nudGrande);
            this.Controls.Add(this.nudFracesa);
            this.Controls.Add(this.nudBasico);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nossas cestas";
            ((System.ComponentModel.ISupportInitialize)(this.nudBasico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFracesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGeneroso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSurpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPremium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudBasico;
        private System.Windows.Forms.NumericUpDown nudFracesa;
        private System.Windows.Forms.NumericUpDown nudGrande;
        private System.Windows.Forms.NumericUpDown nudGeneroso;
        private System.Windows.Forms.NumericUpDown nudSurpresa;
        private System.Windows.Forms.NumericUpDown nudPremium;
        private System.Windows.Forms.ListBox lstSurpresa;
        private System.Windows.Forms.ListBox lstBasico;
        private System.Windows.Forms.ListBox lstFrancesa;
        private System.Windows.Forms.ListBox lstGeneroso;
        private System.Windows.Forms.ListBox lstGrande;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstPremium;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnInicioPronta;
        private System.Windows.Forms.Button btnMontePronta;
        private System.Windows.Forms.Button btnCarroPronta;
        private System.Windows.Forms.Label lblTotalPronta;
        private System.Windows.Forms.Button btnAddPronta;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.CheckBox ckbBasico;
        private System.Windows.Forms.CheckBox ckbGrande;
        private System.Windows.Forms.CheckBox ckbSurpresa;
        private System.Windows.Forms.CheckBox ckbFrancesa;
        private System.Windows.Forms.CheckBox ckbGeneroso;
        private System.Windows.Forms.CheckBox ckbPremium;
        private System.Windows.Forms.Button btnMinPronta;
        private System.Windows.Forms.Button btnFecharPronta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstAgenda;
        private System.Windows.Forms.ListBox lstAgenda1;
    }
}

