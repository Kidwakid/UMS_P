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

namespace UMS
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            UMS_DB db = new UMS_DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand com = new MySqlCommand("SELECT * FROM `users` WHERE `username`=@usn AND `password`= @pass", db.getConnection);

            com.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox1.Text;
            com.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;

            adapter.SelectCommand = com;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show("Invalid Username or Password","Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}
