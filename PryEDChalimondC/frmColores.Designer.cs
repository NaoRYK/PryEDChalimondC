namespace PryEDChalimondC
{
    partial class frmColores
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
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnCargarColor = new System.Windows.Forms.Button();
            this.lblColores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(70, 70);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 0;
            // 
            // btnCargarColor
            // 
            this.btnCargarColor.Location = new System.Drawing.Point(79, 110);
            this.btnCargarColor.Name = "btnCargarColor";
            this.btnCargarColor.Size = new System.Drawing.Size(75, 23);
            this.btnCargarColor.TabIndex = 1;
            this.btnCargarColor.Text = "Cargar";
            this.btnCargarColor.UseVisualStyleBackColor = true;
            this.btnCargarColor.Click += new System.EventHandler(this.btnCargarColor_Click);
            // 
            // lblColores
            // 
            this.lblColores.AutoSize = true;
            this.lblColores.Location = new System.Drawing.Point(76, 36);
            this.lblColores.Name = "lblColores";
            this.lblColores.Size = new System.Drawing.Size(83, 13);
            this.lblColores.TabIndex = 2;
            this.lblColores.Text = "Ingrese un color";
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 160);
            this.Controls.Add(this.lblColores);
            this.Controls.Add(this.btnCargarColor);
            this.Controls.Add(this.txtColor);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnCargarColor;
        private System.Windows.Forms.Label lblColores;
    }
}