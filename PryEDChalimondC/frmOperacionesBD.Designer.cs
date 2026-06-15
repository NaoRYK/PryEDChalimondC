namespace PryEDChalimondC
{
    partial class frmOperacionesBD
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
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.gbProyeccion = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.btnSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.gbAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.gbProyeccion.SuspendLayout();
            this.gbSeleccion.SuspendLayout();
            this.gbAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(12, 179);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.Size = new System.Drawing.Size(650, 259);
            this.dgvOperaciones.TabIndex = 0;
            // 
            // gbProyeccion
            // 
            this.gbProyeccion.Controls.Add(this.btnJuntar);
            this.gbProyeccion.Controls.Add(this.btnProyeccionMultiatributo);
            this.gbProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.gbProyeccion.Location = new System.Drawing.Point(12, 12);
            this.gbProyeccion.Name = "gbProyeccion";
            this.gbProyeccion.Size = new System.Drawing.Size(200, 161);
            this.gbProyeccion.TabIndex = 1;
            this.gbProyeccion.TabStop = false;
            this.gbProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 114);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(188, 30);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(6, 78);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(188, 30);
            this.btnProyeccionMultiatributo.TabIndex = 1;
            this.btnProyeccionMultiatributo.Text = "Proyección multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiatributo.Click += new System.EventHandler(this.btnProyeccionMultiatributo_Click);
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(6, 42);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(188, 30);
            this.btnProyeccionSimple.TabIndex = 0;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.btnSeleccionConvolucion);
            this.gbSeleccion.Controls.Add(this.btnSeleccionMultiatributo);
            this.gbSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.gbSeleccion.Location = new System.Drawing.Point(232, 12);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Size = new System.Drawing.Size(200, 161);
            this.gbSeleccion.TabIndex = 3;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(6, 114);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(188, 30);
            this.btnSeleccionConvolucion.TabIndex = 2;
            this.btnSeleccionConvolucion.Text = "Selección por convolución";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvolucion.Click += new System.EventHandler(this.btnSeleccionConvolucion_Click);
            // 
            // btnSeleccionMultiatributo
            // 
            this.btnSeleccionMultiatributo.Location = new System.Drawing.Point(6, 78);
            this.btnSeleccionMultiatributo.Name = "btnSeleccionMultiatributo";
            this.btnSeleccionMultiatributo.Size = new System.Drawing.Size(188, 30);
            this.btnSeleccionMultiatributo.TabIndex = 1;
            this.btnSeleccionMultiatributo.Text = "Selección multiatributo";
            this.btnSeleccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnSeleccionMultiatributo.Click += new System.EventHandler(this.btnSeleccionMultiatributo_Click);
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 42);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(188, 30);
            this.btnSeleccionSimple.TabIndex = 0;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            this.btnSeleccionSimple.Click += new System.EventHandler(this.btnSeleccionSimple_Click);
            // 
            // gbAlgebraicas
            // 
            this.gbAlgebraicas.Controls.Add(this.btnDiferencia);
            this.gbAlgebraicas.Controls.Add(this.btnInterseccion);
            this.gbAlgebraicas.Controls.Add(this.btnUnion);
            this.gbAlgebraicas.Location = new System.Drawing.Point(452, 12);
            this.gbAlgebraicas.Name = "gbAlgebraicas";
            this.gbAlgebraicas.Size = new System.Drawing.Size(200, 161);
            this.gbAlgebraicas.TabIndex = 4;
            this.gbAlgebraicas.TabStop = false;
            this.gbAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 114);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(188, 30);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(6, 78);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(188, 30);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 42);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(188, 30);
            this.btnUnion.TabIndex = 0;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // frmOperacionesBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.gbAlgebraicas);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.gbProyeccion);
            this.Controls.Add(this.dgvOperaciones);
            this.Name = "frmOperacionesBD";
            this.Text = "Operaciones de Bases de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.gbProyeccion.ResumeLayout(false);
            this.gbSeleccion.ResumeLayout(false);
            this.gbAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.GroupBox gbProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.Button btnSeleccionConvolucion;
        private System.Windows.Forms.Button btnSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.GroupBox gbAlgebraicas;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}
