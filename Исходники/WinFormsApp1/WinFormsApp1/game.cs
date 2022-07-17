using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }
        int statista = 1;
        private void label1_Click(object sender, EventArgs e)
        {
            statista += 1;
            if (statista > 5)
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.anon4ik;
                int money1 = Int32.Parse(money.Text);
                money1 += 50000;
                money.Text = money1.ToString();
                statista = 1;
            }
        }

        public void Needs()
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 < 0)
            {
                lose lose1 = new lose();
                lose1.Show();
                this.Hide();
            }
            progressBar4.Value += 2;
            progressBar9.Value += 2;
            progressBar5.Value += 2;
            progressBar6.Value += 2;
            progressBar7.Value += 2;
            progressBar8.Value += 2;
            int time1 = Int32.Parse(time.Text);
            int day1 = Int32.Parse(day.Text);
            time1 += 1;
            if (time1 > 23)
            {
                time.Text = "00";
                day1 += 1;
                day.Text = day1.ToString();
            }
            else
            {
                time.Text = time1.ToString();
            }
            if (progressBar6.Value == 100)
            {
                MessageBox.Show("Вы долго не общались с Данилом и заплатили ему 1000 чтобы успокоить");
                money1 -= 1000;
                progressBar6.Value = 0;
                money.Text = money1.ToString();

            }
            if (progressBar4.Value == 100)
            {
                MessageBox.Show("Вы чуть не умерли от голода и срочно купили дорогой якимкебаб за 500 рублей");
                money1 -= 500;
                progressBar4.Value = 0;
                money.Text = money1.ToString();
            }
            if (progressBar9.Value == 100)
            {
                MessageBox.Show("Вы не пили и срочно купили якимколу за 500 рублей");
                money1 -= 500;
                progressBar9.Value = 0;
                money.Text = money1.ToString();
            }
            if (progressBar5.Value == 100)
            {
                MessageBox.Show("Вы не могли уснуть и купили снотворное YakimSleep за 500 рублей");
                money1 -= 500;
                progressBar5.Value = 0;
                money.Text = money1.ToString();
            }
            if (progressBar7.Value == 100)
            {
                MessageBox.Show("Вы справили нужду на пол и потратили 500 рублей на уборку от YakimClean");
                money1 -= 500;
                progressBar7.Value = 0;
                money.Text = money1.ToString();

            }
            if (progressBar8.Value == 100)
            {
                MessageBox.Show("Вы были слишком грязной и купили чистящее средство YakimShampoo");
                money1 -= 500;
                progressBar8.Value = 0;
                money.Text = money1.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 70)
            {
                if (progressBar4.Value >= 20)
                {
                    money1 -= 70;
                    money.Text = money1.ToString();
                    progressBar4.Value -= 20;
                    Needs();
                }
                else
                {
                    money1 -= 70;
                    money.Text = money1.ToString();
                    progressBar4.Value = 0;
                    Needs();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        public void label26_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (progressBar6.Value >= 70)
            {
                progressBar6.Value -= 70;
                Needs();
            }
            else
            {
                progressBar6.Value = 0;
                Needs();
            }
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        public void game_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar5.Value == 0)
            {
                MessageBox.Show("Как можно столько спать?");
            }
            else
            {
                progressBar5.Value = 0;
                Needs();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar7.Value >= 1)
            {
                progressBar7.Value = 0;
                Needs();
            }
            else
            {
                MessageBox.Show("В туалет не хочется");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (progressBar8.Value == 0)
            {
                MessageBox.Show("Сколько не мойся - белее не станешь");
            }
            else
            {
                progressBar8.Value = 0;
                Needs();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value <= 9)
            {
                progressBar1.Value += 1;
                Needs();
            }
            else
            {
                MessageBox.Show("Навык лени на максимуме");
                button4.Enabled = false;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 100)
            {
                if (progressBar4.Value >= 26)
                {
                    money1 -= 100;
                    money.Text = money1.ToString();
                    progressBar4.Value -= 26;
                    Needs();
                }
                else
                {
                    money1 -= 100;
                    money.Text = money1.ToString();
                    progressBar4.Value = 0;
                    Needs();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 200)
            {
                if (progressBar4.Value >= 30)
                {
                    money1 -= 200;
                    money.Text = money1.ToString();
                    progressBar4.Value -= 30;
                    Needs();
                }
                else
                {
                    money1 -= 200;
                    money.Text = money1.ToString();
                    progressBar4.Value = 0;
                    Needs();
                }
            }
            else 
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 80)
            {
                if (progressBar4.Value >= 20)
                {
                    money1 -= 80;
                    money.Text = money1.ToString();
                    progressBar4.Value -= 20;
                    Needs();
                }
                else
                {
                    money1 -= 80;
                    money.Text = money1.ToString();
                    progressBar4.Value = 0;
                    Needs();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 350)
            {
                if (progressBar4.Value >= 50)
                {
                    money1 -= 350;
                    money.Text = money1.ToString();
                    progressBar4.Value -= 50;
                    Needs();
                }
                else
                {
                    money1 -= 350;
                    money.Text = money1.ToString();
                    progressBar4.Value = 0;
                    Needs();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 500)
            {
                if (progressBar4.Value >= 70)
                {
                    money1 -= 500;
                    money.Text = money1.ToString();
                    progressBar4.Value -= 70;
                    Needs();
                }
                else
                {
                    money1 -= 500;
                    money.Text = money1.ToString();
                    progressBar4.Value = 0;
                    Needs();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 700)
            {
                    money1 -= 700;
                    money.Text = money1.ToString();
                    progressBar4.Value = 0;
                    Needs();
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int veroyatnost = rd.Next(1, 100);
            if (veroyatnost <= 80)
            {
                MessageBox.Show("Не получилось выпросить денег");
                Needs();
            }
            else
            {
                int money1 = Int32.Parse(money.Text);
                money1 += 700;
                money.Text = money1.ToString();
                Needs();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (progressBar9.Value >= 30)
            {
                progressBar9.Value -= 30;
                Needs();
            }
            else
            {
                progressBar9.Value = 0;
                Needs();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 50)
            {
                if (progressBar9.Value >= 50)
                {
                    money1 -= 50;
                    money.Text = money1.ToString();
                    progressBar9.Value -= 50;
                    Needs();
                }
                else
                {
                    money1 -= 50;
                    money.Text = money1.ToString();
                    progressBar9.Value = 0;
                    Needs();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 100)
            {
                money1 -= 100;
                money.Text = money1.ToString();
                progressBar9.Value = 0;
                Needs();
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            float vkskill = progressBar2.Value;
            float vksub1 = float.Parse(vksub.Text);
            float vksubplus = vksub1 / 10 * vkskill + vksub1;
            int vksubitog = (int)vksubplus;
            vksub.Text = vksubitog.ToString();
            Needs();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            float tgskill = progressBar3.Value;
            float tgsub1 = float.Parse(tgsub.Text);
            float tgsubplus = tgsub1 / 10 * tgskill + tgsub1;
            int tgsubitog = (int)tgsubplus;
            tgsub.Text = tgsubitog.ToString();
            Needs();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 100000)
            {
                money1 -= 100000;
                money.Text = money1.ToString();
                progressBar4.Maximum = 2000000000;
                Needs();
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 >= 100000)
            {
                money1 -= 100000;
                money.Text = money1.ToString();
                progressBar9.Maximum = 2000000000;
                Needs();
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (progressBar2.Value <= 9)
            {
                money1 -= 1000;
                progressBar2.Value += 1;
                money.Text = money1.ToString();
                Needs();
            }
            else
            {
                MessageBox.Show("Навык улучшен максимально");
                button25.Enabled = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (progressBar3.Value <= 9)
            {
                money1 -= 1000;
                progressBar3.Value += 1;
                money.Text = money1.ToString();
                Needs();
            }
            else
            {
                MessageBox.Show("Навык улучшен максимально");
                button26.Enabled = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            money1 -= 500;
            Random rd = new Random();
            float vksubplus = rd.Next(30, 300);
            float vksub1 = float.Parse(vksub.Text);
            float vksubitog = vksub1 + vksubplus;
            vksub.Text = vksubitog.ToString();
            money.Text = money1.ToString();
            Needs();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            money1 -= 500;
            Random rd = new Random();
            float tgsubplus = rd.Next(10, 100);
            float tgsub1 = float.Parse(tgsub.Text);
            float tgsubitog = tgsub1 + tgsubplus;
            tgsub.Text = tgsubitog.ToString();
            money.Text = money1.ToString();
            Needs();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            float vksub1 = float.Parse(vksub.Text);
            int vkpay;
            if (vksub1 < 100)
            {
                MessageBox.Show("Слишком мало подписчиков. Наберите хотя бы 100");
            }
            if (vksub1 > 99 & vksub1 <1000)
            {
                vkpay = 50;
                money1 = money1 + vkpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (vksub1 > 999 & vksub1 < 5000)
            {
                vkpay = 100;
                money1 = money1 + vkpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (vksub1 > 4999 & vksub1 < 10000)
            {
                vkpay = 200;
                money1 = money1 + vkpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (vksub1 > 9999 & vksub1 < 20000)
            {
                vkpay = 500;
                money1 = money1 + vkpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (vksub1 > 19999)
            {
                vkpay = 700;
                money1 = money1 + vkpay;
                money.Text = money1.ToString();
                Needs();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            float tgsub1 = float.Parse(tgsub.Text);
            int tgpay;
            if (tgsub1 < 50)
            {
                MessageBox.Show("Слишком мало подписчиков. Наберите хотя бы 50");
            }
            if (tgsub1 > 50 & tgsub1 <100)
            {
                tgpay = 50;
                money1 = money1 + tgpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (tgsub1 > 99 & tgsub1 < 500)
            {
                tgpay = 100;
                money1 = money1 + tgpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (tgsub1 > 499 & tgsub1 < 1000)
            {
                tgpay = 200;
                money1 = money1 + tgpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (tgsub1 > 999 & tgsub1 < 5000)
            {
                tgpay = 500;
                money1 = money1 + tgpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (tgsub1 > 4999 & tgsub1 < 10000)
            {
                tgpay = 700;
                money1 = money1 + tgpay;
                money.Text = money1.ToString();
                Needs();
            }
            if (tgsub1 > 9999)
            {
                tgpay = 1000;
                money1 = money1 + tgpay;
                money.Text = money1.ToString();
                Needs();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            money1 += 700;
            money.Text = money1.ToString();
            Needs();
            Needs();
            Needs();
            Needs();
            Needs();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            Random rd = new Random();
            int veroyatnost = rd.Next(1, 100);
            if (veroyatnost > 10 & veroyatnost <= 80)
            {
                MessageBox.Show("Не получилось выпросить денег");
                Needs();
            }
            if (veroyatnost > 80)
            {
                MessageBox.Show("Вас поймали на мошенничестве и выписали штраф 1000 рублей");
                money1 -= 1000;
                money.Text = money1.ToString();
                Needs();
            }
            if (veroyatnost >= 1 & veroyatnost <= 10)
            {
                money1 += 5000;
                money.Text = money1.ToString();
                Needs();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Lain")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources._1QiclySYCSs;
            }
            if (comboBox1.Text == "Лес")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.forest;
            }
            if (comboBox1.Text == "Аниме 1")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.anime1;
            }
            if (comboBox1.Text == "Аниме 2")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.anime2;
            }
            if (comboBox1.Text == "Перерождение безработного 1")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.bezrabotni;
            }
            if (comboBox1.Text == "Перерождение безработного 2")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.bezrabotni_2;
            }
            if (comboBox1.Text == "Eva")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.evangelion;
            }
            if (comboBox1.Text == "Eva 2")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.eva2;
            }
            if (comboBox1.Text == "Аниме 3")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.anime3;
            }
            if (comboBox1.Text == "Аниме 4")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.anime4;
            }
            if (comboBox1.Text == "Minecraft")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.minikraft;
            }
            if (comboBox1.Text == "Миньоны")
            {
                this.BackgroundImage = WinFormsApp1.Properties.Resources.minion;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            progressBar10.Value += 10;
            button28.Enabled = false;
            button27.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            Needs();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (progressBar10.Value <= 99)
            {
                progressBar10.Value += 1;
                Needs();
            }
            else
            {
                button27.Enabled = false;
                MessageBox.Show("Достигнут максимальный уровень троллинга");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (progressBar10.Value == 30)
            {
                button29.Enabled = false;
                MessageBox.Show("Вы вступили в клан Дудлики");
                Needs();
            }
            else
            {
                MessageBox.Show("Не хватает скилла (нужно 30)");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (progressBar10.Value == 70)
            {
                button30.Enabled = false;
                MessageBox.Show("Вы вступили в клан Чопиксы");
                Needs();
            }
            else
            {
                MessageBox.Show("Не хватает скилла (нужно 70)");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (progressBar10.Value == 90)
            {
                button29.Enabled = false;
                MessageBox.Show("Вы вступили в клан Про100тролли");
                Needs();
            }
            else
            {
                MessageBox.Show("Не хватает скилла (нужно 90)");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int money1 = Int32.Parse(money.Text);
            if (money1 > 1000)
            {
                Random rd = new Random();
                int veroyatnost = rd.Next(1, 100);
                if (veroyatnost <= 99)
                {
                    MessageBox.Show("Не получилось победить в лотерее");
                    money1 -= 1000;
                    money.Text = money1.ToString();
                    Needs();
                }
                else
                {
                    money1 += 100000;
                    money.Text = money1.ToString();
                    Needs();
                }
            }
            else
            {
                MessageBox.Show("Недостаточно денег");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label1.Text = "Камиля Фортунбекова";
            label5.Text = "Паказатэлы";
            label6.Text = "Навэки";
            label7.Text = "Патребнасты";
            label22.Text = "Дэнь";
            label28.Text = "Врэмя";
            label16.Text = "Жрачкэ";
            label21.Text = "Напиткэ";
            label17.Text = "Навэк";
            label25.Text = "Исполнять";
            label15.Text = "Движухэ";
            label19.Text = "Манэта";
            label2.Text = "Лавэ";
            label3.Text = "Контакт патпищэке";
            label4.Text = "Тэлэграмэ патпищэке";
            label8.Text = "Кайфование";
            label9.Text = "Картинкэпост";
            label10.Text = "Тэлэга постэнг";
            label24.Text = "Тролэнг";
            label11.Text = "Хатет пакушат";
            label20.Text = "Вадычки хочэца";
            label13.Text = "Спание";
            label12.Text = "Абщэние с парэн";
            label14.Text = "Атливание";
            label18.Text = "Убрать наджаса";
            button5.Text = "Макарощкэ (70р)";
            button6.Text = "Марожэни (80р)";
            button17.Text = "Пэчэнкэ (100р)";
            button16.Text = "Чокапайкэ (200р)";
            button7.Text = "Пицэ (700р)";
            button21.Text = "Халяль еда (100000р)";
            button18.Text = "Жидкаст (0р)";
            button19.Text = "Минэралкэ (50р)";
            button20.Text = "Сладки вода (100р)";
            button33.Text = "Азэрчай (100000р)";
            button4.Text = "Отдых от суета";
            button10.Text = "Дэлат публикаций";
            button11.Text = "Дэлат тг пост";
            button25.Text = "Учить рускэ (1000р)";
            button26.Text = "Учить едаделать (1000р)";
            button28.Text = "Учицэ тролинг интернет";
            button27.Text = "Суета";
            button29.Text = "Вступить в клан Суетологи";
            button30.Text = "Вступить в клан Бродяги";
            button31.Text = "Вступить в клан Кайфарики";
            button1.Text = "Дэлат смс";
            button2.Text = "Не напрягаца";
            button3.Text = "Сделат дэла";
            button12.Text = "Водапалываний";
            button24.Text = "Вконтактэ движуха (500р)";
            button34.Text = "Тэлэга движухэ (500р)";
            button13.Text = "Просить у браткэ";
            button14.Text = "Платнэпост";
            button15.Text = "Патпищэк платит";
            button22.Text = "Выэхат на суета";
            button32.Text = "Зажат лохэв";
            button35.Text = "Ставкэ (1000р)";
            button23.Text = ("Радной эзык");
            button23.Enabled = false;
        }
    }
}
