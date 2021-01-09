using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerHardwareInventory
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            
            GunaPanel_slide.Start();

            guna2Panel2.Visible = true;
            label_signin.Visible = true;
            txtbox_username.Visible = true;
            txtbox_password.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string var = Files.Controller.Controller.variables.cat;
            MessageBox.Show(var);
            
        }
    }
}
