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
    public partial class reporte_parametrisado : Form
    {
        public reporte_parametrisado()
        {
            InitializeComponent();
        }

        private void reporte_parametrisado_Load(object sender, EventArgs e)
        {
            String edad = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la edad", "Ingreso de datos", "18");
            String sexo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el sexo", "Ingreso de datos", "masculino");

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=1CAE-GUA-PC152\\SQLEXPRESS;Initial Catalog=Reports; Integrated Security = True";
            conexion.Open();

            SqlCommand cmd = new SqlCommand("spPersonas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@prmEdad", edad);
            cmd.Parameters.AddWithValue("@prmSexo", sexo);

            rpdinamico Reporte = new rpdinamico();
            dsPersonas dsReporteDinamico = new dsPersonas();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dsReporteDinamico, "Personas");
            Reporte.SetDataSource(dsReporteDinamico);

            crDinamico.ReportSource = Reporte;
        }
    }
}
