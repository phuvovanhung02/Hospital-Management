using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotAssistant.Model
{
    public partial class addPatient : Form
    {
        public static Patient patient = new Patient();
        public string Action { get; set; }
        public addPatient(string Action)
        {
            InitializeComponent();
            this.Action = Action;
        }
        public bool CheckAvaileble()
        {
            string name = txtName.Text.ToString();
            string address = txtAddress.Text.ToString();
            string phone = txtPhone.Text.ToString();
            string gender = txtGender.Text.ToString();
            string status = txtStatus.Text.ToString();
            if(string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is empty");
                return false;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone is empty");
                return false;
            }
            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Gender is empty");
                return false;
            }
            if (string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Status is empty");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isCheck = CheckAvaileble();
            if(isCheck==true)
            {
                patient.ID = txtID.Text.ToString();
                patient.Name = txtName.Text.ToString();
                patient.Address = txtAddress.Text.ToString();
                patient.Phone = txtPhone.Text.ToString();
                patient.Gender = txtGender.Text.ToString();
                patient.Status = txtStatus.Text.ToString();
                this.Close();
               
            }
        }
    }
}
