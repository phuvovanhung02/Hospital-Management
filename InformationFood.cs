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
    public partial class Form3 : Form
    {
        public static List<Food> listFood { get; set; }
        public Food foodSelected { get; set; }

        public Form3()
        {
            InitializeComponent();
            Form3.listFood = new List<Food>();
            CreateDataFood();
            InitListView1();
            LoadFood1();
        }

        public void InitListView1()
        {
            lvFood.Columns.Add("No.");
            lvFood.Columns.Add("ID");
            lvFood.Columns.Add("Name");
            lvFood.Columns.Add("Unit");
            lvFood.Columns.Add("Kind");
            lvFood.Columns.Add("Date Of Manufacture");
            lvFood.Columns.Add("Expiration Date");
            lvFood.AutoArrange = true;
            lvFood.GridLines = true;
            lvFood.FullRowSelect = true;


            lvFood.View = View.Details;
        }
        public void CreateDataFood()
        {
            Food f1 = new Food("001", "Rice", "100 Box", "Main Food", "14/5/2020", "15/5/2020");
            Food f2 = new Food("002", "Noodles", "100 Box", "Main Food", "15/6/2020", "16/6/2020");
            listFood.Add(f1);
            listFood.Add(f2);
        }
        public void LoadFood1()
        {
            lvFood.Items.Clear();

            Food temp3;
            for(int i=0;i<Form3.listFood.Count;i++)
            {
                ListViewItem subitem3 = new ListViewItem();
                temp3 = (Food)Form3.listFood[i];
                subitem3.Text = i.ToString();
                subitem3.SubItems.Add(temp3.ID.ToString());
                subitem3.SubItems.Add(temp3.Name.ToString());
                subitem3.SubItems.Add(temp3.Unit.ToString());
                subitem3.SubItems.Add(temp3.Kind.ToString());
                subitem3.SubItems.Add(temp3.DOM.ToString());
                subitem3.SubItems.Add(temp3.ED.ToString());

                lvFood.Items.Add(subitem3);
            }
        }
        private void lvFood_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListView lsvf = sender as ListView;
            if (lsvf.SelectedItems.Count == 1)
            {
                ListViewItem item = lsvf.SelectedItems[0];
                int index3 = Convert.ToInt32(item.Text);
                foodSelected = (Food)Form3.listFood[index3];
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addFood formAddFood = new addFood("Add");
            formAddFood.ShowDialog();
            if(addFood.food!=null)
            {
                Food f = new Food(addFood.food);

                if (string.IsNullOrEmpty(f.ID.ToString()) || string.IsNullOrEmpty(f.Name.ToString()) || string.IsNullOrEmpty(f.Unit.ToString()) || string.IsNullOrEmpty(f.Kind.ToString()) || string.IsNullOrEmpty(f.DOM.ToString()) || string.IsNullOrEmpty(f.ED.ToString()))
                {

                }
                else
                {
                    listFood.Add(f);
                    MessageBox.Show("Add Successful");
                    LoadFood1();
                }
            }
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addFood formUpdate3 = new addFood("Update");
            int index3 = Form3.listFood.IndexOf(this.foodSelected);
            addFood.food.ID = foodSelected.ID;
            addFood.food.Name = foodSelected.Name;
            addFood.food.Unit = foodSelected.Unit;
            addFood.food.Kind = foodSelected.Kind;
            addFood.food.DOM = foodSelected.DOM;
            addFood.food.ED = foodSelected.ED;
            formUpdate3.ShowDialog();

            Food f = (Food)listFood[index3];
            f.ID = addFood.food.ID;
            f.Name = addFood.food.Name;
            f.Unit = addFood.food.Unit;
            f.Kind = addFood.food.Kind;
            f.DOM = addFood.food.DOM;
            f.ED = addFood.food.ED;
            addFood.food = null;
            LoadFood1();
            MessageBox.Show("Update Successful");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Form3.listFood.Remove(this.foodSelected);
            LoadFood1();
            MessageBox.Show("Remove Successful");
        }

        
    }
}
