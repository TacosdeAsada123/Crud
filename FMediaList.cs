using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Gaming
{
    public partial class FMediaList : Form
    {
        public FMediaList()
        {
            InitializeComponent();
        }

        private void FMediaList_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'mediaDataSet.Medios' Puede moverla o quitarla según sea necesario.
            this.mediosTableAdapter.Fill(this.mediaDataSet.Medios);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string cadena = "Data Source=TR4ZO\\TRAZO; Initial Catalog=media; Integrated Security=True";
        SqlConnection conn = new SqlConnection(cadena);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Crud()
        {
            String query = "SELECT * FROM Medios";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);   
            SqlDataReader rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rdr);
            conn.Close();
            dtgMedia.DataSource = dt;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "Insert into medios(Nombre,Autor,Duracion) VALUES (@Nombre,@Autor,@Duracion)";
            conn.Open();
            SqlCommand comando = new SqlCommand(query, conn);
            comando.Parameters.AddWithValue("@Nombre",)
            comando.Parameters.AddWithValue("@Autor",)
            comando.Parameters.AddWithValue("@Duracion",)
            comando.EndExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Datos agregados Correctamente");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dato = dtgMedia.CurrentRowCells[0].Value.ToString();
            int id = Convert.ToInt32(dato);
            String query = "D"
        }
    }
}
