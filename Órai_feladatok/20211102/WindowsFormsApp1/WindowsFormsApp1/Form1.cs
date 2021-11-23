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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PATH = Directory.GetCurrentDirectory();
            string[] konyvtarak = Directory.GetDirectories(PATH);
            foreach (var item in konyvtarak)
            {
                listBox1.Items.Add(item);
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string konyvtarnev = textBox1.Text;
            Directory.CreateDirectory(PATH+"\\"+konyvtarnev);
            listBox1.Items.Clear();
            string[] konyvtarak = Directory.GetDirectories(PATH);
            foreach (var item in konyvtarak)
            {
                listBox1.Items.Add(item);
            }
        }

        string PATH;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listBox1.SelectedItem.ToString();
            PATH = listBox1.SelectedItem.ToString();
            listBox1.Items.Clear();
            string[] konyvtarak = Directory.GetDirectories(PATH);
            foreach (var item in konyvtarak)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PATH = PATH.Remove(PATH.LastIndexOf('\\'),PATH.Length- PATH.LastIndexOf('\\'));       
            listBox1.Items.Clear();
            string[] konyvtarak = Directory.GetDirectories(PATH);
            label1.Text = PATH;
            foreach (var item in konyvtarak)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
