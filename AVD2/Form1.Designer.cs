namespace AVD2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            txtValorAposta = new TextBox();
            lblValorAposta = new Label();
            btnRoleta = new Button();
            lstResultados = new ListBox();
            btnCacaNiquel = new Button();
            panelRoletaPopup = new Panel();
            cmbEscolhaCor = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtNumeroEscolhido = new TextBox();
            btnFecharPopup = new Button();
            label2 = new Label();
            cmbTipoAposta = new ComboBox();
            btnApostarRoleta = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelRoletaPopup.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(300, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 88);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 103);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 1;
            label1.Text = "Jogou, ganhou!";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(79, 154);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(52, 21);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "Saldo:";
            lblSaldo.Click += label2_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(137, 154);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.ReadOnly = true;
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 3;
            // 
            // txtValorAposta
            // 
            txtValorAposta.Location = new Point(202, 192);
            txtValorAposta.Name = "txtValorAposta";
            txtValorAposta.Size = new Size(100, 23);
            txtValorAposta.TabIndex = 4;
            // 
            // lblValorAposta
            // 
            lblValorAposta.AutoSize = true;
            lblValorAposta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorAposta.Location = new Point(79, 192);
            lblValorAposta.Name = "lblValorAposta";
            lblValorAposta.Size = new Size(117, 21);
            lblValorAposta.TabIndex = 5;
            lblValorAposta.Text = "Valor da aposta";
            // 
            // btnRoleta
            // 
            btnRoleta.Location = new Point(452, 339);
            btnRoleta.Name = "btnRoleta";
            btnRoleta.Size = new Size(75, 69);
            btnRoleta.TabIndex = 6;
            btnRoleta.Text = "Jogar \"roleta mágica\"!";
            btnRoleta.UseVisualStyleBackColor = true;
            btnRoleta.Click += btnRoleta_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(77, 235);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(348, 184);
            lstResultados.TabIndex = 8;
            // 
            // btnCacaNiquel
            // 
            btnCacaNiquel.Location = new Point(581, 339);
            btnCacaNiquel.Name = "btnCacaNiquel";
            btnCacaNiquel.RightToLeft = RightToLeft.No;
            btnCacaNiquel.Size = new Size(75, 69);
            btnCacaNiquel.TabIndex = 7;
            btnCacaNiquel.Text = "Jogar \"Escolha sua sorte\"!";
            btnCacaNiquel.UseVisualStyleBackColor = true;
            btnCacaNiquel.Click += btnCacaNiquel_Click;
            // 
            // panelRoletaPopup
            // 
            panelRoletaPopup.BackColor = SystemColors.HighlightText;
            panelRoletaPopup.Controls.Add(cmbEscolhaCor);
            panelRoletaPopup.Controls.Add(label4);
            panelRoletaPopup.Controls.Add(label3);
            panelRoletaPopup.Controls.Add(txtNumeroEscolhido);
            panelRoletaPopup.Controls.Add(btnFecharPopup);
            panelRoletaPopup.Controls.Add(label2);
            panelRoletaPopup.Controls.Add(cmbTipoAposta);
            panelRoletaPopup.Controls.Add(btnApostarRoleta);
            panelRoletaPopup.Location = new Point(574, 149);
            panelRoletaPopup.Name = "panelRoletaPopup";
            panelRoletaPopup.Size = new Size(200, 289);
            panelRoletaPopup.TabIndex = 9;
            panelRoletaPopup.Visible = false;
            // 
            // cmbEscolhaCor
            // 
            cmbEscolhaCor.FormattingEnabled = true;
            cmbEscolhaCor.Items.AddRange(new object[] { "Vermelho", "Preto" });
            cmbEscolhaCor.Location = new Point(43, 177);
            cmbEscolhaCor.Name = "cmbEscolhaCor";
            cmbEscolhaCor.Size = new Size(121, 23);
            cmbEscolhaCor.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 159);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 6;
            label4.Text = "Sua cor da sorte!!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 111);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 5;
            label3.Text = "seu numero da sorte";
            // 
            // txtNumeroEscolhido
            // 
            txtNumeroEscolhido.Location = new Point(70, 129);
            txtNumeroEscolhido.Name = "txtNumeroEscolhido";
            txtNumeroEscolhido.Size = new Size(65, 23);
            txtNumeroEscolhido.TabIndex = 4;
            // 
            // btnFecharPopup
            // 
            btnFecharPopup.Location = new Point(160, 10);
            btnFecharPopup.Name = "btnFecharPopup";
            btnFecharPopup.Size = new Size(28, 23);
            btnFecharPopup.TabIndex = 3;
            btnFecharPopup.Text = "X";
            btnFecharPopup.UseVisualStyleBackColor = true;
            btnFecharPopup.Click += btnFecharPopup_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 47);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 2;
            label2.Text = "Tipo de aposta";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbTipoAposta
            // 
            cmbTipoAposta.FormattingEnabled = true;
            cmbTipoAposta.Items.AddRange(new object[] { "Numero", "Cor" });
            cmbTipoAposta.Location = new Point(17, 71);
            cmbTipoAposta.Name = "cmbTipoAposta";
            cmbTipoAposta.Size = new Size(171, 23);
            cmbTipoAposta.TabIndex = 1;
            cmbTipoAposta.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnApostarRoleta
            // 
            btnApostarRoleta.Location = new Point(68, 252);
            btnApostarRoleta.Name = "btnApostarRoleta";
            btnApostarRoleta.Size = new Size(75, 23);
            btnApostarRoleta.TabIndex = 0;
            btnApostarRoleta.Text = "Jogar!!";
            btnApostarRoleta.UseVisualStyleBackColor = true;
            btnApostarRoleta.Click += btnApostarRoleta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRoletaPopup);
            Controls.Add(lstResultados);
            Controls.Add(btnCacaNiquel);
            Controls.Add(btnRoleta);
            Controls.Add(lblValorAposta);
            Controls.Add(txtValorAposta);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelRoletaPopup.ResumeLayout(false);
            panelRoletaPopup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private TextBox txtValorAposta;
        private Label lblValorAposta;
        private Button btnRoleta;
        private ListBox lstResultados;
        private Button btnCacaNiquel;
        private Panel panelRoletaPopup;
        private Button btnApostarRoleta;
        private Button btnFecharPopup;
        private Label label2;
        private ComboBox cmbTipoAposta;
        private ComboBox cmbEscolhaCor;
        private Label label4;
        private Label label3;
        private TextBox txtNumeroEscolhido;
    }
}
