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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public DataGridView dgv;
        // 要連接的資料庫server
        string connectString = "server=localhost;user id=root;password=sheena0524;database=stray_dog_adoption"; 
        public Form1()
        {
            InitializeComponent();
            querytoolbox.SelectedIndex = 0; // 預設combobox
            tablecombobox.SelectedIndex = 0;
            instance = this;
            dgv = resultbox;
        }

        //query
        private void mysqlbutton_Click(object sender, EventArgs e)
        {
            Mysqlform mysql = new Mysqlform(); // 開啟新視窗輸入SQL
            mysql.Show(this);
        }

        private void querybutton2_Click(object sender, EventArgs e)
        {
            resultbox.Rows.Clear(); // 初始化DataGridView
            resultbox.Columns.Clear();

            int check_select = 0, check_from = 0;
            string select1 = string.Empty;
            string select2 = string.Empty;
            string select3 = string.Empty;
            string from1 = string.Empty;
            string from2 = string.Empty;
            string query = string.Empty;
            for (int i = 0; i < selectbox.Items.Count; i++)
            {
                if (selectbox.GetItemChecked(i)) // 找出被勾選的attribute
                {
                    if (check_select == 0)
                    {
                        select1 = selectbox.GetItemText(selectbox.Items[i]);
                    } else if (check_select == 1)
                    {
                        select2 = selectbox.GetItemText(selectbox.Items[i]);
                    }else if (check_select == 2)
                    {
                        select3 = selectbox.GetItemText(selectbox.Items[i]);
                    }
                    check_select++;
                }
            }
            for (int i = 0; i < frombox.Items.Count; i++)
            {
                if (frombox.GetItemChecked(i)) // 找出被勾選的table
                {
                    if (check_from == 0)
                    {
                        from1 = frombox.GetItemText(frombox.Items[i]);
                    }
                    else if (check_from == 1)
                    {
                        from2 = frombox.GetItemText(frombox.Items[i]);
                    }
                    check_from++;
                }
            }
            if (check_select == 0 && check_from >= 1)
            {
                MessageBox.Show("請選擇SELECT");
            } else if (check_select >= 1 && check_from == 0)
            {
                MessageBox.Show("請選擇FROM");
            } else if (check_select == 0 && check_from == 0)
            {
                MessageBox.Show("請選擇SELECT跟FROM");
            }else if (check_select > 3 && check_from > 2)
            {
                MessageBox.Show("too many !");
            }
            //連接資料庫
            MySqlConnection con = new MySqlConnection(connectString);
            con.Open();

            // select和from各一項
            if (check_select == 1 && check_from == 1)
            {
                switch (querytoolbox.SelectedIndex)
                {
                    case 0: // select-from-where
                        if (wheretextbox.Text == "")
                            query = "SELECT " + select1 + " FROM " + from1;
                        else
                            query = "SELECT " + select1 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 1: //in
                        query = "SELECT " + select1 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 2: //not in
                        query = "SELECT " + select1 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 3: //exist
                        query = "SELECT " + select1 + " FROM " + from1 + " WHERE EXISTS(" + wheretextbox.Text + ")";
                        break;
                    case 4:
                        query = "SELECT " + select1 + " FROM " + from1 + " WHERE NOT EXISTS(" + wheretextbox.Text + ")";
                        break;
                    default:
                        MessageBox.Show("請選擇function");
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(query, con); // 建立MySqlCommand物件
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader(); // 讀取多行

                    int readerCount = reader.FieldCount; // 取得資料行數目
                    for (int i = 0; i < readerCount; i++)
                    {
                        resultbox.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        resultbox.Rows.Add(reader.GetString(0));
                    }
                }
                catch
                {
                    MessageBox.Show("錯誤查詢");
                }
                con.Close();

            }
            else if (check_select == 1 && check_from == 2) // select一項from兩項
            {
                switch (querytoolbox.SelectedIndex)
                {
                    case 0: // select-from-where
                        if (wheretextbox.Text == "") // if WHERE沒有東西
                            query = "SELECT " + select1 + " FROM " + from1 + ", " + from2;
                        else
                            query = "SELECT " + select1 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 1: //in
                        query = "SELECT " + select1 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 2: //not in
                        query = "SELECT " + select1 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 3: //exist
                        query = "SELECT " + select1 + " FROM " + from1 + ", " + from2 + " WHERE EXISTS(" + wheretextbox.Text + ")";
                        break;
                    case 4:
                        query = "SELECT " + select1 + " FROM " + from1 + ", " + from2 + " WHERE NOT EXISTS(" + wheretextbox.Text + ")";
                        break;
                    default:
                        MessageBox.Show("請選擇function");
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(query, con);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int readerCount = reader.FieldCount; // 取得資料行數目
                    for (int i = 0; i < readerCount; i++)
                    {
                        resultbox.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        resultbox.Rows.Add(reader.GetString(0));
                    }
                }
                catch
                {
                    MessageBox.Show("錯誤查詢");
                }
                con.Close();
            }
            else if (check_select == 2 && check_from == 1) // select兩項from一項
            {
                switch (querytoolbox.SelectedIndex)
                {
                    case 0: // select-from-where
                        if (wheretextbox.Text == "")
                            query = "SELECT " + select1 + ", " + select2 + " FROM " + from1;
                        else
                            query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 1: //in
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 2: //not in
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 3: //exist
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + " WHERE EXISTS (" + wheretextbox.Text + ")";
                        break;
                    case 4:
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + " WHERE NOT EXISTS (" + wheretextbox.Text + ")";
                        break;
                    default:
                        MessageBox.Show("請選擇function");
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(query, con);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int readerCount = reader.FieldCount; // 取得資料行數目
                    for (int i = 0; i < readerCount; i++)
                    {
                        resultbox.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        resultbox.Rows.Add(reader.GetString(0), reader.GetString(1));
                    }
                }
                catch
                {
                    MessageBox.Show("錯誤查詢");
                }
                con.Close();
            }
            else if (check_select == 2 && check_from == 2) // select from各兩個
            {
                switch (querytoolbox.SelectedIndex)
                {
                    case 0: // select-from-where
                        if (wheretextbox.Text == "")
                            query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + ", " + from2;
                        else
                            query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 1: //in
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 2: //not in
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 3: //exist
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + ", " + from2 + " WHERE EXISTS (" + wheretextbox.Text + ")";
                        break;
                    case 4:
                        query = "SELECT " + select1 + ", " + select2 + " FROM " + from1 + ", " + from2 + " WHERE NOT EXISTS (" + wheretextbox.Text + ")";
                        break;
                    default:
                        MessageBox.Show("請選擇function");
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(query, con);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int readerCount = reader.FieldCount; // 取得資料行數目
                    for (int i = 0; i < readerCount; i++)
                    {
                        resultbox.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        resultbox.Rows.Add(reader.GetString(0), reader.GetString(1));
                    }
                }
                catch
                {
                    MessageBox.Show("錯誤查詢");
                }
                con.Close();
            }
            else if (check_select == 3 && check_from == 1) // select三個from一個
            {
                switch (querytoolbox.SelectedIndex)
                {
                    case 0: // select-from-where
                        if (wheretextbox.Text == "")
                            query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 ;
                        else
                            query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 1: //in
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 2: //not in
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + " WHERE " + wheretextbox.Text;
                        break;
                    case 3: //exist
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + " WHERE EXISTS (" + wheretextbox.Text + ")";
                        break;
                    case 4:
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + " WHERE NOT EXISTS (" + wheretextbox.Text + ")";
                        break;
                    default:
                        MessageBox.Show("請選擇function");
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(query, con);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int readerCount = reader.FieldCount; // 取得資料行數目
                    for (int i = 0; i < readerCount; i++)
                    {
                        resultbox.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        resultbox.Rows.Add(reader.GetString(0), reader.GetString(1),reader.GetString(2));
                    }
                }
                catch
                {
                    MessageBox.Show("錯誤查詢");
                }
                con.Close();
            }
            else if (check_select == 3 && check_from == 2) // select三個from兩個
            {
                switch (querytoolbox.SelectedIndex)
                {
                    case 0: // select-from-where
                        if (wheretextbox.Text == "")
                            query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + ", " + from2;
                        else
                            query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 1: //in
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 2: //not in
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + ", " + from2 + " WHERE " + wheretextbox.Text;
                        break;
                    case 3: //exist
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + ", " + from2 + " WHERE EXISTS (" + wheretextbox.Text + ")";
                        break;
                    case 4:
                        query = "SELECT " + select1 + ", " + select2 + ", " + select3 + " FROM " + from1 + ", " + from2 + " WHERE NOT EXISTS (" + wheretextbox.Text + ")";
                        break;
                    default:
                        MessageBox.Show("請選擇function");
                        break;
                }

                MySqlCommand cmd = new MySqlCommand(query, con);
                try
                {
                    MySqlDataReader reader = cmd.ExecuteReader();

                    int readerCount = reader.FieldCount; // 取得資料行數目
                    for (int i = 0; i < readerCount; i++)
                    {
                        resultbox.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        resultbox.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                    }
                }
                catch
                {
                    MessageBox.Show("錯誤查詢");
                }
                con.Close();
            }
        }
        // insert data
        private void insertbutton_Click(object sender, EventArgs e)
        {
            if (tablecombobox.SelectedIndex == 0) // adopter
            {
                InsertAdopter insert_adopter = new InsertAdopter();
                insert_adopter.Show(this); // show視窗
            }
            else if (tablecombobox.SelectedIndex == 1)//dog
            {
                InsertDog insert_dog = new InsertDog();
                insert_dog.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 2)
            {
                InsertShelter insert_shelter = new InsertShelter();
                insert_shelter.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 3)
            {
                InsertHospital insert_hospital = new InsertHospital();
                insert_hospital.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 4)
            {
                InsertDependent insert_dependent = new InsertDependent();
                insert_dependent.Show(this);
            }
        }

        // delete data
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if(tablecombobox.SelectedIndex == 0)// adopter
            {
                DeleteAdopter delete_adpoter = new DeleteAdopter();
                delete_adpoter.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 1)// dog
            {
                DeleteDog delete_dog = new DeleteDog();
                delete_dog.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 2)
            {
                DeleteShelter delete_shelter = new DeleteShelter();
                delete_shelter.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 3)
            {
                DeleteHospital delete_hospital = new DeleteHospital();
                delete_hospital.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 4)
            {
                DeleteDependent delete_dependent = new DeleteDependent();
                delete_dependent.Show(this);
            }
        }
        //update
        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (tablecombobox.SelectedIndex == 0)// adopter
            {
                UpdateAdopter update_adpoter = new UpdateAdopter();
                update_adpoter.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 1)// dog
            {
                UpdateDog update_dog = new UpdateDog();
                update_dog.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 2)// shelter
            {
                UpdateShelter update_shelter = new UpdateShelter();
                update_shelter.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 3)// hospital
            {
                UpdateShelter update_shelter = new UpdateShelter();
                update_shelter.Show(this);
            }
            else if (tablecombobox.SelectedIndex == 4)// dependent
            {
                UpdateDependent update_dependent = new UpdateDependent();
                update_dependent.Show(this);
            }
        }
    }
}
