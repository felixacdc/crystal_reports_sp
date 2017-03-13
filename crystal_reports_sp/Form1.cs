using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crystal_reports_sp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_estatico_Click(object sender, EventArgs e)
        {
            this.Hide();
            reporte_estatico frm = new reporte_estatico();
            frm.Show();
        }
    }
}
