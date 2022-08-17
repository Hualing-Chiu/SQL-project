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
    public partial class UpdateShelter : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public UpdateShelter()
        {
            InitializeComponent();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "update shelter set SNO='" + this.sidbox.Text
                + "',location='" + this.locationbox.Text
                + "',volunteer_num='" + this.vnumbox.Text
                + "' where SNO='" + this.sidbox.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功更新");
                //read_table(con, cmd);
                UpdateShelter_Load(null, null);
                sidbox.Text = String.Empty;
                locationbox.Text = String.Empty;
                vnumbox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤更新");
            }
        }

        private void UpdateShelter_Load(object sender, EventArgs e)
        {
            updateshelterview.Rows.Clear();
            updateshelterview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from shelter";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                updateshelterview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                updateshelterview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            con.Close();
        }

        private void updateshelterview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (updateshelterview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.updateshelterview.Rows[e.RowIndex];
                sidbox.Text = row.Cells[0].Value.ToString();
                locationbox.Text = row.Cells[1].Value.ToString();
                vnumbox.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
