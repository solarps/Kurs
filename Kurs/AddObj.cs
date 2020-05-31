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
    public partial class AddObj : Form
    {
        public Train train;
        private Form1 MyForm = Application.OpenForms[0] as Form1;

        public AddObj()
        {
            InitializeComponent();
        }

        private void AddObj_Load(object sender, EventArgs e)
        {
            if (MyForm.j>= 0)
            {
                int i = MyForm.j;
                textBox1.Text = MyForm.trains[i].trains.number.ToString();
                textBox2.Text = MyForm.trains[i].trains.station;
                textBox3.Text = MyForm.trains[i].trains.arrival.hour;
                textBox4.Text = MyForm.trains[i].trains.arrival.min;
                textBox5.Text = MyForm.trains[i].trains.departure.hour;
                textBox6.Text = MyForm.trains[i].trains.departure.min;
                textBox7.Text = MyForm.trains[i].trains.price.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            train = new Train();
            try
            {
                train.trains.number = Convert.ToInt32(textBox1.Text);
                if (train.trains.number <= 0)
                {
                    MessageBox.Show("Неверный ввод");
                    return;
                }
                if (MyForm.redact==false)
                {
                    for (int i = 0; i < MyForm.trains.Count; i++)
                    {
                        if (train.trains.number == MyForm.trains[i].trains.number)
                        {
                            MessageBox.Show("Такой номер уже существует");
                            return;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < MyForm.trains.Count; i++)
                    {
                        if (train.trains.number == MyForm.trains[i].trains.number && train.trains.number!=MyForm.mynumber)
                        {
                            MessageBox.Show("Такой номер уже существует");
                            return;
                        }
                    }
                }
                train.trains.station =textBox2.Text;
                train.trains.arrival.hour = textBox3.Text;
                train.trains.arrival.min = textBox4.Text;
                train.trains.departure.hour = textBox5.Text;
                train.trains.departure.min = textBox6.Text;
                int ah = Int32.Parse(train.trains.arrival.hour);
                int am = Int32.Parse(train.trains.arrival.min);
                int dh = Int32.Parse(train.trains.departure.hour);
                int dm = Int32.Parse(train.trains.departure.min);
                train.trains.arrival.hour = ah.ToString();
                train.trains.arrival.min = am.ToString();
                train.trains.departure.hour = dh.ToString();
                train.trains.departure.min = dm.ToString();
                if (ah<0 || ah>23 || dh < 0 || dh > 23 || am < 0 || am > 59 || dm< 0 || dm> 59)
                {
                    MessageBox.Show("Неверный ввод");
                    return;
                }
                if (ah < 10)
                {
                    train.trains.arrival.hour = "0" + train.trains.arrival.hour;
                }
                if (am < 10)
                {
                    train.trains.arrival.min = "0" + train.trains.arrival.min;
                }
                if (dh < 10)
                {
                    train.trains.departure.hour = "0" + train.trains.departure.hour;
                }
                if (dm < 10)
                {
                    train.trains.departure.min = "0" + train.trains.departure.min;
                }
                train.trains.price = Convert.ToInt32(textBox7.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return;
            }
            if (train.trains.station == "")
            {
                return;
            }
            this.DialogResult = DialogResult.OK;

        }
    }
}
