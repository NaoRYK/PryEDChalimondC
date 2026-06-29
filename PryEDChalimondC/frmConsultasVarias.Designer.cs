namespace PryEDChalimondC
{
    partial class frmConsultasVarias
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitle = new System.Windows.Forms.Label();
            this.lblSidebarSubtitle = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.cboOperaciones = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblQueryTitle = new System.Windows.Forms.Label();
            this.pnlQueryContainer = new System.Windows.Forms.Panel();
            this.lblSql = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblContentTitle = new System.Windows.Forms.Label();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.pnlSidebar.SuspendLayout();
            this.pnlQueryContainer.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarTitle);
            this.pnlSidebar.Controls.Add(this.lblSidebarSubtitle);
            this.pnlSidebar.Controls.Add(this.lblSelect);
            this.pnlSidebar.Controls.Add(this.cboOperaciones);
            this.pnlSidebar.Controls.Add(this.btnListar);
            this.pnlSidebar.Controls.Add(this.lblQueryTitle);
            this.pnlSidebar.Controls.Add(this.pnlQueryContainer);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(320, 611);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblSidebarTitle
            // 
            this.lblSidebarTitle.AutoSize = true;
            this.lblSidebarTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitle.ForeColor = System.Drawing.Color.White;
            this.lblSidebarTitle.Location = new System.Drawing.Point(20, 25);
            this.lblSidebarTitle.Name = "lblSidebarTitle";
            this.lblSidebarTitle.Size = new System.Drawing.Size(290, 32);
            this.lblSidebarTitle.TabIndex = 0;
            this.lblSidebarTitle.Text = "Explorador de consultas";
            // 
            // lblSidebarSubtitle
            // 
            this.lblSidebarSubtitle.AutoSize = true;
            this.lblSidebarSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSidebarSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSidebarSubtitle.Location = new System.Drawing.Point(22, 60);
            this.lblSidebarSubtitle.Name = "lblSidebarSubtitle";
            this.lblSidebarSubtitle.Size = new System.Drawing.Size(147, 17);
            this.lblSidebarSubtitle.TabIndex = 1;
            this.lblSidebarSubtitle.Text = "Repaso de operaciones";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblSelect.Location = new System.Drawing.Point(20, 110);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(139, 19);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Operación a realizar:";
            // 
            // cboOperaciones
            // 
            this.cboOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOperaciones.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboOperaciones.FormattingEnabled = true;
            this.cboOperaciones.Location = new System.Drawing.Point(20, 135);
            this.cboOperaciones.Name = "cboOperaciones";
            this.cboOperaciones.Size = new System.Drawing.Size(280, 27);
            this.cboOperaciones.TabIndex = 3;
            this.cboOperaciones.SelectedIndexChanged += new System.EventHandler(this.cboOperaciones_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(20, 185);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(280, 40);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Ejecutar Consulta";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblQueryTitle
            // 
            this.lblQueryTitle.AutoSize = true;
            this.lblQueryTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblQueryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblQueryTitle.Location = new System.Drawing.Point(20, 255);
            this.lblQueryTitle.Name = "lblQueryTitle";
            this.lblQueryTitle.Size = new System.Drawing.Size(103, 19);
            this.lblQueryTitle.TabIndex = 5;
            this.lblQueryTitle.Text = "Sentencia SQL:";
            // 
            // pnlQueryContainer
            // 
            this.pnlQueryContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(6)))), ((int)(((byte)(17)))));
            this.pnlQueryContainer.Controls.Add(this.lblSql);
            this.pnlQueryContainer.Location = new System.Drawing.Point(20, 280);
            this.pnlQueryContainer.Name = "pnlQueryContainer";
            this.pnlQueryContainer.Padding = new System.Windows.Forms.Padding(12);
            this.pnlQueryContainer.Size = new System.Drawing.Size(280, 150);
            this.pnlQueryContainer.TabIndex = 6;
            // 
            // lblSql
            // 
            this.lblSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSql.Font = new System.Drawing.Font("Consolas", 10.5F);
            this.lblSql.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.lblSql.Location = new System.Drawing.Point(12, 12);
            this.lblSql.Name = "lblSql";
            this.lblSql.Size = new System.Drawing.Size(256, 126);
            this.lblSql.TabIndex = 0;
            this.lblSql.Text = "SELECT * FROM Libro";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.lblContentTitle);
            this.pnlContent.Controls.Add(this.dgvResultados);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(320, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(664, 611);
            this.pnlContent.TabIndex = 1;
            // 
            // lblContentTitle
            // 
            this.lblContentTitle.AutoSize = true;
            this.lblContentTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblContentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblContentTitle.Location = new System.Drawing.Point(25, 25);
            this.lblContentTitle.Name = "lblContentTitle";
            this.lblContentTitle.Size = new System.Drawing.Size(223, 30);
            this.lblContentTitle.TabIndex = 0;
            this.lblContentTitle.Text = "Registros Obtenidos";
            // 
            // dgvResultados
            // 
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(25, 75);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.Size = new System.Drawing.Size(614, 511);
            this.dgvResultados.TabIndex = 1;
            // 
            // frmConsultasVarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmConsultasVarias";
            this.Text = "Repaso de Operaciones de Base de Datos";
            this.Load += new System.EventHandler(this.frmConsultasVarias_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlQueryContainer.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitle;
        private System.Windows.Forms.Label lblSidebarSubtitle;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ComboBox cboOperaciones;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblQueryTitle;
        private System.Windows.Forms.Panel pnlQueryContainer;
        private System.Windows.Forms.Label lblSql;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblContentTitle;
        private System.Windows.Forms.DataGridView dgvResultados;
    }
}
