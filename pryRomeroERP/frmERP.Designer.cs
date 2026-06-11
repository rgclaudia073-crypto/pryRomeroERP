namespace pryRomeroERP
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
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
            this.ssEstadoConexion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBarConexión = new System.Windows.Forms.ProgressBar();
            this.ssEstadoConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssEstadoConexion
            // 
            this.ssEstadoConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ssEstadoConexion.Location = new System.Drawing.Point(0, 454);
            this.ssEstadoConexion.Name = "ssEstadoConexion";
            this.ssEstadoConexion.Size = new System.Drawing.Size(800, 22);
            this.ssEstadoConexion.TabIndex = 0;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel1.Text = "Conectando...";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // progressBarConexión
            // 
            this.progressBarConexión.Location = new System.Drawing.Point(0, 428);
            this.progressBarConexión.Name = "progressBarConexión";
            this.progressBarConexión.Size = new System.Drawing.Size(800, 23);
            this.progressBarConexión.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.progressBarConexión);
            this.Controls.Add(this.ssEstadoConexion);
            this.Name = "frmMain";
            this.Text = "Main ERP";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ssEstadoConexion.ResumeLayout(false);
            this.ssEstadoConexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssEstadoConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ProgressBar progressBarConexion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.ProgressBar progressBarConexión;
    }
}

