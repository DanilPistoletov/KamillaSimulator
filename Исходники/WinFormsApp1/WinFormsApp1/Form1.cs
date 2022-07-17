using System.Diagnostics;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo linkopen = new ProcessStartInfo
            {
                FileName = "https://vk.com/public214251364",
                UseShellExecute = true
            };
            Process.Start(linkopen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game game1 = new game();
            game1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 1.1:" + Environment.NewLine + "Исправлен баг с финальным окном" + Environment.NewLine + "Тексту добавлена обводка" + Environment.NewLine + "Финальное исправление багов");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}