namespace lowbank.Windows
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNome2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTelefone2 = new System.Windows.Forms.Label();
            this.labelEmail2 = new System.Windows.Forms.Label();
            this.labelCpf2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonSalvar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome2
            // 
            this.labelNome2.AutoSize = true;
            this.labelNome2.Location = new System.Drawing.Point(12, 9);
            this.labelNome2.Name = "labelNome2";
            this.labelNome2.Size = new System.Drawing.Size(43, 15);
            this.labelNome2.TabIndex = 0;
            this.labelNome2.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelTelefone2
            // 
            this.labelTelefone2.AutoSize = true;
            this.labelTelefone2.Location = new System.Drawing.Point(364, 9);
            this.labelTelefone2.Name = "labelTelefone2";
            this.labelTelefone2.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone2.TabIndex = 2;
            this.labelTelefone2.Text = "Telefone:";
            // 
            // labelEmail2
            // 
            this.labelEmail2.AutoSize = true;
            this.labelEmail2.Location = new System.Drawing.Point(12, 65);
            this.labelEmail2.Name = "labelEmail2";
            this.labelEmail2.Size = new System.Drawing.Size(39, 15);
            this.labelEmail2.TabIndex = 3;
            this.labelEmail2.Text = "Email:";
            // 
            // labelCpf2
            // 
            this.labelCpf2.AutoSize = true;
            this.labelCpf2.Location = new System.Drawing.Point(387, 65);
            this.labelCpf2.Name = "labelCpf2";
            this.labelCpf2.Size = new System.Drawing.Size(31, 15);
            this.labelCpf2.TabIndex = 4;
            this.labelCpf2.Text = "CPF:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(364, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(194, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 23);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(369, 23);
            this.textBox4.TabIndex = 7;
            // 
            // buttonSalvar2
            // 
            this.buttonSalvar2.Location = new System.Drawing.Point(429, 125);
            this.buttonSalvar2.Name = "buttonSalvar2";
            this.buttonSalvar2.Size = new System.Drawing.Size(129, 23);
            this.buttonSalvar2.TabIndex = 8;
            this.buttonSalvar2.Text = "Salvar";
            this.buttonSalvar2.UseVisualStyleBackColor = true;
            this.buttonSalvar2.Click += new System.EventHandler(this.buttonSalvar2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(570, 160);
            this.Controls.Add(this.buttonSalvar2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelCpf2);
            this.Controls.Add(this.labelEmail2);
            this.Controls.Add(this.labelTelefone2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNome2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNome2;
        private TextBox textBox1;
        private Label labelTelefone2;
        private Label labelEmail2;
        private Label labelCpf2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button buttonSalvar2;
    }
}