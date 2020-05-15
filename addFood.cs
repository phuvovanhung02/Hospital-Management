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
    public partial class addFood : Form
    {
        public static Food food = new Food();
        public string action3 { get; set; }
        public addFood(string action3)
        {
            InitializeComponent();
            this.action3 = action3;
        }

        private void AddFood_Load(object sender, EventArgs e)
        {
            if(this.action3=="Add")
            {
                txtID.Text = Helper.LastIdFood(Form3.listFood);
                btnAddPateint.Text = "Add";
            }
            else if(this.action3=="Update")
            {
                txtName.Text = food.Name.ToString();
                txtUnit.Text = food.Unit.ToString();
                txtKind.Text = food.Unit.ToString();
                txtDOM.Text = food.DOM.ToString();
                txtED.Text = food.ED.ToString();
                btnAddPateint.Text = "Update";
                
            }
            txtID.Enabled = false;
        }
        public bool CheckAvailible3()
        {
            string name = txtName.Text.ToString();
            string unit = txtUnit.Text.ToString();
            string kind = txtKind.Text.ToString();
            string dom = txtDOM.Text.ToString();
            string ed = txtED.Text.ToString();

            if(string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Name is empty");
                return false;
            }
            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Unit is empty");
                return false;
            }
            if (string.IsNullOrEmpty(kind))
            {
                MessageBox.Show("Kind is empty");
                return false;
            }
            if (string.IsNullOrEmpty(dom))
            {
                MessageBox.Show("Date of Manufacture is empty");
                return false;
            }
            if (string.IsNullOrEmpty(ed))
            {
                MessageBox.Show("Expiration Date is empty");
                return false;
            }
            return true;
        }     
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            bool ischeck = CheckAvailible3();
            if (ischeck == true)
            {
                food.Name = txtName.Text.ToString();
                food.Unit = txtUnit.Text.ToString();
                food.Kind = txtKind.Text.ToString();
                food.DOM = txtDOM.Text.ToString();
                food.ED = txtED.Text.ToString();

                this.Close();
                food.ID = txtID.Text.ToString();
            }
        }
    }
}
