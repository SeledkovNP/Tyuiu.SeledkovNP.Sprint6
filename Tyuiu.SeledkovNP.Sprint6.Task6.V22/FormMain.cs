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

        private void textBox1_TextChanged(object sender, EventArgs e)      // ����� ���� �������
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Clik_fiels_Click(object sender, EventArgs e)    // ����� ������ ���� �� ��
        {
            // �������� ������� ������ �����
            openFileDialog1.ShowDialog();

            // ��������� ���� � ���������� �����
            openFilePath = openFileDialog1.FileName;

            // ������ ����������� ����� � ����������� ��� � textBoxResult
            textBoxResult.Text = File.ReadAllText(openFilePath);

            // ���������� ������ ���������� �����, �������� ��� �����
            groupBoxIn.Text = groupBoxOut.Text + " " + openFileDialog1.FileName;

            // ��������� ������ Clik_open_Click
            Clik_open.Enabled = true;

        }



        private void Clik_open_Click(object sender, EventArgs e)     // �������� � ���������� (������)
        {
            string str = "**";
            groupBoxOut.Text = ds.CollectTextFromFile( openFilePath);
        }

        private void Van_Click(object sender, EventArgs e)      // ������ � ���������
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }



        private void textVod_TextChanged(object sender, EventArgs e)      // ����
        {

        }



        private void textVid_TextChanged(object sender, EventArgs e)     // �����
        {

        }



        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)       // ����� ���� � ������   groupBoxIn
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)     // ����� ���� � �������    groupBoxOut
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
