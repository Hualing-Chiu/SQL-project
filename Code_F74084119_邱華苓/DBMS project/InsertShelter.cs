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
    public partial class InsertShelter : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public InsertShelter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "insert into shelter(SNO,location,volunteer_num) values('"
                    + this.sidbox.Text + "','"
                    + this.locationbox.Text + "','"
                    + this.vnumbox.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功新增");
                //read_table(con, cmd);
                InsertShelter_Load(null, null);
                sidbox.Text = String.Empty;
                label2.Text = String.Empty;
                label3.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤新增");
            }
        }

        private void InsertShelter_Load(object sender, EventArgs e)
        {
            insertshelterview.Rows.Clear();
            insertshelterview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from shelter";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                insertshelterview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                insertshelterview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            con.Close();
        }
    }
}
