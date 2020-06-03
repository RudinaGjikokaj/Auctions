using home;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySqlX.XDevAPI.Relational;
using sign_up;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{

    public partial class Form7 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;database=ankande;user=root;password=");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable tabela = new DataTable();
        MySqlDataReader dr;

 
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Label) Controls[i].Hide();
                label34.Show();
            }
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (Controls[i] is Button) Controls[i].Hide();
                button3.Show();
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("select foto from signup", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                byte[] b = new byte[0];
                b = (Byte[])(dr["foto"]);
                MemoryStream ms = new MemoryStream(b);
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = Image.FromStream(ms);
                    label3.Show();
                    label15.Show();
                    button1.Show();
                    label13.Show();
                }
                else if (pictureBox2.Image == null)
                {
                    pictureBox2.Image = Image.FromStream(ms);
                    label4.Show();
                    label16.Show();
                    button2.Show();
                    label14.Show();
                }
                else if (pictureBox3.Image == null)
                {
                    pictureBox3.Image = Image.FromStream(ms);
                    label5.Show();
                    label17.Show();
                    button5.Show();
                    label25.Show();
                }
                else if (pictureBox4.Image == null)
                {
                    pictureBox4.Image = Image.FromStream(ms);
                    label6.Show();
                    label18.Show();
                    button6.Show();
                    label26.Show();
                }
                else if (pictureBox5.Image == null)
                {
                    pictureBox5.Image = Image.FromStream(ms);
                    label7.Show();
                    label19.Show();
                    button7.Show();
                    label27.Show();
                }
                else if (pictureBox6.Image == null)
                {
                    pictureBox6.Image = Image.FromStream(ms);
                    label8.Show();
                    label20.Show();
                    button8.Show();
                    label28.Show();
                }
                else if (pictureBox7.Image == null)
                {
                    pictureBox7.Image = Image.FromStream(ms);
                    label9.Show();
                    label21.Show();
                    button9.Show();
                    label29.Show();
                }
                else if (pictureBox8.Image == null)
                {
                    pictureBox8.Image = Image.FromStream(ms);
                    label10.Show();
                    label22.Show();
                    button10.Show();
                    label30.Show();
                }
                else if (pictureBox9.Image == null)
                {
                    pictureBox9.Image = Image.FromStream(ms);
                    label11.Show();
                    label23.Show();
                    button11.Show();
                    label31.Show();
                }
                else if (pictureBox10.Image == null)
                {
                    pictureBox10.Image = Image.FromStream(ms);
                    label12.Show();
                    label24.Show();
                    button12.Show();
                    label32.Show();
                }
                else
                {
                    MessageBox.Show("Derisa njëri nga artikujt tjerë të shtitet, ju mund të blini nga artikujt tonë.", "Përshëndetje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
            
        private static int iCount10 = 0, iCount1 = 0, iCount2 = 0, iCount3 = 0, iCount4 = 0, iCount5 = 0;
        private static int iCount6 = 0, iCount7 = 0, iCount8 = 0, iCount9 = 0;

        String imageLocation = "";
        OpenFileDialog dialog = new OpenFileDialog();
        Random randomizer = new Random();
        int timeLeft1, timeLeft2, timeLeft3, timeLeft4, timeLeft5, timeLeft6, timeLeft7, timeLeft8, timeLeft9, timeLeft10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft1 > 0)
            {
                timeLeft1 = timeLeft1 - 1;
                label13.Text = "Koha " + timeLeft1 + " seconds";
            }
            else
            {
                timer1.Stop();
                label13.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button1.Enabled = true;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft2 > 0)
            {
                timeLeft2 = timeLeft2 - 1;
                label14.Text = "Koha " + timeLeft2 + " seconds";
            }
            else
            {
                timer2.Stop();
                label14.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button2.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timeLeft3 > 0)
            {
                timeLeft3 = timeLeft3 - 1;
                label25.Text = "Koha " + timeLeft3 + " seconds";
            }
            else
            {
                timer3.Stop();
                label25.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button5.Enabled = true;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timeLeft4 > 0)
            {
                timeLeft4 = timeLeft4 - 1;
                label26.Text = "Koha " + timeLeft4 + " seconds";
            }
            else
            {
                timer4.Stop();
                label26.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button6.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (timeLeft5 > 0)
            {
                timeLeft5 = timeLeft5 - 1;
                label27.Text = "Koha " + timeLeft5 + " seconds";
            }
            else
            {
                timer5.Stop();
                label27.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button7.Enabled = true;
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (timeLeft6 > 0)
            {
                timeLeft6 = timeLeft6 - 1;
                label28.Text = "Koha " + timeLeft6 + " seconds";
            }
            else
            {
                timer6.Stop();
                label28.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button8.Enabled = true;
            }
        }
        private void timer7_Tick(object sender, EventArgs e)
        {
            if (timeLeft7 > 0)
            {
                timeLeft7 = timeLeft7 - 1;
                label29.Text = "Koha " + timeLeft7 + " seconds";
            }
            else
            {
                timer7.Stop();
                label29.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button9.Enabled = true;
            }
        }
        private void timer8_Tick(object sender, EventArgs e)
        {
            if (timeLeft8 > 0)
            {
                timeLeft8 = timeLeft8 - 1;
                label30.Text = "Koha " + timeLeft8 + " seconds";
            }
            else
            {
                timer8.Stop();
                label30.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button10.Enabled = true;
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (timeLeft9 > 0)
            {
                timeLeft9 = timeLeft9 - 1;
                label31.Text = "Koha " + timeLeft9 + " seconds";
            }
            else
            {
                timer9.Stop();
                label31.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button11.Enabled = true;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            if (timeLeft10 > 0)
            {
                timeLeft10 = timeLeft10 - 1;
                label32.Text = "Koha " + timeLeft10 + " seconds";
            }
            else
            {
                timer10.Stop();
                label32.Text = "Koha ka mbaruar!";
                MessageBox.Show("Artikulli u shit!", "Na vjen keq!");
                button12.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            iCount10 = iCount10 + 50;
            label15.Text = iCount10.ToString();
            timeLeft1 = 30;
            label13.Text = "30 sekonda";
            timer1.Start();
/*
            try
            {
                 
                string MyConnection2 = "Server = localhost; database = ankande; user = root; password = ";  
                string Query = "update signup set çmimi='" + this.label15.Text +"'";
                string delete = "delete * from signup where çmimi='" + this.label15.Text+"';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlCommand MyCommand3 = new MySqlCommand(delete, MyConn2);
               
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyReader2 = MyCommand3.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
 */
        }
        private void button2_Click(object sender, EventArgs e)
        {
            iCount1 = iCount1 + 50;
            label16.Text = iCount1.ToString();
            timeLeft2 = 30;
            label14.Text = "30 sekonda";
            timer2.Start();          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            iCount2 = iCount2 + 50;
            label17.Text = iCount2.ToString();
            timeLeft3 = 1000;
            label25.Text = "1 orë";
            timer3.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            iCount3 = iCount3 + 50;
            label18.Text = iCount3.ToString();
            timeLeft4 = 1000;
            label26.Text = "1 orë";
            timer4.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iCount4 = iCount4 + 50;
            label19.Text = iCount4.ToString();
            timeLeft5 = 1000;
            label27.Text = "1 orë";
            timer5.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            iCount5 = iCount5 + 50;
            label20.Text = iCount5.ToString();
            timeLeft6 = 1000;
            label28.Text = "1 orë";
            timer6.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            iCount6 = iCount6 + 50;
            label21.Text = iCount6.ToString();
            timeLeft7 = 1000;
            label29.Text = "1 orë";
            timer7.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            iCount7 = iCount7 + 50;
            label22.Text = iCount7.ToString();
            timeLeft8 = 1000;
            label30.Text = "1 orë";
            timer8.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            iCount8 = iCount8 + 50;
            label23.Text = iCount8.ToString();
            timeLeft9 = 1000;
            label31.Text = "1 orë";
            timer9.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            iCount9 = iCount9 + 50;
            label24.Text = iCount9.ToString();
            timeLeft10 = 1000;
            label32.Text = "1 orë";
            timer10.Start();
        }
    }
}

