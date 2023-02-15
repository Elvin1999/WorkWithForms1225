using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithForms
{
    public partial class Form2 : Form
    {
        public EventHandler<EventArgs> Handler { get; set; }
        private string data;
        public string Data
        {
            get=>data;
            set
            {
                label1.Text = value;
                data = value;
            }
        }

        private List<string> list;

        public List<string> List
        {
            get { return list; }
            set { list = value; SetLabel(value); }
        }

        private void SetLabel(List<string> list)
        {
            foreach (var item in list)
            {
                label1.Text += item + "\n";
            }
        }

        public Form2(string data)
        {
            InitializeComponent();
            label1.Text = data;
        }
        public Form2()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(User user)
        {
            label1.Text = $"Name : {user.Name}  Surname : {user.Surname} Age : {user.Age}";
            return ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Handler.Invoke(sender,e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Data = textBox1.Text;
            Handler.Invoke(sender, e);
        }
    }
}
