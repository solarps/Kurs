using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kurs
{
    public partial class EnterPassword : Form
    {
        public string password;
        public EnterPassword()
        {
            InitializeComponent();
        }

        private void EnterPassword_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                password = Convert.ToString(InputPassword.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            if (password != "")
            {
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
