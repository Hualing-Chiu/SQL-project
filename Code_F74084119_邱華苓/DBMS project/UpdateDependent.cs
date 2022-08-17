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
    public partial class UpdateDependent : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public UpdateDependent()
        {
            InitializeComponent();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "update dependent set SSN='" + this.ssnbox.Text
                + "',name='" + this.namebox.Text
                + "',age='" + this.agebox.Text
                + "',sex='" + this.sexbox.Text
                + "',ASSN='" + this.assnbox.Text
                + "' where SSN='" + this.ssnbox.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功更新");
                //read_table(con, cmd);
                UpdateDependent_Load(null, null);
                ssnbox.Text = String.Empty;
                namebox.Text = String.Empty;
                agebox.Text = String.Empty;
                sexbox.Text = String.Empty;
                assnbox.Text = String.Empty;             
            }
            catch
            {
                MessageBox.Show("錯誤更新");
            }
        }

        private void UpdateDependent_Load(object sender, EventArgs e)
        {
            updatedependentview.Rows.Clear();
            updatedependentview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from dependent";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                updatedependentview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                updatedependentview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4));
            }
            con.Close();
        }

        private void updatedependentview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (updatedependentview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.updatedependentview.Rows[e.RowIndex];
                ssnbox.Text = row.Cells[0].Value.ToString();
                namebox.Text = row.Cells[1].Value.ToString();
                agebox.Text = row.Cells[2].Value.ToString();
                sexbox.Text = row.Cells[3].Value.ToString();
                assnbox.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
