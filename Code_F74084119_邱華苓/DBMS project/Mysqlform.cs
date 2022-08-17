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
    public partial class Mysqlform : Form
    {
        public static Mysqlform instance;
        string sqltext = string.Empty;
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption";
        public Mysqlform()
        {
            InitializeComponent();
            instance = this;
        }

        private void querybutton_Click(object sender, EventArgs e)
        {
            // 初始化DataGridView
            Form1.instance.dgv.Rows.Clear();
            Form1.instance.dgv.Columns.Clear();

            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = querytextbox.Text;

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                int readerCount = reader.FieldCount; 
                for (int i = 0; i < readerCount; i++)
                {
                    Form1.instance.dgv.Columns.Add(reader.GetName(i), reader.GetName(i));
                }

                while (reader.Read()) // 根據不同attribute讀取對應資料
                {
                    if (readerCount == 1) 
                        Form1.instance.dgv.Rows.Add(reader.GetString(0));

                    if (readerCount == 2)
                        Form1.instance.dgv.Rows.Add(reader.GetString(0), reader.GetString(1));

                    if (readerCount == 3)
                        Form1.instance.dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));

                    if (readerCount == 4)
                        Form1.instance.dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));

                    if (readerCount == 5)
                        Form1.instance.dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetString(4));
                }
            }
            catch
            {
                MessageBox.Show("錯誤查詢");
            }
            con.Close();
            this.Close(); 
        }
        public string TextBoxMsg
        {  
            set
            {
                sqltext = querytextbox.Text;
            }
            get
            {
                return sqltext;
            }
        }
    }
}
