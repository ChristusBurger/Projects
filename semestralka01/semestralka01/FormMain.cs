using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace semestralka01
{
    public partial class FormMain : Form
    {
        

        public FormMain()
        {
            InitializeComponent();
            panel1.SendToBack();
            Database.Deserialize();
            panelCat.Hide();
            Database.Init();
            dataGridViewUsers.DataSource = Database.Users;
            dataGridViewSelectedCat.AutoSize = true;
            dataGridViewSelectedTable.AutoSize = true;



            dataGridViewStorage.AutoGenerateColumns = true;
            
     
            dataGridViewStorage.DataSource = Database.Storage;
         

        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            // dataGridViewSelectedCat.DataSource = Database.Storage.Contains
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Database.Serialize();
        }

        private void buttonQuickOrder_Click(object sender, EventArgs e)
        {
            // this.buttonQuickOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(44)))));
            this.buttonQuickOrder.BackColor = Color.FromArgb(255, 199, 44);
            panelCat.Visible = true;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.Deserialize();
        }
    }
}