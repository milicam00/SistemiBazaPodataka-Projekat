
namespace OdrzavanjePuteva
{
    partial class VozilaIzmeni
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
            this.txtGor = new System.Windows.Forms.TextBox();
            this.txtBoja = new System.Windows.Forms.TextBox();
            this.txtZAP = new System.Windows.Forms.TextBox();
            this.txtReg = new System.Windows.Forms.TextBox();
            this.txtBrMeS = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxNad = new System.Windows.Forms.ComboBox();
            this.datOd = new System.Windows.Forms.DateTimePicker();
            this.datDo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGor
            // 
            this.txtGor.Location = new System.Drawing.Point(128, 46);
            this.txtGor.Name = "txtGor";
            this.txtGor.Size = new System.Drawing.Size(100, 20);
            this.txtGor.TabIndex = 0;
            // 
            // txtBoja
            // 
            this.txtBoja.Location = new System.Drawing.Point(128, 79);
            this.txtBoja.Name = "txtBoja";
            this.txtBoja.Size = new System.Drawing.Size(100, 20);
            this.txtBoja.TabIndex = 1;
            // 
            // txtZAP
            // 
            this.txtZAP.Location = new System.Drawing.Point(128, 113);
            this.txtZAP.Name = "txtZAP";
            this.txtZAP.Size = new System.Drawing.Size(100, 20);
            this.txtZAP.TabIndex = 2;
            // 
            // txtReg
            // 
            this.txtReg.Location = new System.Drawing.Point(128, 11);
            this.txtReg.Name = "txtReg";
            this.txtReg.Size = new System.Drawing.Size(100, 20);
            this.txtReg.TabIndex = 3;
            // 
            // txtBrMeS
            // 
            this.txtBrMeS.Location = new System.Drawing.Point(128, 151);
            this.txtBrMeS.Name = "txtBrMeS";
            this.txtBrMeS.Size = new System.Drawing.Size(100, 20);
            this.txtBrMeS.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(28, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(375, 108);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Registarska oznaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tip goriva";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Boja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zapremina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj mesta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Pregled nadzornika koji su upravljali vozilom:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Izaberi nadzornika:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Datum od:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 313);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Datum do:";
            // 
            // cbxNad
            // 
            this.cbxNad.FormattingEnabled = true;
            this.cbxNad.Location = new System.Drawing.Point(512, 237);
            this.cbxNad.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNad.Name = "cbxNad";
            this.cbxNad.Size = new System.Drawing.Size(151, 21);
            this.cbxNad.TabIndex = 15;
            // 
            // datOd
            // 
            this.datOd.Location = new System.Drawing.Point(512, 278);
            this.datOd.Margin = new System.Windows.Forms.Padding(2);
            this.datOd.Name = "datOd";
            this.datOd.Size = new System.Drawing.Size(151, 20);
            this.datOd.TabIndex = 16;
            // 
            // datDo
            // 
            this.datDo.Location = new System.Drawing.Point(512, 313);
            this.datDo.Margin = new System.Windows.Forms.Padding(2);
            this.datDo.Name = "datDo";
            this.datDo.Size = new System.Drawing.Size(151, 20);
            this.datDo.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "SAČUVAJ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 31);
            this.button2.TabIndex = 19;
            this.button2.Text = "DODAJ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VozilaIzmeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(697, 431);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datDo);
            this.Controls.Add(this.datOd);
            this.Controls.Add(this.cbxNad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBrMeS);
            this.Controls.Add(this.txtReg);
            this.Controls.Add(this.txtZAP);
            this.Controls.Add(this.txtBoja);
            this.Controls.Add(this.txtGor);
            this.Name = "VozilaIzmeni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IZMENA VOZILA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGor;
        private System.Windows.Forms.TextBox txtBoja;
        private System.Windows.Forms.TextBox txtZAP;
        private System.Windows.Forms.TextBox txtReg;
        private System.Windows.Forms.TextBox txtBrMeS;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxNad;
        private System.Windows.Forms.DateTimePicker datOd;
        private System.Windows.Forms.DateTimePicker datDo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}