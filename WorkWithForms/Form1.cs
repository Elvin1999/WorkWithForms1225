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
    public partial class Form1 : Form
    {
        private EventHandler<EventArgs> _handler;
        public Form1()
        {
            InitializeComponent();


            _handler = new EventHandler<EventArgs>(SetTextEvent);

            //Send data FROM Parent To Child
            //1. By Constructor
            //2.By Property
            //3. By ShowDialog Override method

        }

        private void SetTextEvent(object sender, EventArgs e)
        {
            dataTxtb.Text = form2.Data;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            //form2.Show();


            //Form2 form2 = new Form2();
            //this.Hide();
            //if (form2.ShowDialog() == DialogResult.Cancel)
            //{
            //    this.Show();
            //}


            //Form2 form2 = new Form2(dataTxtb.Text);
            //this.Hide();
            //if (form2.ShowDialog() == DialogResult.Cancel)
            //{
            //    this.Show();
            //}

            List<string> list = new List<string>
            {
                "Elvin",
                "Tural",
                "Ismayil"
            };

            //form2.Data=dataTxtb.Text;
            form2.Handler = _handler;
            form2.List = list;
            form2.ShowDialog();
           
           


        }
        Form2 form2 = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();

            var user = new User();
            user.Name = nametxtb.Text;
            user.Surname = surnameTxtb.Text;
            user.Age = int.Parse(ageMaskTxtb.Text);

            if (form2.ShowDialog(user) == DialogResult.Cancel)
            {
                this.Show();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            dataTxtb.Text = form2.Data;
        }
    }
}
