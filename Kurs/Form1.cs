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
    public partial class Form1 : Form
    {
        public bool redact = true;
        public int j;
        bool result;
        string password;
        int seed = 0;
        public int quantity = 20, m;
        public int mynumber;
        public int Q { get => quantity; set => quantity = value; }
        public List<Train> trains = new List<Train>(0);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RefreshTable(List<Train> trains)
        {
            if (trains != null)
            {
                var table = new DataTable("Поезда");

                var number = new DataColumn("Номер в списке");
                var trainNumber = new DataColumn("Номер поезда");
                var station = new DataColumn("Станция");
                var price = new DataColumn("Цена");
                var arivalTime = new DataColumn("Время отправления");
                var departureTime = new DataColumn("Время прибытия");
                var time = new DataColumn("Время в пути");

                table.Columns.Add(number);
                table.Columns.Add(trainNumber);
                table.Columns.Add(station);
                table.Columns.Add(price);
                table.Columns.Add(arivalTime);
                table.Columns.Add(departureTime);
                table.Columns.Add(time);

                for (int i = 0; i < trains.Count; i++)
                {

                    result = true;
                    DataRow row = table.NewRow();
                    row["Номер в списке"] = i + 1;
                    row["Номер поезда"] = trains[i].trains.number;
                    row["Станция"] = trains[i].trains.station;
                    row["Цена"] = trains[i].trains.price;
                    row["Время отправления"] = trains[i].trains.arrival.hour.ToString() + ":" + trains[i].trains.arrival.min.ToString();
                    row["Время прибытия"] = trains[i].trains.departure.hour.ToString() + ":" + trains[i].trains.departure.min.ToString();
                    int Min = Int32.Parse(trains[i].trains.departure.min) - Int32.Parse(trains[i].trains.arrival.min);
                    int Hour = Int32.Parse(trains[i].trains.departure.hour) - Int32.Parse(trains[i].trains.arrival.hour);
                    if (Hour == 0 && Min >= 0) Hour += 24;
                    if (Hour <= 0) Hour += 23;
                    if (Min < 0) Min += 60;
                    
                    row["Время в пути"] = Hour.ToString() + ":" + Min.ToString();
                    table.Rows.Add(row);
                    dataGridView1.DataSource = table;
                }
            }
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            j = -1;
            redact = false;
            AddObj form = new AddObj();
            if (form.ShowDialog() == DialogResult.OK)
            {
                trains.Add(form.train);
                RefreshTable(trains);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (trains.Count == 0)
            {
                MessageBox.Show("База пустая");
                return;
            }
            if (password == null)
            {
                MessageBox.Show("Добавьте пароль");
                return;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            
            string filename = saveFileDialog1.FileName;
            //файловый поток
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            //бинарный записователь 
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(password);
            bw.Write(trains.Count);
            for (int i = 0; i < trains.Count; i++)
            {
                trains[i].Write(bw);
            }
            bw.Close();
            fs.Close();
            MessageBox.Show("Файл сохранен");
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            //файловый поток
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            //бинарный  считователь
            BinaryReader br = new BinaryReader(fs);
            trains.Clear();

            EnterPassword form = new EnterPassword();
            if (form.ShowDialog() == DialogResult.OK)
            {
                password = form.password; 
            }
            if (password == null) return;
            string newpassword = br.ReadString();
            if (String.Equals(password, newpassword))
            { 
                //инициализируем массив кол-вом значенний 
                trains = new List<Train>();
                Q = br.ReadInt32();
                for(int i = 0; i < Q; i++)
                {
                    Train train = new Train();
                    train = train.Read(br);
                    trains.Add(train);
                }
                //while (fs.Position < fs.Length)
                //{
                //    Train train = new Train();
                //    train = train.Read(br);
                //    trains.Add(train);
                //}


                br.Close();
                fs.Close();
                RefreshTable(trains);
                MessageBox.Show("Файл открыт");
            }
            else
            {
                MessageBox.Show("Пароль неверен");
                return;
            }
            
        }

        private void добавитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnterPassword form = new EnterPassword();
            if (form.ShowDialog() == DialogResult.OK) 
            {
                password = form.password;
            }
            if (password !=null)MessageBox.Show("Пароль добавлен");
        }

        private void поНомеруПоездаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = false;
            if (trains.Count == 0)
            {
                MessageBox.Show("База пустая");
                return;
            }
            EnterNumber form = new EnterNumber();
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < trains.Count; i++)
                {
                    if (trains[i].trains.number == form.n)
                    {
                        trains.RemoveAt(i);
                        result = true;
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Совпадений нет");
                }
            }
            
            RefreshTable(trains);
        }

        private void поНомеруВСпискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = false;
            if (trains.Count == 0)
            {
                MessageBox.Show("База пустая");
                return;
            }
            EnterNumber form = new EnterNumber();
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < trains.Count; i++)
                {
                    if (i+1 == form.n)
                    {
                        trains.RemoveAt(i);
                        result = true;
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Совпадений нет");
                }
            }
            RefreshTable(trains);
        }

        private void поНомеруПоездаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (trains.Count == 0)
            {
                MessageBox.Show("База пуста");
                return;
            }
            var table = new DataTable("Поезда");

            var number = new DataColumn("Номер в списке");
            var trainNumber = new DataColumn("Номер поезда");
            var station = new DataColumn("Станция");
            var price = new DataColumn("Цена");
            var arivalTime = new DataColumn("Время отправления");
            var departureTime = new DataColumn("Время прибытия");
            var time = new DataColumn("Время в пути");

            table.Columns.Add(number);
            table.Columns.Add(trainNumber);
            table.Columns.Add(station);
            table.Columns.Add(price);
            table.Columns.Add(arivalTime);
            table.Columns.Add(departureTime);
            table.Columns.Add(time);
            EnterNumber form = new EnterNumber();

            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < trains.Count; i++)
                {
                    if (trains[i].trains.number == form.n)
                    {
                        result = true;
                        DataRow row = table.NewRow();
                        row["Номер в списке"] = i+1;
                        row["Номер поезда"] = trains[i].trains.number;
                        row["Станция"] = trains[i].trains.station;
                        row["Цена"] = trains[i].trains.price;
                        row["Время отправления"] = trains[i].trains.arrival.hour.ToString() + ":" + trains[i].trains.arrival.min.ToString();
                        row["Время прибытия"] = trains[i].trains.departure.hour.ToString() + ":" + trains[i].trains.departure.min.ToString();
                        int Min = Int32.Parse(trains[i].trains.departure.min) - Int32.Parse(trains[i].trains.arrival.min);
                        int Hour = Int32.Parse(trains[i].trains.departure.hour) - Int32.Parse(trains[i].trains.arrival.hour);
                        if (Hour == 0 && Min >= 0) Hour += 24;
                        if (Hour <= 0) Hour += 23;
                        if (Min < 0) Min += 60;
                        row["Время в пути"] = Hour.ToString() + ":" + Min.ToString();
                        table.Rows.Add(row);
                        dataGridView1.DataSource = table;
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Совпадений нет");
                }
                else
                {
                    BackBtn.Enabled = true;
                    BackBtn.Visible = true;
                }
            }
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            RefreshTable(trains);
            BackBtn.Enabled = false;
            BackBtn.Visible = false;
        }

        private void поНаправлениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            result = false;
            if (trains.Count == 0)
            {
                MessageBox.Show("База пуста");
                return;
            }
            var table = new DataTable("Поезда");

            var number = new DataColumn("Номер в списке");
            var trainNumber = new DataColumn("Номер поезда");
            var station = new DataColumn("Станция");
            var price = new DataColumn("Цена");
            var arivalTime = new DataColumn("Время отправления");
            var departureTime = new DataColumn("Время прибытия");
            var time = new DataColumn("Время в пути");

            table.Columns.Add(number);
            table.Columns.Add(trainNumber);
            table.Columns.Add(station);
            table.Columns.Add(price);
            table.Columns.Add(arivalTime);
            table.Columns.Add(departureTime);
            table.Columns.Add(time);

            EnterStation form = new EnterStation();
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < trains.Count; i++)
                {
                    if (trains[i].trains.station.Equals(form.station))
                    {
                        result = true;
                        DataRow row = table.NewRow();
                        row["Номер в списке"] = i+1;
                        row["Номер поезда"] = trains[i].trains.number;
                        row["Станция"] = trains[i].trains.station;
                        row["Цена"] = trains[i].trains.price;
                        row["Время отправления"] = trains[i].trains.arrival.hour + ":" + trains[i].trains.arrival.min;
                        row["Время прибытия"] = trains[i].trains.departure.hour + ":" + trains[i].trains.departure.min;
                        int Min = Int32.Parse(trains[i].trains.departure.min) - Int32.Parse(trains[i].trains.arrival.min);
                        int Hour = Int32.Parse(trains[i].trains.departure.hour) - Int32.Parse(trains[i].trains.arrival.hour);
                        if (Hour == 0 && Min >= 0) Hour += 24;
                        if (Hour <= 0) Hour += 23;
                        if (Min < 0) Min += 60;
                        row["Время в пути"] = Hour.ToString() + ":" + Min.ToString();
                        table.Rows.Add(row);
                        dataGridView1.DataSource = table;
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Совпадений нет");
                }

                else
                {
                    BackBtn.Enabled = true;
                    BackBtn.Visible = true;
                }
            }

        }

        private void поНомеруВСпискеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            redact = true;
            result = false;
            if (trains.Count == 0)
            {
                MessageBox.Show("База пустая");
                return;
            }
            EnterNumber form = new EnterNumber();
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < trains.Count; i++)
                {
                    if (i+1 == form.n)
                    {
                        mynumber = trains[i].trains.number;
                        result = true;
                        j = i;
                        AddObj f = new AddObj();
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            trains[i] = f.train;
                            RefreshTable(trains);
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Совпадений нет");
                }
            }
            j = -1;
        }

        private void поНомеруПоездаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            redact = true;
            result = false;
            if (trains.Count == 0)
            {
                MessageBox.Show("База пустая");
                return;
            }
            EnterNumber form = new EnterNumber();
            if (form.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < trains.Count; i++)
                {
                    if (trains[i].trains.number == form.n)
                    {
                        mynumber = trains[i].trains.number;
                        result = true;
                        j = i;
                        AddObj f = new AddObj();
                        if (f.ShowDialog() == DialogResult.OK)
                        {
                            trains[i] = f.train;
                            RefreshTable(trains);
                        }
                    }
                }
                if (result == false)
                {
                    MessageBox.Show("Совпадений нет");
                }
            }
            j = -1;
        }

        private void сгенерироватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            trains = new List<Train>();
            for (int i = 0; i < Q; i++)
            {
                trains.Add(new Train(seed++));
                trains[i].SetTrainInfo();
            }
            RefreshTable(trains);
            MessageBox.Show("База данных сгенерирована");
        }

    }
}
