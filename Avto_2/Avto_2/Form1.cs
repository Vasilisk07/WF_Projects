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
using Avto_2.Properties;


namespace Avto_2
{
    public struct avto
    {
        public int count;
        public string Name;
        public string Number;
        public string money;
        public string data;
        public int All_money;
    }

    public partial class Form1 : Form
    {
        List<avto> new_avto = new List<avto>();

        public Form1()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            int counter;
            int.TryParse(Properties.Settings.Default.counter_save, out counter);
            int chek;
           


            if (textBox3.Text == "" || !(int.TryParse(textBox3.Text, out chek)))
            {
                MessageBox.Show("Помилка вводу.\n" + "Необхiдно заповнити поле сумма.\nЯке повинно мiстити в собi лише цiлi числа.", "CTO list", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            else
            {
                try
                {
                    avto A;
                    A.All_money = 0;
                    A.count = counter++;
                    A.Name = textBox1.Text;
                    A.Number = textBox2.Text;
                    A.money = textBox3.Text;
                    A.data = DateTime.Now.ToShortDateString();
                    new_avto.Add(A);
                    System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\CTO_list_data.txt", true);
                    writer.WriteLine("Запис № " + A.count.ToString());
                    writer.WriteLine("Дата: " + DateTime.Now.ToShortDateString());
                    if (textBox1.Text == "")
                    {
                        writer.WriteLine("Марка авто: " + "Авто" + A.count.ToString());
                    }
                    else
                    {
                        writer.WriteLine("Марка авто: " + textBox1.Text);
                    }
                    if (textBox2.Text == "")
                    {
                        writer.WriteLine("Номер авто: " + "XXXNOXXX");
                    }
                    else
                    {
                        writer.WriteLine("Номер авто: " + textBox2.Text);
                    }

                    writer.WriteLine("Оплата: " + textBox3.Text + "грн");
                    if (textBox2.Text == null)
                    {
                        writer.WriteLine("Номер авто: " + "XXXNOXXX");
                    }
                    writer.WriteLine("---------------------------------------------");
                    richTextBox1.Text = "\n\n\n\n\n\n\n\nЗапис успiшно додано.";
                    writer.Close();

                    if (textBox2.Text == "59507ХМ"&& textBox1.Text =="ВАЗ 2106") 
                    {
                        richTextBox1.Text = "\n!!!МОЛОДЕЦЬ!!! \n!!!ТИ ЗНАЙШОВ ПАСХАЛКУ!!!\nВиробництво моделі розпочалось у 1976 році на заводі в Тольятті.\n Модель була перероблена з ВАЗ-2103, який в свою чергу був перероблений з FIAT 124 Speciale\n зразка 1972 року. Згодом ВАЗ-2106 став найпрестижнішим автомобілем в СРСР після Волги, який можна було придбати." +
                            "\n«Шістка» відрізняється від ВАЗ-2103 потужнішим 80-сильним двигуном ВАЗ-2106 з робочим об'ємом 1,6 л, іншою схемою електроустаткування і зміненим оформленням кузова і салону. Так, передні здвоєні фари отримали пластмасові «очі», змінено облицювання радіатора, встановлено інші бампери з поліуретановими «іклами» і пластмасовими «кутками», задні ліхтарі об'єднані з підсвіткою номерного знаку." +
                            "\nУ порівнянні з автомобілями «Москвич», ці 5-місні седани, що відрізнялися кращою динамікою і дійсно комфортним інтер'єром, були верхом комфорту і престижу для широких верств автолюбителів СРСР. Наприкінці 1970-х ВАЗ-2106 відразу набув слави «вишуканого» і швидкісного автомобіля, але дорогого і менш «практичного», ніж інші «Жигулі». Пристойна для того часу динаміка (максимальна швидкість 150 км/год), рельєфні сидіння з підголівниками, панель приладів із тахометром та непогана звукоізоляція.";


                    }


                }

                catch
                {
                    MessageBox.Show("Неможливо створити .txt документ за посиланням C:\\CTO_list_data.txt\nНадайте програмi права адмiнiстратора\n або спробуйте створити його самостiйно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
       
            if (Properties.Settings.Default.all_money_save == "0")
            {
                int money_1;
                int.TryParse(textBox3.Text, out money_1);
                money_1 /= 2;
                Properties.Settings.Default.all_money_save = money_1.ToString();
                Properties.Settings.Default.Save();
            }
            else
            {
                int mon;
                int mon_all;                
                int.TryParse(Properties.Settings.Default.all_money_save, out mon_all);
                int.TryParse(textBox3.Text, out mon);
                mon_all += (mon/2);     
                Properties.Settings.Default.all_money_save = mon_all.ToString();
                Properties.Settings.Default.Save();
            }

                 textBox1.Text = "";
                 textBox2.Text = "";
                 textBox3.Text = "";

            Properties.Settings.Default.counter_save = counter.ToString();
            Properties.Settings.Default.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.StreamReader reader = new System.IO.StreamReader("C:\\CTO_list_data.txt", true);
                richTextBox1.Text = "";
                string all_text = File.ReadAllText("C:\\CTO_list_data.txt");
                richTextBox1.Text = "Вибiрка данних:\n\n" + all_text;
                textBox4.Text = Properties.Settings.Default.all_money_save+" Грн";
                reader.Close();
            }
            catch  
            {
                richTextBox1.Text = "\n\n\n\n\n\n\n\n\nПомилка записiв не iснує!";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var result= MessageBox.Show("Ви дiйсно бажаєте очистити всi данні","Очистка данних", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Properties.Settings.Default.all_money_save = "0";
                    Properties.Settings.Default.counter_save = "1";
                    Properties.Settings.Default.Save();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    richTextBox1.Text = "";
                    File.Delete("C:\\CTO_list_data.txt");
                    richTextBox1.Text = "\n\n\n\n\n\n\n\n\nОчистку данних виконано";
                }
                catch
                {
                    MessageBox.Show("Неможливо створити .txt документ за посиланням C:\\CTO_list_data.txt\nНадайте програмi права адмiнiстратора\n або спробуйте створити його самостiйно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }



        }
    }
}
