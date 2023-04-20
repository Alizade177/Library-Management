using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class InitForm : Form
    {
        public InitForm()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {

        }
       
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }
    }
}
