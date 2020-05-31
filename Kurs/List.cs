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
    public partial class List : Form
    {
        private Form1 MyForm = Application.OpenForms[0] as Form1;
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
        //    var column1 = new DataGridViewColumn();
        //    column1.HeaderText = "Номер"; //текст в шапке
        //    column1.Width = 45; //ширина колонки
        //    column1.ReadOnly = true; //значение в этой колонке нельзя править
        //    column1.Name = "number"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
        //    column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
        //    column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

        //    var column2 = new DataGridViewColumn();
        //    column2.HeaderText = "Станция";
        //    column2.Name = "statiaon";
        //    column2.CellTemplate = new DataGridViewTextBoxCell();

        //    var column3 = new DataGridViewColumn();
        //    column3.HeaderText = "Цена";
        //    column3.Name = "price";
        //    column3.CellTemplate = new DataGridViewTextBoxCell();

        //    var column4 = new DataGridViewColumn();
        //    column4.HeaderText = "Время отправления";
        //    column4.Name = "arrival";
        //    column4.CellTemplate = new DataGridViewTextBoxCell();

        //    var column5 = new DataGridViewColumn();
        //    column5.HeaderText = "Время прибытия";
        //    column5.Name = "departure";
        //    column5.CellTemplate = new DataGridViewTextBoxCell();

        //    dataGridView1.Columns.Add(column1);
        //    dataGridView1.Columns.Add(column2);
        //    dataGridView1.Columns.Add(column3);
        //    dataGridView1.Columns.Add(column4);
        //    dataGridView1.Columns.Add(column5);

        //    dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

        //    for (int i = 0; i < MyForm.trains.Count; ++i)
        //    {
        //        //Добавляем строку, указывая значения колонок поочереди слева направо
        //        dataGridView1.Rows.Add(MyForm.trains[i].trains.number, MyForm.trains[i].trains.station, MyForm.trains[i].trains.price, MyForm.trains[i].trains.arrival.hour.ToString() + ":" + MyForm.trains[i].trains.arrival.min.ToString(), MyForm.trains[i].trains.departure.hour.ToString() + ":" + MyForm.trains[i].trains.departure.min.ToString(), i);
        //    }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        //private void сгенерироватьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < Q; i++)
        //    {
        //        trains.Add(new Train(seed++));
        //        trains[i].SetTrainInfo();
        //    }
        //    MessageBox.Show("База данных сгенерирована");
        //}

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        //        saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
        //        saveFileDialog1.FilterIndex = 2;
        //        saveFileDialog1.RestoreDirectory = true;

        //        if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
        //            return;
        //        string filename = saveFileDialog1.FileName;
        //        //файловый поток
        //        FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
        //        //бинарный записователь 
        //        BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
        //        for (int i = 0; i < trains.Count; i++)
        //        {
        //            trains[i].Write(bw);
        //        }
        //        bw.Close();
        //        fs.Close();
        //        MessageBox.Show("Файл сохранен");
        //        //// сохраняем текст в файл
        //        //if (filename != "")
        //        //{
        //        //    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
        //        //    {
        //        //        sw.Write("Triangles:\n");
        //        //        sw.Write(OutN.Text);

        //        //    }
        //    }
        //}
    }
}

//private void Form1_Load(object sender, EventArgs e)
//{


//}
//private void GenBaseBTN_Click(object sender, EventArgs e)
//{
//    for (int i = 0; i < Q; i++)
//    {
//        trains.Add(new Train(seed++));
//        trains[i].SetTrainInfo();
//    }
//    MessageBox.Show("База данных сгенерирована");
//}



