namespace crystal_reports_sp
{
    partial class reporte_estatico
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
            this.crEstandar = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rpestatico1 = new crystal_reports_sp.rpestatico();
            this.SuspendLayout();
            // 
            // crEstandar
            // 
            this.crEstandar.ActiveViewIndex = 0;
            this.crEstandar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crEstandar.Cursor = System.Windows.Forms.Cursors.Default;
            this.crEstandar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crEstandar.Location = new System.Drawing.Point(0, 0);
            this.crEstandar.Name = "crEstandar";
            this.crEstandar.ReportSource = this.rpestatico1;
            this.crEstandar.Size = new System.Drawing.Size(1092, 451);
            this.crEstandar.TabIndex = 0;
            // 
            // reporte_estatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 451);
            this.Controls.Add(this.crEstandar);
            this.Name = "reporte_estatico";
            this.Text = "reporte_estatico";
            this.Load += new System.EventHandler(this.reporte_estatico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crEstandar;
        private rpestatico rpestatico1;
    }
}