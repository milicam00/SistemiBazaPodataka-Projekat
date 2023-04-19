
namespace OdrzavanjePuteva
{
    partial class VozilaDodaj
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
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtGor = new System.Windows.Forms.TextBox();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.txtZap = new System.Windows.Forms.TextBox();
            this.txtBrMesta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(27, 167);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(113, 20);
            this.txtReg.TabIndex = 0;
            // 
            // txtGor
            // 
            this.txtGor.Location = new System.Drawing.Point(192, 167);
            this.txtGor.Name = "txtGor";
            this.txtGor.Size = new System.Drawing.Size(113, 20);
            this.txtGor.TabIndex = 1;
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(357, 167);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(113, 20);
            this.txtBoja.TabIndex = 2;
            // 
            // txtZap
            // 
            this.txtZap.Location = new System.Drawing.Point(522, 167);
            this.txtZap.Name = "txtZap";
            this.txtZap.Size = new System.Drawing.Size(113, 20);
            this.txtZap.TabIndex = 3;
            // 
            // txtBrMesta
            // 
            this.txtBrMesta.Location = new System.Drawing.Point(689, 167);
            this.txtBrMesta.Name = "txtBrMesta";
            this.txtBrMesta.Size = new System.Drawing.Size(113, 20);
            this.txtBrMesta.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registarska oznaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tip goriva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Boja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Zapremina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(699, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Broj mesta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "SAČUVAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VozilaDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(821, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrMesta);
            this.Controls.Add(this.txtZap);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.txtGor);
            this.Controls.Add(this.txtReg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VozilaDodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DODAVANJE VOZILA";
            this.Load += new System.EventHandler(this.VozilaDodajcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtGor;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtZap;
        private System.Windows.Forms.TextBox txtBrMesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}