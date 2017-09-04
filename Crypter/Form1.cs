using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
                Encrypt cryptor = new Encrypt();
                String encryptedstring = cryptor.crypt(textBox2.Text,textBox1.Text);
                textBox3.Text = encryptedstring;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Encrypt cryptor = new Encrypt();
            String decryptedstring = cryptor.decrypt(textBox2.Text, textBox1.Text);
            textBox3.Text = decryptedstring;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Random random = new Random();
            Random uppercase = new Random();
            StringBuilder randomkey = new StringBuilder();
            for(int i=0;i<32;i++)
            {
                int randomuppercase = random.Next(0,2);
                int randomnumber = random.Next(0, alphabet.Length);
                String current = alphabet[randomnumber];
                if(randomuppercase==1 && randomnumber<=26)
                {
                    current = current.ToUpper();
                }
                randomkey.Append(current);
            }
            textBox2.Text = randomkey.ToString();
    }
    }
}
