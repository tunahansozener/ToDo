using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)              // adding part
        {
            string title = textBox1.Text;
            string description = textBox4.Text;
            string status = comboBox1.Text;
            string user = listBox1.Text;
            DateTime selectedDateTime = DateTime.Now;

            if(!string.IsNullOrEmpty(title)&& !string.IsNullOrEmpty(description) 
                && !string.IsNullOrEmpty(status) && !string.IsNullOrEmpty(user)&&!string.IsNullOrEmpty(selectedDateTime.ToString()))
            {
                ListViewItem newİtem = new ListViewItem(title, 0);          // liste ekleme
                
                newİtem.SubItems.Add(description);
                newİtem.SubItems.Add(status);
                newİtem.SubItems.Add(user);
                newİtem.SubItems.Add(selectedDateTime.ToString());

                listView1.Items.Add(newİtem);

            }
            else
            {
                MessageBox.Show("bilgileri girin");
            }
                
        }

        private void button5_Click(object sender, EventArgs e)          //remove
        {
            if (listView1.SelectedItems.Count > 0)
            {
               foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(selectedItem);
            }
             
            }        
                                     
        }

        private void button2_Click(object sender, EventArgs e)          //update
        {
            if (listView1.SelectedItems.Count > 0)
            {
              foreach(ListViewItem selected in listView1.SelectedItems) { 

                string currentStatus = selected.SubItems[3].Text;       // Mevcut durumu al ve güncelle
                selected.SubItems[2].Text = "Not Started";
                selected.SubItems[4].Text = DateTime.Now.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)         //update
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selected in listView1.SelectedItems) { 

                string currentStatus = selected.SubItems[3].Text;
                selected.SubItems[2].Text = "Started";
                selected.SubItems[4].Text = DateTime.Now.ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)         //update
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selected in listView1.SelectedItems) { 

                string currentStatus = selected.SubItems[3].Text;
                selected.SubItems[2].Text = "Completed";
                selected.SubItems[4].Text = DateTime.Now.ToString();
                }
            }
        }
    }
}
