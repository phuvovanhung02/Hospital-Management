using RobotAssistant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotAssistant
{
    public partial class AddDoctor : Form
    {
        public static Doctor doctor = new Doctor();
        public string action { get; set; }
        public AddDoctor(string action)
        {
            InitializeComponent();
            this.action = action;
        } 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // b1: kiểm tra form hợp lệ
            bool isChecked = CheckAvailible();
            // b2: tạo Doctor truyền qua Form 1
            if (isChecked == true)
            {
                //CreateDoctor();
                doctor.id = txtID.Text.ToString();
                doctor.name = txtName.Text.ToString();
                doctor.phone = txtPhone.Text.ToString();
                doctor.address = txtAddress.Text.ToString();
                MessageBox.Show(doctor.name);
                this.Close();
            }
        }

        public bool CheckAvailible()
        {
            string name = txtName.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string address = txtAddress.Text.ToString();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone is empty");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is empty");
                return false;
            }

            return true;
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        { 
            if(this.action == "add")
            { 
                txtID.Text = Helper.LastIdDoctor(Form1.listDoctor); 
                btnAdd.Text = "Add";
            }
            else if(this.action == "update")
            {
                txtID.Text = doctor.id.ToString();
                txtAddress.Text = doctor.address.ToString();
                txtName.Text = AddDoctor.doctor.name;
                txtPhone.Text = AddDoctor.doctor.phone;
                btnAdd.Text = "Update";
            }
            txtID.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
