using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAniList
{
    public partial class Form1 : Form
    {
        string server = "localhost";
        string uid = "root";
        string password = "";
        string database = "anime_list";

        public Form1()
        {
            InitializeComponent();
        }

        void DbConnect(string command)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        #region
        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string action = "insert into list(nazwa, obejrz_odc, wszyst_odc, ocena) values('"+textBox3.Text+"','"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox1.Text+"')";
            MySqlCommand cmd = new MySqlCommand(action, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sukces!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
        }
        #endregion
    }
}
