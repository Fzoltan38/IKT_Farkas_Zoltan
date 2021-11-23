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

namespace GUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filename = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                listBox1.Items.Add(a+b);
            }
            catch 
            {
                MessageBox.Show("Nem jó értéket adtál meg!");
                
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (filename != "")
                {

                    StreamWriter sw = new StreamWriter(filename);

                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item);
                    }

                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("Még nincs fájl kiválasztva!");
            }        
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count != 0) {
                    SaveFileDialog s = new SaveFileDialog();
                    s.Filter = "*.txt; *.csv | *.txt; *.csv";
                    s.ShowDialog();
                    filename = s.FileName;
                }

                StreamWriter sw = new StreamWriter(filename);

                foreach (var item in listBox1.Items)
                {              
                    sw.WriteLine(item);
                    
                }

                sw.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                OpenFileDialog of = new OpenFileDialog();
                of.Filter="*.txt; *.csv | *.txt; *.csv";
                of.ShowDialog();
                filename = of.FileName;
                listBox1.Items.Clear();

                foreach (var item in File.ReadAllLines(filename))
                {
                    listBox1.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("Még nincs fájl kiválasztva!");
            }
        }
    }
}
