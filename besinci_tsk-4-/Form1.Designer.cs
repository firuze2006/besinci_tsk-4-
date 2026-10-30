namespace besinci_tsk_4_
{
    partial class Form1
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
            this.lblBasliq = new System.Windows.Forms.Label();
            this.lstTelebeler = new System.Windows.Forms.ListBox();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.btnHamisi = new System.Windows.Forms.Button();
            this.btnAxtar = new System.Windows.Forms.Button();
            this.btnCixis = new System.Windows.Forms.Button();
            this.btnHamisiniSil = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBasliq
            // 
            this.lblBasliq.AutoSize = true;
            this.lblBasliq.Location = new System.Drawing.Point(45, 37);
            this.lblBasliq.Name = "lblBasliq";
            this.lblBasliq.Size = new System.Drawing.Size(99, 16);
            this.lblBasliq.TabIndex = 0;
            this.lblBasliq.Text = "Telebe siyahisi";
            // 
            // lstTelebeler
            // 
            this.lstTelebeler.FormattingEnabled = true;
            this.lstTelebeler.ItemHeight = 16;
            this.lstTelebeler.Location = new System.Drawing.Point(220, 89);
            this.lstTelebeler.Name = "lstTelebeler";
            this.lstTelebeler.Size = new System.Drawing.Size(206, 132);
            this.lstTelebeler.TabIndex = 1;
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.Location = new System.Drawing.Point(48, 76);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(121, 23);
            this.btnElaveEt.TabIndex = 2;
            this.btnElaveEt.Text = "Telebe elave et ";
            this.btnElaveEt.UseVisualStyleBackColor = true;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // btnHamisi
            // 
            this.btnHamisi.Location = new System.Drawing.Point(47, 121);
            this.btnHamisi.Name = "btnHamisi";
            this.btnHamisi.Size = new System.Drawing.Size(121, 23);
            this.btnHamisi.TabIndex = 3;
            this.btnHamisi.Text = "Hamisini goster";
            this.btnHamisi.UseVisualStyleBackColor = true;
            this.btnHamisi.Click += new System.EventHandler(this.btnHamisi_Click);
            // 
            // btnAxtar
            // 
            this.btnAxtar.Location = new System.Drawing.Point(49, 163);
            this.btnAxtar.Name = "btnAxtar";
            this.btnAxtar.Size = new System.Drawing.Size(120, 23);
            this.btnAxtar.TabIndex = 4;
            this.btnAxtar.Text = "Ada gore axtar";
            this.btnAxtar.UseVisualStyleBackColor = true;
            this.btnAxtar.Click += new System.EventHandler(this.btnAxtar_Click);
            // 
            // btnCixis
            // 
            this.btnCixis.Location = new System.Drawing.Point(306, 257);
            this.btnCixis.Name = "btnCixis";
            this.btnCixis.Size = new System.Drawing.Size(120, 23);
            this.btnCixis.TabIndex = 5;
            this.btnCixis.Text = "Cixis";
            this.btnCixis.UseVisualStyleBackColor = true;
            this.btnCixis.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHamisiniSil
            // 
            this.btnHamisiniSil.Location = new System.Drawing.Point(47, 246);
            this.btnHamisiniSil.Name = "btnHamisiniSil";
            this.btnHamisiniSil.Size = new System.Drawing.Size(121, 23);
            this.btnHamisiniSil.TabIndex = 6;
            this.btnHamisiniSil.Text = "Hamisini sil";
            this.btnHamisiniSil.UseVisualStyleBackColor = true;
            this.btnHamisiniSil.Click += new System.EventHandler(this.btnHamisiniSil_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(47, 207);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 23);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Telebeni sil ";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 342);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnHamisiniSil);
            this.Controls.Add(this.btnCixis);
            this.Controls.Add(this.btnAxtar);
            this.Controls.Add(this.btnHamisi);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.lstTelebeler);
            this.Controls.Add(this.lblBasliq);
            this.Name = "Form1";
            this.Text = "Telebe siyahisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.ListBox lstTelebeler;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Button btnHamisi;
        private System.Windows.Forms.Button btnAxtar;
        private System.Windows.Forms.Button btnCixis;
        private System.Windows.Forms.Button btnHamisiniSil;
        private System.Windows.Forms.Button btnSil;
    }
}

