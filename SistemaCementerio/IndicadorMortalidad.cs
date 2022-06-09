using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace SistemaCementerio
{
    public partial class IndicadorMortalidad : Form
    {
        string Causava;
        string PeriodoVa;
        string GeneroVa;
        int NumeroCount;
        public IndicadorMortalidad()
        {
            InitializeComponent();
        }

        private void cargarComboPeriodo()
        {
           
            var conString = ConfigurationManager.ConnectionStrings["BaseSqlServer"].ConnectionString;
            using (SqlConnection Conector = new SqlConnection(conString))
            {
                Conector.Open();
                string query = @"Select DISTINCT anio from DimTime";
                SqlCommand cmd = new SqlCommand(query, Conector);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    cmb_periodo.Items.Add(da[0].ToString());
                }
                Conector.Close();
                


            }
        }
        private void cargarComboCausa()
        {
            var conString = ConfigurationManager.ConnectionStrings["BaseSqlServer"].ConnectionString;
            using (SqlConnection Conector = new SqlConnection(conString))
            {
                Conector.Open();
                string query = @"Select DISTINCT  CausaFallecimiento from V_Fallecimiento";
                SqlCommand cmd = new SqlCommand(query, Conector);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    cmb_CausaMuerte.Items.Add(da[0].ToString());

                }
                Conector.Close();

      



            }
        }

        private void CargarcomboGenero()
        {
            var conString = ConfigurationManager.ConnectionStrings["BaseSqlServer"].ConnectionString;
            using (SqlConnection Conector = new SqlConnection(conString))
            {
                Conector.Open();
                string query = @"Select DISTINCT sexo  from V_Fallecimiento";
                SqlCommand cmd = new SqlCommand(query, Conector);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    Cmb_Genero.Items.Add(da[0].ToString());
                }
                Conector.Close();

             

            }
        }
        private void Conexion()
        {
            PeriodoVa = cmb_periodo.Text;
            GeneroVa = Cmb_Genero.Text;
            Causava = cmb_CausaMuerte.Text;
            var conString = ConfigurationManager.ConnectionStrings["BaseSqlServer"].ConnectionString;
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                using (SqlConnection Conector = new SqlConnection(conString))
                {
               
                    if   ((bool) chk_todo.Checked)
                        {
                        Conector.Open();
                        DataTable dt = new DataTable();
                        string query = @"Select * from V_Fallecimiento";
                        SqlCommand cmd = new SqlCommand(query, Conector);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        NumeroCount = dt.Rows.Count;
                        lbl_num.Text = Convert.ToString(NumeroCount);
                    }
                    else
                    {

                        Conector.Open();
                        DataTable dt = new DataTable();
                        string query = @"Select * from V_Fallecimiento where anio ='" + PeriodoVa + "' and sexo='" + GeneroVa + "' and causafallecimiento='" + Causava + "' ";
                        SqlCommand cmd = new SqlCommand(query, Conector);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                        NumeroCount = dt.Rows.Count;
                        lbl_num.Text = Convert.ToString(NumeroCount);
                    }


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        ArrayList Mes = new ArrayList();     
        ArrayList Anio = new ArrayList();

    

    private void CargarGrafico()
        {
            var conString = ConfigurationManager.ConnectionStrings["BaseSqlServer"].ConnectionString;
            try
            {
                using (SqlConnection Conector = new SqlConnection(conString))
                {
                    if ((bool)chk_todo.Checked)
                    {
                        Conector.Open();
                        DataTable dt = new DataTable();
                        string query = @"Select  mes,sum(edad )from V_Fallecimiento group by mes ";
                        SqlCommand cmd = new SqlCommand(query, Conector);
                        SqlDataReader da = cmd.ExecuteReader();
                        while (da.Read())
                        {
                            Mes.Add(da.GetString(0));
                            Anio.Add(da.GetInt32(1));
                        }
                        Char_Periodo.Series[0].Points.DataBindXY(Mes, Anio);
                        da.Close();
                        Conector.Close();
                    }
                    else
                    {
                        Conector.Open();
                        DataTable dt = new DataTable();
                        string query = @"Select DISTINCT mes,edad from V_Fallecimiento where anio ='" + PeriodoVa + "' and sexo='" + GeneroVa + "' and causafallecimiento='" + Causava + "' ";
                        SqlCommand cmd = new SqlCommand(query, Conector);
                        SqlDataReader da = cmd.ExecuteReader();
                        while (da.Read())
                        {
                            Mes.Add(da.GetString(0));
                            Anio.Add(da.GetInt32(1));
                        }
                        Char_Periodo.Series[0].Points.DataBindXY(Mes, Anio);
                        da.Close();
                        Conector.Close();
                    }


                   


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    
      
        private void ExportarDatosExcel(DataGridView DataListado)
        {
            try
            {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            fichero.FileName = "ArchivoExportado";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application application;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet Hoja_Trabajo;

                application = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = application.Workbooks.Add();
                Hoja_Trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                for (int i = 0; i < DataListado.Rows.Count - 1; i++)
                    {
                    for (int j=0; j < DataListado.Columns.Count; j++)
                    {
                        if ((DataListado.Rows[i].Cells[j].Value == null)== false)
                        {
                            Hoja_Trabajo.Cells[i + 1, j + 1] = DataListado.Rows[i].Cells[j].Value.ToString();
                        }
                    }
            }
                    libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    application.Quit();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar" + ex.ToString());

            }

        }
        private void IndicadorMortalidad_Load(object sender, EventArgs e)
        {
        
            cargarComboPeriodo();
            cargarComboCausa();
            CargarcomboGenero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(dataGridView1);
        }

      

        private void btn_lupa_Click(object sender, EventArgs e)
        {
            Conexion();
            CargarGrafico();
        }




    }
}
