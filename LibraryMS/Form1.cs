using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtusername(object sender, EventArgs e)
        {
            if (txtusernamebtn.Text == "Username")
            {
                txtusernamebtn.Clear();
            }
                  
        }

        private void txtusername(object sender, MouseEventArgs e)
        {
            if (txtusernamebtn.Text == "Username")
            {
                txtusernamebtn.Clear();
            }

        }

        private void txtPassword(object sender, EventArgs e)
        {
            if(txtpassword.Text=="Password")
            {
                txtpassword.Clear();
            }
        }

        private void txtPassword(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

        private void picboxYoutude_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.Youtube.com/channel/UC2Dn1EkW8zgMgNkddhRVhg");

        }

        private void picboxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/httpswww.youtube.comchanneluc2dn1ekw8zglmgnkd");
        }

        private void picboxinsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/btechdays/");
        }

        private void Loginbtn_Click(object sender, EventArgs e, SqlConnection sqlConnection)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = ALIA;database=master;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loginTable where username ='" + txtusernamebtn.Text + "'and pass='" + txtpassword.Text + "'  ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count != 0)
            {
                Dashboard dsa =new Dashboard();
                dsa.Show();
                dsa.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
