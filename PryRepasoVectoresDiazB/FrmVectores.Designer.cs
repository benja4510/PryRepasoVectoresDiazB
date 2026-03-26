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
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtNyA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboListado = new System.Windows.Forms.GroupBox();
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.btnListarConFor = new System.Windows.Forms.Button();
            this.btnListarconWhile = new System.Windows.Forms.Button();
            this.gboCargaDatos.SuspendLayout();
            this.gboListado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboCargaDatos
            // 
            this.gboCargaDatos.Controls.Add(this.btnCargar);
            this.gboCargaDatos.Controls.Add(this.txtNyA);
            this.gboCargaDatos.Controls.Add(this.label1);
            this.gboCargaDatos.Location = new System.Drawing.Point(30, 44);
            this.gboCargaDatos.Name = "gboCargaDatos";
            this.gboCargaDatos.Size = new System.Drawing.Size(384, 209);
            this.gboCargaDatos.TabIndex = 0;
            this.gboCargaDatos.TabStop = false;
            this.gboCargaDatos.Text = "Carga de Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(180, 123);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 31);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // txtNyA
            // 
            this.txtNyA.Location = new System.Drawing.Point(180, 56);
            this.txtNyA.Name = "txtNyA";
            this.txtNyA.Size = new System.Drawing.Size(100, 20);
            this.txtNyA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido";
            // 
            // gboListado
            // 
            this.gboListado.Controls.Add(this.btnListarconWhile);
            this.gboListado.Controls.Add(this.btnListarConFor);
            this.gboListado.Controls.Add(this.lstPersonas);
            this.gboListado.Location = new System.Drawing.Point(45, 281);
            this.gboListado.Name = "gboListado";
            this.gboListado.Size = new System.Drawing.Size(369, 187);
            this.gboListado.TabIndex = 1;
            this.gboListado.TabStop = false;
            this.gboListado.Text = "Listado de datos";
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(6, 30);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(195, 95);
            this.lstPersonas.TabIndex = 0;
            // 
            // btnListarConFor
            // 
            this.btnListarConFor.Location = new System.Drawing.Point(30, 140);
            this.btnListarConFor.Name = "btnListarConFor";
            this.btnListarConFor.Size = new System.Drawing.Size(89, 23);
            this.btnListarConFor.TabIndex = 1;
            this.btnListarConFor.Text = "Listar con For";
            this.btnListarConFor.UseVisualStyleBackColor = true;
            this.btnListarConFor.Click += new System.EventHandler(this.btnListarConFor_Click);
            // 
            // btnListarconWhile
            // 
            this.btnListarconWhile.Location = new System.Drawing.Point(165, 140);
            this.btnListarconWhile.Name = "btnListarconWhile";
            this.btnListarconWhile.Size = new System.Drawing.Size(100, 25);
            this.btnListarconWhile.TabIndex = 2;
            this.btnListarconWhile.Text = "Listar con While";
            this.btnListarconWhile.UseVisualStyleBackColor = true;
            this.btnListarconWhile.Click += new System.EventHandler(this.btnListarconWhile_Click);
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
            this.Text = "Vectores";
            this.Load += new System.EventHandler(this.FrmVectores_Load);
            this.gboCargaDatos.ResumeLayout(false);
            this.gboCargaDatos.PerformLayout();
            this.gboListado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboCargaDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNyA;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gboListado;
        private System.Windows.Forms.Button btnListarconWhile;
        private System.Windows.Forms.Button btnListarConFor;
        private System.Windows.Forms.ListBox lstPersonas;
    }
}

