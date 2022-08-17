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
    public partial class InsertDog : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public InsertDog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "insert into dog(DID,type,sex,SNO,ASSN,HNO) values('"
                    + this.didbox.Text + "','"
                    + this.typebox.Text + "','"
                    + this.sexbox.Text + "','"
                    + this.sidbox.Text + "','"
                    + this.assnbox.Text + "','"
                    + this.hidbox.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功新增");
                //read_table(con, cmd);
                InsertDog_Load(null, null);
                didbox.Text = String.Empty;
                typebox.Text = String.Empty;
                sexbox.Text = String.Empty;
                sidbox.Text = String.Empty;
                assnbox.Text = String.Empty;
                hidbox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤新增");
            }
        }

        private void InsertDog_Load(object sender, EventArgs e)
        {
            insertdogview.Rows.Clear();
            insertdogview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from dog";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                insertdogview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                insertdogview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetString(5));
            }
            con.Close();
        }
    }
}
