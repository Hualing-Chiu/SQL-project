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
    public partial class InsertDependent : Form
    {
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public InsertDependent()
        {
            InitializeComponent();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string query = "insert into dependent(SSN,name,sex,age,ASSN) values('"
                    + this.ssnbox.Text + "','"
                    + this.namebox.Text + "','"
                    + this.sexbox.Text + "','"
                    + this.agebox.Text + "','"
                    + this.assnbox.Text + "')";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                cmd.ExecuteReader();
                MessageBox.Show("成功新增");
                //read_table(con, cmd);
                InsertDependent_Load(null, null);
                ssnbox.Text = String.Empty;
                namebox.Text = String.Empty;
                sexbox.Text = String.Empty;
                agebox.Text = String.Empty;
                assnbox.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("錯誤新增");
            }
        }

        private void InsertDependent_Load(object sender, EventArgs e)
        {
            insertdependentview.Rows.Clear();
            insertdependentview.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            string sql = "select * from dependent";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataReader reader = cmd.ExecuteReader();

            int readerCount = reader.FieldCount;
            for (int i = 0; i < readerCount; i++)
            {
                insertdependentview.Columns.Add(reader.GetName(i), reader.GetName(i));
            }

            while (reader.Read())
            {
                insertdependentview.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetString(4));
            }
            con.Close();
        }
    }
}
