using System;
using System.Windows.Forms;

namespace PassGen
{
    public partial class formMain : Form
    {
        string digits = "0123456789";
        string letters = "qwertyuiopasdfghjklzxcvbnm";
        string symbols = "!@#$%^&*()";
        public formMain()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            int passCount = 0;
            int passLength = 0;

            try
            {
                passCount = Convert.ToInt32(textBoxCount.Text);
            }
            catch 
            { 
                MessageBox.Show("Значение поля \"Количество паролей\" обязательно к заполнению и должно быть целочисленным", "Неверное или пустое значение"); 
            }

            try
            {
                passLength = Convert.ToInt32(textBoxLength.Text);
            }
            catch 
            {
                MessageBox.Show("Значение поля \"Длинна паролей\" обязательно к заполнению и должно быть целочисленным", "Неверное или пустое значение");
            }

            string[] res = genPass(getList(digits, letters, symbols), passCount, passLength);
            textBoxResult.Text = "";
            foreach (string s in res)
            {
                textBoxResult.AppendText(s + "\r\n");
            }   
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private static char[] getList(string d, string l, string s)
        {
            string resultStrings = d + l + l.ToUpper() + s;
            char[] resultList = new char[resultStrings.Length];

            for (int index = 0; index < resultStrings.Length; index++) resultList[index] = resultStrings[index];

            return resultList;
        }

        private static string[] genPass(char[] list, int passCount, int passLength)
        {
            string result = "";
            string[] resultList = new string[passCount];
            Random rand = new Random();

            for (int i = 0; i < passCount; i++)
            {
                result = "";
                for (int j = 0; j < passLength; j++)
                {
                    int index = rand.Next(0, list.Length);
                    result += list[index];
                }

                resultList[i] = $"{result}\n";
            }

            return resultList;
        }

    }
}
