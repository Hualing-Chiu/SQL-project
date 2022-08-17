using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBMS_project
{
    public partial class DeleteHospital : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public DeleteHospital()
        {
            InitializeComponent();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "delete from hospital where HNO='" + this.hidbox.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功刪除");
                //read_table(con, cmd);
                DeleteHospital_Load(null, null);
                hidbox.Text = String.Empty;
                locationbox.Text = String.Empty;
                namebox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤刪除");
            }
        }

        private void DeleteHospital_Load(object sender, EventArgs e)
        {
            deletehospitalview.Rows.Clear();
            deletehospitalview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from hospital";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                deletehospitalview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                deletehospitalview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            con.Close();
        }

        private void deletehospitalview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (deletehospitalview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.deletehospitalview.Rows[e.RowIndex];
                hidbox.Text = row.Cells[0].Value.ToString();
                locationbox.Text = row.Cells[1].Value.ToString();
                namebox.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
