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
    public partial class UpdateAdopter : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public UpdateAdopter()
        {
            InitializeComponent();
        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "update adopter set SSN='" + this.ssnbox.Text 
                + "',name='" + this.namebox.Text
                + "',sex='" + this.sexbox.Text 
                + "',age='" + this.agebox.Text 
                + "' where SSN='" + this.ssnbox.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功更新");
                //read_table(con, cmd);
                UpdateAdopter_Load(null, null);
                ssnbox.Text = String.Empty;
                namebox.Text = String.Empty;
                sexbox.Text = String.Empty;
                agebox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤更新");
            }
        }

        private void UpdateAdopter_Load(object sender, EventArgs e)
        {
            updateadopterview.Rows.Clear();
            updateadopterview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from adopter";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                updateadopterview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                updateadopterview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
            }
            con.Close();
        }

        private void updateadopterview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (updateadopterview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.updateadopterview.Rows[e.RowIndex];
                ssnbox.Text = row.Cells[0].Value.ToString();
                namebox.Text = row.Cells[1].Value.ToString();
                sexbox.Text = row.Cells[2].Value.ToString();
                agebox.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
