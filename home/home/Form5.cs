using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test;


namespace home
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("Server=localhost;database=ankande;user=root;password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable tabela = new DataTable();
        MySqlCommandBuilder cmb;
        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            label3.Hide();
            textBox3.Hide();
            adapter = new MySqlDataAdapter("SELECT * FROM signup", con);
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Admin" && textBox2.Text != "Admin")
            {
                MessageBox.Show("Vetëm admin mund të kyqet!");
            }
            else
            {
                label1.Hide();
                label2.Hide();
                textBox1.Hide();
                textBox2.Hide();
                button1.Hide();
                label3.Show();
                textBox3.Show();
                dataGridView1.Show();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(tabela);
            dv.RowFilter = string.Format("emri LIKE '%" + textBox3.Text + "%'");
            dataGridView1.DataSource = dv;
        }
    }
}
