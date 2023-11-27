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
        string id = "0";

        public Form1()
        {
            InitializeComponent();
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
            string conString = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            string action = "select nazwa, obejrz_odc, wszyst_odc, ocena from list";
            MySqlCommand cmd = new MySqlCommand(action, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }


    }
}
