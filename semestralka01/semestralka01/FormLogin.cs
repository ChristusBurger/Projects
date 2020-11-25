using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semestralka01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            Database.Deserialize();
            dataGridViewUsers.DataSource = Database.Users;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Database.Serialize();
            Application.Exit();  
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Select a role");
            }
            if (textBoxPassword.Text ==null || textBoxUsername.Text == null)
            {
                MessageBox.Show("Missing user input data");
            }
            string username = textBoxUsername.Text;
           // for (int i = 0; i < Database.Users.Contains(); i++)
            {
            }

            
            

        }

    }  
    
}
 