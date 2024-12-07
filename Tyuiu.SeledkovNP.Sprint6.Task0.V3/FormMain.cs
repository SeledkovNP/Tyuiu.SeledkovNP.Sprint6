using System.Windows.Forms.VisualStyles;
using Tyuiu.SeledkovNP.Sprint6.Task0.V3.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Tyuiu.SeledkovNP.Sprint6.Task0.V3
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string textBoxResult = Convert.ToString(ds.Calculate(Convert.ToInt32(textBox1.Text)));

                MessageBox.Show(textBoxResult);

            }
            catch
            {
                //  C:\Users\Vaennet
                //  setIconPixmap(QPixmap(": //C:\\Users\\Vaennet"));

                MessageBox.Show("¬ведены неверные данные", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