//private void ShowBaseBTN_Click(object sender, EventArgs e)
//{
//    if (trains.Count == 0)
//    {
//        MessageBox.Show("База данных пуста");
//    }
//    else
//    {
//        dataGridView1.Visible = true;
//        dataGridView1.Enabled = true;
//        ShowBaseBTN.Enabled = false;
//        ShowBaseBTN.Visible = false;
//        GenBaseBTN.Enabled = false;
//        GenBaseBTN.Visible = false;
//        AddObjBTN.Enabled = false;
//        AddObjBTN.Visible = false;
//        label1.Visible = false;
//        SaveBaseBtn.Enabled = false;
//        SaveBaseBtn.Visible = false;
//        LoadBaseBtn.Enabled = false;
//        LoadBaseBtn.Visible = false;
//        BackBtn.Enabled = true;
//        BackBtn.Visible = true;
//        var column1 = new DataGridViewColumn();
//        column1.HeaderText = "Номер"; //текст в шапке
//        column1.Width = 45; //ширина колонки
//        column1.ReadOnly = true; //значение в этой колонке нельзя править
//        column1.Name = "number"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
//        column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
//        column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

//        var column2 = new DataGridViewColumn();
//        column2.HeaderText = "Станция";
//        column2.Name = "statiaon";
//        column2.CellTemplate = new DataGridViewTextBoxCell();

//        var column3 = new DataGridViewColumn();
//        column3.HeaderText = "Цена";
//        column3.Name = "price";
//        column3.CellTemplate = new DataGridViewTextBoxCell();

//        var column4 = new DataGridViewColumn();
//        column4.HeaderText = "Время отправления";
//        column4.Name = "arrival";
//        column4.CellTemplate = new DataGridViewTextBoxCell();

//        var column5 = new DataGridViewColumn();
//        column5.HeaderText = "Время прибытия";
//        column5.Name = "departure";
//        column5.CellTemplate = new DataGridViewTextBoxCell();

//        dataGridView1.Columns.Add(column1);
//        dataGridView1.Columns.Add(column2);
//        dataGridView1.Columns.Add(column3);
//        dataGridView1.Columns.Add(column4);
//        dataGridView1.Columns.Add(column5);

//        dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

//        for (int i = 0; i < trains.Count; ++i)
//        {
//            //Добавляем строку, указывая значения колонок поочереди слева направо
//            dataGridView1.Rows.Add(trains[i].trains.number, trains[i].trains.station, trains[i].trains.price, trains[i].trains.arrival.hour.ToString() + ":" + trains[i].trains.arrival.min.ToString(), trains[i].trains.departure.hour.ToString() + ":" + trains[i].trains.departure.min.ToString(), i);
//        }
//    }
//}

//private void BackBtn_Click(object sender, EventArgs e)
//{
//    ShowBaseBTN.Enabled = true;
//    ShowBaseBTN.Visible = true;
//    GenBaseBTN.Enabled = true;
//    GenBaseBTN.Visible = true;
//    AddObjBTN.Enabled = true;
//    AddObjBTN.Visible = true;
//    label1.Visible = true;
//    SaveBaseBtn.Enabled = true;
//    SaveBaseBtn.Visible = true;
//    LoadBaseBtn.Enabled = true;
//    LoadBaseBtn.Visible = true;
//    BackBtn.Enabled = false;
//    BackBtn.Visible = false;
//    SaveBtn.Enabled = false;
//    SaveBtn.Visible = false;
//    textBox1.Enabled = false;
//    textBox1.Visible = false;
//    textBox2.Enabled = false;
//    textBox2.Visible = false;
//    textBox3.Enabled = false;
//    textBox3.Visible = false;
//    textBox4.Enabled = false;
//    textBox4.Visible = false;
//    textBox5.Enabled = false;
//    textBox5.Visible = false;
//    textBox6.Enabled = false;
//    textBox6.Visible = false;
//    textBox7.Enabled = false;
//    textBox7.Visible = false;
//    label6.Visible = false;
//    label2.Visible = false;
//    label3.Visible = false;
//    label4.Visible = false;
//    label5.Visible = false;
//    label7.Visible = false;
//    label8.Visible = false;
//    dataGridView1.Visible = false;
//    dataGridView1.Enabled = false;
//}
//private void AddObjBTN_Click(object sender, EventArgs e)
//{
//    ShowBaseBTN.Enabled = false;
//    ShowBaseBTN.Visible = false;
//    GenBaseBTN.Enabled = false;
//    GenBaseBTN.Visible = false;
//    AddObjBTN.Enabled = false;
//    AddObjBTN.Visible = false;
//    label1.Visible = false;
//    SaveBaseBtn.Enabled = false;
//    SaveBaseBtn.Visible = false;
//    LoadBaseBtn.Enabled = false;
//    LoadBaseBtn.Visible = false;
//    BackBtn.Enabled = true;
//    BackBtn.Visible = true;
//    SaveBtn.Enabled = true;
//    SaveBtn.Visible = true;
//    textBox1.Enabled = true;
//    textBox1.Visible = true;
//    textBox2.Enabled = true;
//    textBox2.Visible = true;
//    textBox3.Enabled = true;
//    textBox3.Visible = true;
//    textBox4.Enabled = true;
//    textBox4.Visible = true;
//    textBox5.Enabled = true;
//    textBox5.Visible = true;
//    textBox6.Enabled = true;
//    textBox6.Visible = true;
//    textBox7.Enabled = true;
//    textBox7.Visible = true;
//    label6.Visible = true;
//    label2.Visible = true;
//    label3.Visible = true;
//    label4.Visible = true;
//    label5.Visible = true;
//    label7.Visible = true;
//    label8.Visible = true;
//}

