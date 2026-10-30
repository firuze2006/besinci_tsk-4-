namespace besinci_tsk_4_
{
    partial class AxtarisForm
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
            this.lblAxtaris = new System.Windows.Forms.Label();
            this.txtAxtaris = new System.Windows.Forms.MaskedTextBox();
            this.btnAxtar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAxtaris
            // 
            this.lblAxtaris.AutoSize = true;
            this.lblAxtaris.Location = new System.Drawing.Point(23, 41);
            this.lblAxtaris.Name = "lblAxtaris";
            this.lblAxtaris.Size = new System.Drawing.Size(80, 16);
            this.lblAxtaris.TabIndex = 0;
            this.lblAxtaris.Text = "Axtarilan ad:";
            // 
            // txtAxtaris
            // 
            this.txtAxtaris.Location = new System.Drawing.Point(144, 38);
            this.txtAxtaris.Name = "txtAxtaris";
            this.txtAxtaris.Size = new System.Drawing.Size(130, 22);
            this.txtAxtaris.TabIndex = 1;
            // 
            // btnAxtar
            // 
            this.btnAxtar.Location = new System.Drawing.Point(87, 106);
            this.btnAxtar.Name = "btnAxtar";
            this.btnAxtar.Size = new System.Drawing.Size(95, 23);
            this.btnAxtar.TabIndex = 2;
            this.btnAxtar.Text = "Axtar";
            this.btnAxtar.UseVisualStyleBackColor = true;
            this.btnAxtar.Click += new System.EventHandler(this.btnAxtar_Click);
            // 
            // AxtarisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.btnAxtar);
            this.Controls.Add(this.txtAxtaris);
            this.Controls.Add(this.lblAxtaris);
            this.Name = "AxtarisForm";
            this.Text = "AxtarisForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAxtaris;
        private System.Windows.Forms.MaskedTextBox txtAxtaris;
        private System.Windows.Forms.Button btnAxtar;
    }
}