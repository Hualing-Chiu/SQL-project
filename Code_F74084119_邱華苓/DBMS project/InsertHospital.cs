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
    public partial class InsertHospital : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public InsertHospital()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "insert into hospital(HNO,location,name) values('"
                    + this.hidbox.Text + "','"
                    + this.locationbox.Text + "','"
                    + this.namebox.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功新增");
                //read_table(con, cmd);
                InsertHospital_Load(null, null);
                hidbox.Text = String.Empty;
                locationbox.Text = String.Empty;
                namebox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤新增");
            }
        }

        private void InsertHospital_Load(object sender, EventArgs e)
        {
            inserthospitalview.Rows.Clear();
            inserthospitalview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from hospital";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                inserthospitalview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                inserthospitalview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            con.Close();
        }
    }
}
