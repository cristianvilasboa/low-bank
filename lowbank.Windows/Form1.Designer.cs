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
            this.loadbutton = new System.Windows.Forms.Button();
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountTextBox
            // 
            this.accountTextBox.Location = new System.Drawing.Point(30, 21);
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Size = new System.Drawing.Size(124, 23);
            this.accountTextBox.TabIndex = 0;
            this.accountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountTextBox_KeyPress);
            // 
            // loadbutton
            // 
            this.loadbutton.Location = new System.Drawing.Point(160, 20);
            this.loadbutton.Name = "loadbutton";
            this.loadbutton.Size = new System.Drawing.Size(121, 23);
            this.loadbutton.TabIndex = 1;
            this.loadbutton.Text = "Carregar Saldo";
            this.loadbutton.UseVisualStyleBackColor = true;
            this.loadbutton.Click += new System.EventHandler(this.loadbutton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(36, 61);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(0, 15);
            this.amountLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 192);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.loadbutton);
            this.Controls.Add(this.accountTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox accountTextBox;
        private Button loadbutton;
        private Label amountLabel;
    }
}