//private void SaveBaseBtn_Click(object sender, EventArgs e)
//{
//    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

//    saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
//    saveFileDialog1.FilterIndex = 2;
//    saveFileDialog1.RestoreDirectory = true;

//    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
//        return;
//    string filename = saveFileDialog1.FileName;
//    //файловый поток
//    FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
//    //бинарный записователь 
//    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);
//    for (int i = 0; i < trains.Count; i++)
//    {
//        trains[i].Write(bw);
//    }
//    bw.Close();
//    fs.Close();
//    MessageBox.Show("Файл сохранен");
//    //// сохраняем текст в файл
//    //if (filename != "")
//    //{
//    //    using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
//    //    {
//    //        sw.Write("Triangles:\n");
//    //        sw.Write(OutN.Text);

//    //    }
//}

//private void SaveBtn_Click(object sender, EventArgs e)
//{
//    try
//    {
//        trains.Add(new Train());
//        trains[trains.Count - 1].trains.number = Convert.ToInt32(textBox1.Text);
//        trains[trains.Count - 1].trains.station = Convert.ToString(textBox2.Text);
//        trains[trains.Count - 1].trains.arrival.hour = Convert.ToString(textBox3.Text);
//        trains[trains.Count - 1].trains.arrival.min = Convert.ToString(textBox4.Text);
//        trains[trains.Count - 1].trains.departure.hour = Convert.ToString(textBox5.Text);
//        trains[trains.Count - 1].trains.departure.min = Convert.ToString(textBox6.Text);
//        trains[trains.Count - 1].trains.price = Convert.ToInt32(textBox7.Text);
//    }
//    catch (Exception exc)
//    {
//        MessageBox.Show(exc.Message);
//    }

//}

//private void LoadBaseBtn_Click(object sender, EventArgs e)
//{
//    OpenFileDialog openFileDialog1 = new OpenFileDialog();
//    openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
//    if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
//        return;
//    // получаем выбранный файл
//    string filename = openFileDialog1.FileName;
//    //файловый поток
//    FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
//    //бинарный  считователь
//    BinaryReader br = new BinaryReader(fs, Encoding.UTF8);

//    //инициализируем массив кол-вом значенний 

//    while (fs.Position < fs.Length)
//    {
//        Train train = new Train();
//        train.Read(br);
//        trains.Add(train);
//    }


//    br.Close();
//    fs.Close();

//    MessageBox.Show("Файл открыт");
//}
