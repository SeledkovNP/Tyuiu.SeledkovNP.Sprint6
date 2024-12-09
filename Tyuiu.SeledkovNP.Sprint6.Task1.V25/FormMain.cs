using Tyuiu.SeledkovNP.Sprint6.Task1.V25.Lib;
namespace Tyuiu.SeledkovNP.Sprint6.Task1.V25
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();




        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            // ��� ��� ��������� �������
        }



        private void button_res_Click(object sender, EventArgs e)
        {
            try
              {
                // ��������� ������
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);

                //������������ ������
                string line;
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                //������ ������
                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0, x = -5; i < len-1; i++, x++)
                {
                    line = String.Format("|{0,5:d}     |   {1, 5:f2}  |", startValue, valueArray[i]);
                    textBoxResult.AppendText(line + Environment.NewLine);
                    startValue++;
                }
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
              }
            catch
            {
                MessageBox.Show("�������� ������", "������");
            }
        }
        private void button_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������� �������� ������� ������ ������-24-1 �������� �. �.", "�������");
        }
    }
}
