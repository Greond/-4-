using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обработчик_строк
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(text)|*.txt";
            saveFileDialog1.DefaultExt = ".txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                

                string[] mas = new string[listBox1.Items.Count];
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    mas[i] = listBox1.Items[i].ToString();
                }
                
                File.WriteAllLines(saveFileDialog1.FileName,mas);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Добавить_строку_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(TextBox1.Text);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Filename = openFileDialog1.FileName;

                
                string[] items = File.ReadAllText(Filename).Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);   
                foreach (string item in items )
                {
                    
                    if( item != " " || item != ".")
                    {
                        listBox1.Items.Add(item);
                    }
                    
                }
                
                int s = listBox1.Items.Count;
                if (listBox1.Items[s -1] == " ")
                { 
                listBox1.Items.RemoveAt(s -1);
                }
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Вставить_строку_Click(object sender, EventArgs e)
        {
            try
            { 
            listBox1.Items.Insert(listBox1.Items.IndexOf(listBox1.SelectedItem), TextBox1.Text);
            }
            catch
            {
                MessageBox.Show("Похеже вы не выбради строку перед которой хотите вставить");
            }
        }

        private void Изменить_строку_Click(object sender, EventArgs e)
        {
            try 
            {
               int s = listBox1.Items.IndexOf(listBox1.SelectedItem);
                listBox1.Items[s] = TextBox1.Text;
            }
            catch
            {
                MessageBox.Show("похоже вы не выбрали строку для изменения");
            }
        }

        private void Удалить_из_списка_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Очистить_список_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
