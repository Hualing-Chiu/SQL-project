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
    public partial class UpdateDog : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public UpdateDog()
        {
            InitializeComponent();
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "update dog set DID='" + this.didbox.Text
                + "',type='" + this.typebox.Text
                + "',sex='" + this.sexbox.Text
                + "',SNO='" + this.sidbox.Text
                + "',ASSN='" + this.assnbox.Text
                + "',HNO='" + this.hidbox.Text
                + "' where DID='" + this.didbox.Text + "';";

            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功更新");
                //read_table(con, cmd);
                UpdateDog_Load(null, null);
                didbox.Text = String.Empty;
                typebox.Text = String.Empty;
                sexbox.Text = String.Empty;
                sidbox.Text = String.Empty;
                assnbox.Text = String.Empty;
                hidbox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤更新");
            }
        }

        private void UpdateDog_Load(object sender, EventArgs e)
        {
            updatedogview.Rows.Clear();
            updatedogview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from dog";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                updatedogview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                updatedogview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetString(5));
            }
            con.Close();
        }

        private void updatedogview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (updatedogview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.updatedogview.Rows[e.RowIndex];
                didbox.Text = row.Cells[0].Value.ToString();
                typebox.Text = row.Cells[1].Value.ToString();
                sexbox.Text = row.Cells[2].Value.ToString();
                sidbox.Text = row.Cells[3].Value.ToString();
                assnbox.Text = row.Cells[4].Value.ToString();
                hidbox.Text = row.Cells[5].Value.ToString();
            }
        }
    }
}
