using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class NewPerson : Form
    {
        private Register register;
        private int PersonCount;
        public NewPerson(Register form)
        {
            InitializeComponent();
            register = form;
            PersonCount = 1;
        }
        private bool CheckValidity(Control control)
        {




            return control.Text == "";
        }
        private void createPerson()
        {
            if (CheckValidity(txtName))
            {
                MessageBox.Show("please enter your name");
                return;
            }
            if (CheckValidity(txt_Age))
            {
                MessageBox.Show("please enter your age");
                return;
            }
            if (CheckValidity(txt_DOB))
            {
                MessageBox.Show("please enter your DOB");
                return;
            }
            Person person = new Person
            {
                name = txtName.Text,
                age = txt_Age.Text,
                DOB = txt_DOB.Text,
            };

            register.addPerson(person);
            PersonCount++;
        }



        public void LoadCustomer(Person person)
        {

            txtName.Text = person.name;
            txt_Age.Text = person.age;
            txt_DOB.Text = person.DOB;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            createPerson();
        }
    }
}
