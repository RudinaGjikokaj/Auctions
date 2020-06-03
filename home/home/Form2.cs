using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using home;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using Test;
using System.IO;

namespace sign_up
{
    public partial class Form2 : Form
    {
        MySqlConnection connect = new MySqlConnection("Server=localhost;database=ankande;user=root;password=");
        MySqlCommand con;
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        string pattern = @"(?=.*?[A-Z]).{8,}";
        private void firstnametxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstnametxt.Text) == true)
            {
                firstnametxt.Focus();
                errorProvider1.SetError(this.firstnametxt, "Shëno emrin tend!");
            }
            else
                errorProvider1.Clear();
        }
        private void lastnametxt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastnametxt.Text) == true)
            {
                lastnametxt.Focus();
                errorProvider2.SetError(this.lastnametxt, "Shëno mbiemrin tend!");
            }
            else
                errorProvider2.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider7.SetError(this.textBox1, "Jepeni çmimin e produktit.");
            }
            else
                errorProvider7.Clear();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            firstnametxt.Select();
        }
       
        private void signupbtn_Click_1(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

            if (string.IsNullOrEmpty(firstnametxt.Text) == true)
            {
                firstnametxt.Focus();
                errorProvider1.SetError(this.firstnametxt, "Shëno emrin tend!");
            }
            else if (string.IsNullOrEmpty(lastnametxt.Text) == true)
            {
                lastnametxt.Focus();
                errorProvider2.SetError(this.lastnametxt, "Shëno mbiemrin tend!");
            }
            else if (emailtxt == null)
            {
                MessageBox.Show("Jepeni email tuaj.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkBox1.Checked != true)
            {
                checkBox1.Focus();
                errorProvider6.SetError(this.checkBox1, "A i pranon kushtet tona?");
            }
            else if (string.IsNullOrEmpty(textBox1.Text) == true) {

                textBox1.Focus();
                errorProvider7.SetError(this.textBox1, "Jepeni çmimin e produktit.");
            }
            else if (pictureBox1.Image == null)
            {
                pictureBox1.Focus();
                errorProvider8.SetError(this.shtobtn, "Shto produktin!");
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] img = ms.ToArray();
                String insertQuery = "INSERT INTO signup(emri,mbiemri,adresa,email,foto,çmimi) VALUES (@emri,@mbiemri,@adresa, @email, @img, @çmimi)";
                connect.Open();

                con = new MySqlCommand(insertQuery, connect);

                con.Parameters.Add("@emri", MySqlDbType.VarChar,30);
                con.Parameters.Add("@mbiemri", MySqlDbType.VarChar, 30);
                con.Parameters.Add("@adresa", MySqlDbType.VarChar, 30);            
                con.Parameters.Add("@email", MySqlDbType.VarChar, 30);
                con.Parameters.Add("@img", MySqlDbType.LongBlob);
                con.Parameters.Add("@çmimi", MySqlDbType.Int32,11);

                con.Parameters["@emri"].Value = firstnametxt.Text;
                con.Parameters["@mbiemri"].Value = lastnametxt.Text;
                con.Parameters["@adresa"].Value = addresstxt.Text;
                con.Parameters["@email"].Value = emailtxt.Text;
                con.Parameters["@img"].Value = img;
                con.Parameters["@çmimi"].Value = textBox1.Text;
                
                if (con.ExecuteNonQuery() == 1)
                {
                    Form7 f7 = new Form7();
                    f7.ShowDialog();

                }
                connect.Close();
                firstnametxt.Text = lastnametxt.Text = emailtxt.Text = addresstxt.Text = textBox1.Text = " ";
                pictureBox1.Image = null;
            }
        }
        String imageLocation = "";
        OpenFileDialog dialog = new OpenFileDialog();  
        private void shtobtn_Click_1(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                pictureBox1.Focus();
                errorProvider8.SetError(this.shtobtn, "Shto Produktin!");
            }
            else
                errorProvider8.Clear();
            try
            {
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    if (pictureBox1.Image == null)
                    {
                        pictureBox1.ImageLocation = imageLocation;
                    }
                    else
                    {
                        pictureBox1.Image = null;
                        pictureBox1.ImageLocation = imageLocation;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ka ndodhur një error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void firstnametxt_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}