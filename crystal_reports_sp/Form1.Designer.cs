﻿namespace crystal_reports_sp
{
    partial class Form1
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
            this.btn_estatico = new System.Windows.Forms.Button();
            this.btn_parametrisado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_estatico
            // 
            this.btn_estatico.Location = new System.Drawing.Point(12, 12);
            this.btn_estatico.Name = "btn_estatico";
            this.btn_estatico.Size = new System.Drawing.Size(109, 23);
            this.btn_estatico.TabIndex = 0;
            this.btn_estatico.Text = "Reporte Estatico";
            this.btn_estatico.UseVisualStyleBackColor = true;
            this.btn_estatico.Click += new System.EventHandler(this.btn_estatico_Click);
            // 
            // btn_parametrisado
            // 
            this.btn_parametrisado.Location = new System.Drawing.Point(143, 12);
            this.btn_parametrisado.Name = "btn_parametrisado";
            this.btn_parametrisado.Size = new System.Drawing.Size(129, 23);
            this.btn_parametrisado.TabIndex = 1;
            this.btn_parametrisado.Text = "Reporte Parametrisado";
            this.btn_parametrisado.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 50);
            this.Controls.Add(this.btn_parametrisado);
            this.Controls.Add(this.btn_estatico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_estatico;
        private System.Windows.Forms.Button btn_parametrisado;
    }
}

