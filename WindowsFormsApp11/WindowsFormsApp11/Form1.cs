using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richTextBox2.Text = File.ReadAllText("UserList.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            System.IO.StreamReader file =
    new System.IO.StreamReader("UserList.txt");
            while ((line = file.ReadLine()) != null)
            {
                webBrowser1.Navigate(new Uri("https://scratch.mit.edu/users/" + line));
                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
                if (webBrowser1.DocumentText.Contains("We couldn't find the page you're looking for."))
                {
                    File.AppendAllText("UserFoundList.txt",
                                       line + Environment.NewLine);
                    richTextBox1.Text = File.ReadAllText("UserFoundList.txt");
                }
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = File.ReadAllText("UserList.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FileStream fs = File.Create("UserFoundList.txt"))
            {

            }
            richTextBox1.Text = File.ReadAllText("UserFoundList.txt");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.WriteAllText("UserList.txt", richTextBox2.Text);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            File.WriteAllText("UserList.txt", richTextBox2.Text);
        }
    }
}
