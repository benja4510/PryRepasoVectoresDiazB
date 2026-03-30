namespace PryRepasoVectoresDiazB
{
    partial class FrmVectores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboCargaDatos = new System.Windows.Forms.GroupBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.gboListado = new System.Windows.Forms.GroupBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListarconWhile = new System.Windows.Forms.Button();
            this.btnListarConFor = new System.Windows.Forms.Button();
            this.gboCargaDatos.SuspendLayout();
            this.gboListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // gboCargaDatos
            // 
            this.gboCargaDatos.Controls.Add(this.cmbMes);
            this.gboCargaDatos.Controls.Add(this.lblImporte);
            this.gboCargaDatos.Controls.Add(this.lblMes);
            this.gboCargaDatos.Controls.Add(this.btnCargar);
            this.gboCargaDatos.Controls.Add(this.txtImporte);
            this.gboCargaDatos.Location = new System.Drawing.Point(30, 44);
            this.gboCargaDatos.Name = "gboCargaDatos";
            this.gboCargaDatos.Size = new System.Drawing.Size(384, 209);
            this.gboCargaDatos.TabIndex = 0;
            this.gboCargaDatos.TabStop = false;
            this.gboCargaDatos.Text = "Carga de Datos";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(180, 53);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 5;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(48, 91);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(45, 13);
            this.lblImporte.TabIndex = 4;
            this.lblImporte.Text = "Importe:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(53, 56);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 3;
            this.lblMes.Text = "Mes:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(201, 147);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 31);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(180, 91);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 20);
            this.txtImporte.TabIndex = 1;
            // 
            // gboListado
            // 
            this.gboListado.Controls.Add(this.dgvListado);
            this.gboListado.Controls.Add(this.btnListarconWhile);
            this.gboListado.Controls.Add(this.btnListarConFor);
            this.gboListado.Location = new System.Drawing.Point(45, 281);
            this.gboListado.Name = "gboListado";
            this.gboListado.Size = new System.Drawing.Size(369, 187);
            this.gboListado.TabIndex = 1;
            this.gboListado.TabStop = false;
            this.gboListado.Text = "Listado de datos";
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvListado.Location = new System.Drawing.Point(6, 19);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(357, 118);
            this.dgvListado.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Mes";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Importe";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // btnListarconWhile
            // 
            this.btnListarconWhile.Location = new System.Drawing.Point(220, 156);
            this.btnListarconWhile.Name = "btnListarconWhile";
            this.btnListarconWhile.Size = new System.Drawing.Size(100, 25);
            this.btnListarconWhile.TabIndex = 2;
            this.btnListarconWhile.Text = "Listar con While";
            this.btnListarconWhile.UseVisualStyleBackColor = true;
            this.btnListarconWhile.Click += new System.EventHandler(this.btnListarconWhile_Click);
            // 
            // btnListarConFor
            // 
            this.btnListarConFor.Location = new System.Drawing.Point(36, 158);
            this.btnListarConFor.Name = "btnListarConFor";
            this.btnListarConFor.Size = new System.Drawing.Size(89, 23);
            this.btnListarConFor.TabIndex = 1;
            this.btnListarConFor.Text = "Listar con For";
            this.btnListarConFor.UseVisualStyleBackColor = true;
            this.btnListarConFor.Click += new System.EventHandler(this.btnListarConFor_Click);
            // 
            // FrmVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 512);
            this.Controls.Add(this.gboListado);
            this.Controls.Add(this.gboCargaDatos);
            this.Name = "FrmVectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vector tipo caracter";
            this.Load += new System.EventHandler(this.FrmVectores_Load);
            this.gboCargaDatos.ResumeLayout(false);
            this.gboCargaDatos.PerformLayout();
            this.gboListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboCargaDatos;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gboListado;
        private System.Windows.Forms.Button btnListarconWhile;
        private System.Windows.Forms.Button btnListarConFor;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

