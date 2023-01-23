using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace PassGen
{
    public partial class formMain : Form
    {
        static string digits = "0123456789";
        static string letters = "qwertyuiopasdfghjklzxcvbnm";
        static string lettersUpper = letters.ToUpper();
        static string symbols = "!@#$%^&*()";
        
        static Random rand = new Random();

        public formMain()
        {
            InitializeComponent();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            int passCount = 0;
            int passLength = 0;

            int[] result = passCure(passCount, passLength);

            textBoxResult.AppendText(passList(result[0], result[1]));
        }

        private int[] passCure(int passCount, int passLength)
        {

            int[] passRes;

            try
            {
                passCount = Convert.ToInt32(textBoxCount.Text);
            }
            catch
            {
                MessageBox.Show("Значение поля \"Количество паролей\" обязательно к заполнению и должно быть целочисленным", 
                                "Неверное или пустое значение");
            }

            try
            {
                passLength = Convert.ToInt32(textBoxLength.Text);
            }
            catch
            {
                MessageBox.Show("Значение поля \"Длинна паролей\" обязательно к заполнению и должно быть целочисленным", 
                                "Неверное или пустое значение");
            }
            passRes = new int[] { passCount, passLength };

            return passRes;
        }

        private string passList(int passCount, int passLength)
        {

            char[] resultPass = getList(digits, letters, lettersUpper, symbols);
            string[] res = curePass(resultPass, passCount, passLength);
            string pass = "";
            
            textBoxResult.Text = "";

            foreach (string s in res)
            {
                pass += (s + "\r\n");
            }

            return pass;
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            string filename = saveFileDialog.FileName;
            File.WriteAllText(filename, textBoxResult.Text);   
        }

        private static char[] getList(string d, string l, string L, string s)
        {
            string resultStrings = d + l + L + s;
            char[] resultList = new char[resultStrings.Length];

            for (int index = 0; index < resultStrings.Length; index++) resultList[index] = resultStrings[index];

            return resultList;
        }

        private static string[] curePass(char[] list, int passCount, int passLength)
        {

            string[] resultList = new string[passCount];

            for (int i = 0; i < passCount; i++)
            {
                resultList[i] = generationPass(list, passLength);
            }

            return resultList;
        }

        private static string generationPass(char[] list, int passLength)
        {
            string resString;
            string result = "";
            bool res = false;

            while (res != true)
            {
                resString = "";
                result = "";
                for (int j = 0; j < passLength; j++)
                {
                    int index = rand.Next(0, list.Length);
                    resString += list[index];
                }
                if (checkPass(resString)) 
                { 
                    res = true;
                    result = resString; 
                }  
            }

            return result;
        }

        private static bool checkPass(string resultPass)
        {
            bool checkD = false;
            bool checkl = false;
            bool checkL = false;
            bool checkS = false;
            bool check = false;


            foreach (char d in digits) { if (resultPass.Contains(d)) { checkD = true; } }
            foreach (char l in letters) { if (resultPass.Contains(l)) { checkl = true; }  }
            foreach (char L in lettersUpper) { if (resultPass.Contains(L)) { checkL = true; }  }
            foreach (char s in symbols) { if (resultPass.Contains(s)) { checkS = true; } }

            if (checkD && checkl && checkL && checkS) { check = true; }

            return check;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
