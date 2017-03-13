namespace crystal_reports_sp
{
    partial class reporte_parametrisado
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
            this.crDinamico = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crDinamico
            // 
            this.crDinamico.ActiveViewIndex = -1;
            this.crDinamico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crDinamico.Cursor = System.Windows.Forms.Cursors.Default;
            this.crDinamico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crDinamico.Location = new System.Drawing.Point(0, 0);
            this.crDinamico.Name = "crDinamico";
            this.crDinamico.Size = new System.Drawing.Size(828, 414);
            this.crDinamico.TabIndex = 0;
            // 
            // reporte_parametrisado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 414);
            this.Controls.Add(this.crDinamico);
            this.Name = "reporte_parametrisado";
            this.Text = "reporte_parametrisado";
            this.Load += new System.EventHandler(this.reporte_parametrisado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crDinamico;
    }
}