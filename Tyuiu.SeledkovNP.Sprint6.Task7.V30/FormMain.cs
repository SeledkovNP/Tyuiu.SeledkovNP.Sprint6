using System.IO;
using Tyuiu.SeledkovNP.Sprint6.Task7.V30.Lib;
namespace Tyuiu.SeledkovNP.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()

        {
            InitializeComponent();
            openFileDialogTask.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            saveFileDialogMatrix.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
        }

        static int rows;
        static int cols;
        static string openFilePath;
        DataService ds = new DataService();
        
        public static int[,] LoadFromFileData(string filePath)
        {
            //��������� ��� �� ����a
            string fileData = File.ReadAllText(filePath);

            // ���������� �� ������
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //���������� ���-�� ����� � ��������
            rows = lines.Length;
            cols = lines[0].Split(';').Length;

            //�������� ������ ������
            int[,] arraysValues = new int[rows, cols];

            //��������� ������
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    arraysValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arraysValues;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)      // ����� ���� �������
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Clik_fiels_Click(object sender, EventArgs e)    // ����� ������ ���� �� ��  //buttonLoadFile
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arraysValues = new int[rows, cols];

            arraysValues = LoadFromFileData(openFilePath);

            dataGridViewIn.ColumnCount = cols;
            dataGridViewIn.RowCount = rows;
            dataGridViewOut.ColumnCount = cols;
            dataGridViewOut.RowCount = rows;

            //������ ������ ������� dataGridViewIn
            for (int i = 0; i < cols; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }



            // ��������� ������ � dataGridViewIn
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < cols; i++)
                {
                    dataGridViewIn.Rows[j].Cells[i].Value = arraysValues[j, i];
                }
            }

            arraysValues = ds.GetMatrix(LoadFromFileData(openFilePath));
            buttonDone.Enabled = true;

        }



        private void Clik_open_Click(object sender, EventArgs e)     // �������  //buttonDone
        {
            int[,] arraysValues = new int[rows, cols];
            arraysValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOut.Rows[i].Cells[j].Value = arraysValues[i, j];
                }
            }
            buttonSave.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e) //����������     buttonSave
        {
            saveFileDialogMatrix.FileName = @"OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.RowCount;//���-�� ����� �����
            int cols = dataGridViewOut.ColumnCount; // ���-�� ��������

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j != cols - 1)
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }


        }
    }
}
