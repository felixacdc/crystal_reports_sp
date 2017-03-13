using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace crystal_reports_sp
{
    public partial class reporte_estatico : Form
    {
        public reporte_estatico()
        {
            InitializeComponent();
        }

        private void reporte_estatico_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=1CAE-GUA-PC152\\SQLEXPRESS;Initial Catalog=DBClinica_test; Integrated Security = True";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("spGetEmpleados", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            rpestatico Reporte = new rpestatico();
            dsestandar dsReporteEstandar = new dsestandar();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dsReporteEstandar, "Empleados");
            Reporte.SetDataSource(dsReporteEstandar);

            crEstandar.ReportSource = Reporte;
        }
    }
}
