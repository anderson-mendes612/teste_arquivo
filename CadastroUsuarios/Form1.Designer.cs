namespace CadastroUsuarios
{
    partial class frmUsuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtRM = new TextBox();
            lblRM = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            dtpNascimento = new DateTimePicker();
            cmbSexo = new ComboBox();
            lblDataNascimento = new Label();
            lblSexo = new Label();
            lblNaturalidade = new Label();
            cmbNaturalidade = new ComboBox();
            lsbMostra = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            btnCMD = new Button();
            btnBloco = new Button();
            btnCalc = new Button();
            btnChrome = new Button();
            btnSistema = new Button();
            btnPainel = new Button();
            lsbExibir = new ListBox();
            SuspendLayout();
            // 
            // txtRM
            // 
            txtRM.Location = new Point(40, 50);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(100, 23);
            txtRM.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(40, 32);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(25, 15);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(146, 32);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(268, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(268, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(269, 23);
            txtNome.TabIndex = 4;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(146, 50);
            mskCPF.Mask = "###.###.###-##";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(109, 23);
            mskCPF.TabIndex = 6;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(40, 99);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(215, 23);
            dtpNascimento.TabIndex = 7;
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Feminino", "Masculino" });
            cmbSexo.Location = new Point(268, 99);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(133, 23);
            cmbSexo.TabIndex = 8;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(40, 81);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(112, 15);
            lblDataNascimento.TabIndex = 9;
            lblDataNascimento.Text = "Data de nascimento";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(268, 81);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(31, 15);
            lblSexo.TabIndex = 10;
            lblSexo.Text = "Sexo";
            // 
            // lblNaturalidade
            // 
            lblNaturalidade.AutoSize = true;
            lblNaturalidade.Location = new Point(407, 81);
            lblNaturalidade.Name = "lblNaturalidade";
            lblNaturalidade.Size = new Size(75, 15);
            lblNaturalidade.TabIndex = 12;
            lblNaturalidade.Text = "Naturalidade";
            // 
            // cmbNaturalidade
            // 
            cmbNaturalidade.FormattingEnabled = true;
            cmbNaturalidade.Items.AddRange(new object[] { "Jaboticabal - SP", "Guariba - SP", "Matão - SP", "Monte Alto - SP", "Taquaritinga - SP", "Santa Ernestina - SP" });
            cmbNaturalidade.Location = new Point(416, 99);
            cmbNaturalidade.Name = "cmbNaturalidade";
            cmbNaturalidade.Size = new Size(121, 23);
            cmbNaturalidade.TabIndex = 11;
            // 
            // lsbMostra
            // 
            lsbMostra.Location = new Point(40, 138);
            lsbMostra.Name = "lsbMostra";
            lsbMostra.Size = new Size(100, 36);
            lsbMostra.TabIndex = 13;
            lsbMostra.Text = "Exibir";
            lsbMostra.UseVisualStyleBackColor = true;
            lsbMostra.Click += btnExibir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(146, 138);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(109, 36);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(261, 138);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(90, 36);
            btnSair.TabIndex = 15;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnCMD
            // 
            btnCMD.Location = new Point(261, 212);
            btnCMD.Name = "btnCMD";
            btnCMD.Size = new Size(90, 50);
            btnCMD.TabIndex = 18;
            btnCMD.Text = "CMD";
            btnCMD.UseVisualStyleBackColor = true;
            btnCMD.Click += btnCMD_Click;
            // 
            // btnBloco
            // 
            btnBloco.Location = new Point(146, 212);
            btnBloco.Name = "btnBloco";
            btnBloco.Size = new Size(109, 50);
            btnBloco.TabIndex = 17;
            btnBloco.Text = "Bloco de Notas";
            btnBloco.UseVisualStyleBackColor = true;
            btnBloco.Click += btnBloco_Click;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(40, 212);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(100, 50);
            btnCalc.TabIndex = 16;
            btnCalc.Text = "Calculadora";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnChrome
            // 
            btnChrome.Location = new Point(261, 271);
            btnChrome.Name = "btnChrome";
            btnChrome.Size = new Size(90, 45);
            btnChrome.TabIndex = 21;
            btnChrome.Text = "Chrome";
            btnChrome.UseVisualStyleBackColor = true;
            btnChrome.Click += btnChrome_Click;
            // 
            // btnSistema
            // 
            btnSistema.Location = new Point(146, 268);
            btnSistema.Name = "btnSistema";
            btnSistema.Size = new Size(109, 48);
            btnSistema.TabIndex = 20;
            btnSistema.Text = "Informações do sistema";
            btnSistema.UseVisualStyleBackColor = true;
            btnSistema.Click += btnSistema_Click;
            // 
            // btnPainel
            // 
            btnPainel.Location = new Point(40, 268);
            btnPainel.Name = "btnPainel";
            btnPainel.Size = new Size(100, 48);
            btnPainel.TabIndex = 19;
            btnPainel.Text = "Painel de Controle";
            btnPainel.UseVisualStyleBackColor = true;
            btnPainel.Click += btnPainel_Click;
            // 
            // lsbExibir
            // 
            lsbExibir.FormattingEnabled = true;
            lsbExibir.ItemHeight = 15;
            lsbExibir.Location = new Point(366, 138);
            lsbExibir.Name = "lsbExibir";
            lsbExibir.Size = new Size(171, 184);
            lsbExibir.TabIndex = 22;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(lsbExibir);
            Controls.Add(btnChrome);
            Controls.Add(btnSistema);
            Controls.Add(btnPainel);
            Controls.Add(btnCMD);
            Controls.Add(btnBloco);
            Controls.Add(btnCalc);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(lsbMostra);
            Controls.Add(lblNaturalidade);
            Controls.Add(cmbNaturalidade);
            Controls.Add(lblSexo);
            Controls.Add(lblDataNascimento);
            Controls.Add(cmbSexo);
            Controls.Add(dtpNascimento);
            Controls.Add(mskCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(lblRM);
            Controls.Add(txtRM);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de usuários";
            WindowState = FormWindowState.Maximized;
            Load += frmUsuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRM;
        private Label lblRM;
        private Label lblCPF;
        private Label lblNome;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private DateTimePicker dtpNascimento;
        private ComboBox cmbSexo;
        private Label lblDataNascimento;
        private Label lblSexo;
        private Label lblNaturalidade;
        private ComboBox cmbNaturalidade;
        private Button lsbMostra;
        private Button btnLimpar;
        private Button btnSair;
        private Button btnCMD;
        private Button btnBloco;
        private Button btnCalc;
        private Button btnChrome;
        private Button btnSistema;
        private Button btnPainel;
        private ListBox lsbExibir;
    }
}
