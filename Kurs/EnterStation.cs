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
    public partial class EnterStation : Form
    {
        public string station;
        public EnterStation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                station = Convert.ToString(textBox1.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
