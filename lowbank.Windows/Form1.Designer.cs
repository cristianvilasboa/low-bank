namespace lowbank.Windows
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
            this.accountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.loadbutton = new System.Windows.Forms.Button();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.textBoxConta = new System.Windows.Forms.TextBox();
            this.labelConta = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(12, 326);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(124, 23);
            this.accountTextBox.TabIndex = 0;
            this.accountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountTextBox_KeyPress);
            // 
            // amountLabel
            // 
            this.amountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountLabel.Location = new System.Drawing.Point(3, 272);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(301, 23);
            this.amountLabel.TabIndex = 0;
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(142, 325);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(118, 24);
            this.loadbutton.TabIndex = 1;
            this.loadbutton.Text = "Carregar";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTelefone.Location = new System.Drawing.Point(310, 28);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.ReadOnly = true;
            this.textBoxTelefone.Size = new System.Drawing.Size(232, 23);
            this.textBoxTelefone.TabIndex = 2;
            this.textBoxTelefone.TextChanged += new System.EventHandler(this.textBoxTelefone_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxSaldo);
            this.panel1.Controls.Add(this.labelSaldo);
            this.panel1.Controls.Add(this.labelCpf);
            this.panel1.Controls.Add(this.textBoxCpf);
            this.panel1.Controls.Add(this.textBoxConta);
            this.panel1.Controls.Add(this.labelConta);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelTelefone);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.textBoxTelefone);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 307);
            this.panel1.TabIndex = 3;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSaldo.Location = new System.Drawing.Point(310, 272);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.ReadOnly = true;
            this.textBoxSaldo.Size = new System.Drawing.Size(232, 23);
            this.textBoxSaldo.TabIndex = 13;
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Location = new System.Drawing.Point(310, 254);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(39, 15);
            this.labelSaldo.TabIndex = 12;
            this.labelSaldo.Text = "Saldo:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(3, 135);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(31, 15);
            this.labelCpf.TabIndex = 11;
            this.labelCpf.Text = "CPF:";
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCpf.Location = new System.Drawing.Point(3, 153);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.ReadOnly = true;
            this.textBoxCpf.Size = new System.Drawing.Size(170, 23);
            this.textBoxCpf.TabIndex = 10;
            // 
            // textBoxConta
            // 
            this.textBoxConta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConta.Location = new System.Drawing.Point(371, 88);
            this.textBoxConta.Name = "textBoxConta";
            this.textBoxConta.ReadOnly = true;
            this.textBoxConta.Size = new System.Drawing.Size(171, 23);
            this.textBoxConta.TabIndex = 9;
            // 
            // labelConta
            // 
            this.labelConta.AutoSize = true;
            this.labelConta.Location = new System.Drawing.Point(371, 71);
            this.labelConta.Name = "labelConta";
            this.labelConta.Size = new System.Drawing.Size(42, 15);
            this.labelConta.TabIndex = 8;
            this.labelConta.Text = "Conta:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(3, 70);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 15);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Location = new System.Drawing.Point(3, 88);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(363, 23);
            this.textBoxEmail.TabIndex = 6;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(310, 10);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 5;
            this.labelTelefone.Text = "Telefone:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNome.Location = new System.Drawing.Point(3, 28);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.ReadOnly = true;
            this.textBoxNome.Size = new System.Drawing.Size(301, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(3, 10);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(43, 15);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome:";
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Location = new System.Drawing.Point(266, 325);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(122, 23);
            this.buttonTransferir.TabIndex = 4;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(394, 326);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(161, 23);
            this.buttonCadastrar.TabIndex = 5;
            this.buttonCadastrar.Text = "Cadastrar Cliente";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.cadastrarbutton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(570, 360);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonTransferir);
            this.Controls.Add(this.accountTextBox);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox accountTextBox;
        private Label amountLabel;
        private Button loadbutton;
        private TextBox textBoxTelefone;
        private TextBox textBoxSaldo;
        private Label labelSaldo;
        private Label labelCpf;
        private TextBox textBoxCpf;
        private TextBox textBoxConta;
        private Label labelConta;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelTelefone;
        private TextBox textBoxNome;
        private Label labelNome;
        private Button buttonTransferir;
        private Button buttonCadastrar;
    }
}