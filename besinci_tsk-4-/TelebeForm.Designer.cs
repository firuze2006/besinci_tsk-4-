namespace besinci_tsk_4_
{
    partial class TelebeForm
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.btnYaddaSaxla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(39, 54);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 16);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(39, 121);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(34, 16);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "Yas:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 54);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 3;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(112, 118);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(100, 22);
            this.txtYas.TabIndex = 4;
            // 
            // btnYaddaSaxla
            // 
            this.btnYaddaSaxla.Location = new System.Drawing.Point(74, 191);
            this.btnYaddaSaxla.Name = "btnYaddaSaxla";
            this.btnYaddaSaxla.Size = new System.Drawing.Size(111, 23);
            this.btnYaddaSaxla.TabIndex = 5;
            this.btnYaddaSaxla.Text = "Yadda saxla";
            this.btnYaddaSaxla.UseVisualStyleBackColor = true;
            this.btnYaddaSaxla.Click += new System.EventHandler(this.btnYaddaSaxla_Click);
            // 
            // TelebeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.btnYaddaSaxla);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAd);
            this.Name = "TelebeForm";
            this.Text = "TelebeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.Button btnYaddaSaxla;
    }
}