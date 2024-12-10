using System.IO;
using Tyuiu.SeledkovNP.Sprint6.Task6.V22.Lib;
namespace Tyuiu.SeledkovNP.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()

        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void textBox1_TextChanged(object sender, EventArgs e)      // текст меню условия
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Clik_fiels_Click(object sender, EventArgs e)    // Найти нужный файл на ПК
        {
            // Открытие диалога выбора файла
            openFileDialog1.ShowDialog();

            // Получение пути к выбранному файлу
            openFilePath = openFileDialog1.FileName;

            // Чтение содержимого файла и отображение его в textBoxResult
            textBoxResult.Text = File.ReadAllText(openFilePath);

            // Обновление текста группового блока, добавляя имя файла
            groupBoxIn.Text = groupBoxOut.Text + " " + openFileDialog1.FileName;

            // Включение кнопки Clik_open_Click
            Clik_open.Enabled = true;

        }



        private void Clik_open_Click(object sender, EventArgs e)     // загрузит в приложения (открыт)
        {
            string str = "**";
            groupBoxOut.Text = ds.CollectTextFromFile( openFilePath);
        }

        private void Van_Click(object sender, EventArgs e)      // кномка с аватаркой
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }



        private void textVod_TextChanged(object sender, EventArgs e)      // ввод
        {

        }



        private void textVid_TextChanged(object sender, EventArgs e)     // вывод
        {

        }



        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)       // Текст меню с вводом   groupBoxIn
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)     // текст меню с выводом    groupBoxOut
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
