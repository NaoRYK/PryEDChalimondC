namespace PryEDChalimondC
{
    partial class frmCarreras
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre de la carrera";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(45, 86);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(175, 20);
            this.txtNombreCarrera.TabIndex = 1;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(45, 112);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(85, 37);
            this.btnGrabar.TabIndex = 3;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(135, 112);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(85, 37);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click_1);
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.Location = new System.Drawing.Point(45, 167);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(175, 121);
            this.lstCarreras.TabIndex = 2;
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 312);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.label1);
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarreras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lstCarreras;
    }
}