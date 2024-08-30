using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string slength = textBox1.Text;
            long length = Convert.ToInt64(slength);
            Debug.Print($"slength = {slength}");
            Debug.WriteLine($"length = {length}");

            string[] lowcaselet = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] upcaselet = new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] num = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] sym = new[] { "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+", "~", "¹", ";", "?", ":", ">", "<", "/", "|" };
            Random rnd = new();
            Int64 id;
            long idarlet;
            long idarnum;
            long idarsym;
            string password = "";
            for (int i = 0; i != length; i++)
            {
                id = rnd.NextInt64(1, 5);
                Debug.WriteLine($"id = {id}");
                idarlet = rnd.NextInt64(0, lowcaselet.Length);
                Debug.WriteLine($"idarlet = {idarlet}");
                idarnum = rnd.NextInt64(0, num.Length);
                Debug.WriteLine($"idarnum = {idarnum}");
                idarsym = rnd.NextInt64(0, sym.Length);
                Debug.WriteLine($"idarsym = {idarsym}");

                if (id == 1)
                {
                    password = lowcaselet[idarlet];
                }
                if (id == 2)
                {
                    password = upcaselet[idarlet];
                }
                if (id == 3)
                {
                    password = num[idarnum];
                }
                if (id == 4)
                {
                    password = sym[idarsym];
                }
                Debug.WriteLine($"i = {i}");
                Debug.WriteLine($"password = {password}");
                textBox2.AppendText(password);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}     