using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs
{
    public partial class EnterNumber : Form
    {
        public int n;
        public EnterNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                n= Convert.ToInt32(textBox1.Text);
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
