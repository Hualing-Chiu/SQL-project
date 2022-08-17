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
    public partial class UpdateHospital : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public UpdateHospital()
        {
            InitializeComponent();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "update hospital set HNO='" + this.hidbox.Text
                + "',location='" + this.locationbox.Text
                + "',name='" + this.namebox.Text
                + "' where HNO='" + this.hidbox.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功更新");
                //read_table(con, cmd);
                UpdateHospital_Load(null, null);
                hidbox.Text = String.Empty;
                locationbox.Text = String.Empty;
                namebox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤更新");
            }
        }

        private void UpdateHospital_Load(object sender, EventArgs e)
        {
            updatehospitalview.Rows.Clear();
            updatehospitalview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from hospital";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                updatehospitalview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                updatehospitalview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            con.Close();
        }

        private void updatehospitalview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (updatehospitalview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.updatehospitalview.Rows[e.RowIndex];
                hidbox.Text = row.Cells[0].Value.ToString();
                locationbox.Text = row.Cells[1].Value.ToString();
                namebox.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
