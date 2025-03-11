using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Final_Project
{
    public partial class NewPersonForm : Form
    {
        private Form _mainForm;
        public NewPersonForm(Form form)
        {
            InitializeComponent();
            _mainForm = form;
        }
        private bool CheckValidity(Control control)
        {
           



            return control.Text == "";
        }
        private void createPerson()
        {
            // validtaion
            if (CheckValidity(txtName))
            {

                MessageBox.Show("please enter your name");
                return;
              
            }
            if (CheckValidity(txtAge))
            {
                MessageBox.Show("please enter your age");
                return;
            }
            if (CheckValidity(txtDOB))
            {
                MessageBox.Show("please enter your DOB");
                return;
            }
            Person person = new Person
            {
                name = txtName.Text,
                age = txtAge.Text,
                DOB = txtDOB.Text,
            };
        }
        public void LoadCustomer(Person person)
        {
          
            txtName.Text = person.name;
           txtAge.Text = person.age;
            txtDOB.Text = person.DOB;
        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
