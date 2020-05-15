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
    public partial class Information_Patient : Form
    {
        public static List<Patient> listPatient { get; set; }
        public Patient patientSelected { get; set; }
        public Information_Patient()
        {
            InitializeComponent();
            Information_Patient.listPatient = new List<Patient>();
            CreateDataPatient();
            InitListView();
            LoadPatient();
            

        }
        public void InitListView()
        {
            lvPatient.Columns.Add("No.");
            lvPatient.Columns.Add("ID");
            lvPatient.Columns.Add("Name");
            lvPatient.Columns.Add("Address");
            lvPatient.Columns.Add("Phone");
            lvPatient.Columns.Add("Gender");
            lvPatient.Columns.Add("Status");
            lvPatient.AutoArrange = true;
            lvPatient.GridLines = true;
            lvPatient.FullRowSelect = true;

            lvPatient.View = View.Details;
        }
        public void CreateDataPatient()
        {
            Patient p1 = new Patient("001", "Patient 1", "112 Nguyen Trai", "012345678", "Male", "Sick");
            Patient p2 = new Patient("002", "Patient 2", "100 Nguyen Du", "091293845", "Female", "Headache");
            listPatient.Add(p1);
            listPatient.Add(p2);
        }
        public void LoadPatient()
        {
            lvPatient.Items.Clear();

            Patient temp;
            for(int i=0;i<Information_Patient.listPatient.Count;i++)
            {
                ListViewItem subItem = new ListViewItem();
                temp = (Patient)Information_Patient.listPatient[i];
                subItem.Text = i.ToString();
                subItem.SubItems.Add(temp.ID.ToString());
                subItem.SubItems.Add(temp.Name.ToString());
                subItem.SubItems.Add(temp.Address.ToString());
                subItem.SubItems.Add(temp.Phone.ToString());
                subItem.SubItems.Add(temp.Gender.ToString());
                subItem.SubItems.Add(temp.Status.ToString());

                lvPatient.Items.Add(subItem);
                
            }
        }

        

        private void lvPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateDataPatient();
            ListView lsv = sender as ListView;
            if(lsv.SelectedItems.Count==1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                int index1 = Convert.ToInt32(item.Text);
                patientSelected = (Patient)Information_Patient.listPatient[index1];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addPatient formAddPatient = new addPatient("Add");
            formAddPatient.ShowDialog();
            if (addPatient.patient != null)
            {
                Patient p = new Patient(addPatient.patient);

                if (string.IsNullOrEmpty(p.ID.ToString()) || string.IsNullOrEmpty(p.Name.ToString()) || string.IsNullOrEmpty(p.Address.ToString()) || string.IsNullOrEmpty(p.Phone.ToString()) || string.IsNullOrEmpty(p.Gender.ToString()) || string.IsNullOrEmpty(p.Status.ToString()))
                {

                }
                else
                {
                    listPatient.Add(p);
                    MessageBox.Show("Add Successful");
                    LoadPatient();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            addPatient formUpdate = new addPatient("Update");
            int index = Information_Patient.listPatient.IndexOf(this.patientSelected);
            addPatient.patient.ID = patientSelected.ID;
            addPatient.patient.Name = patientSelected.Name;
            addPatient.patient.Address = patientSelected.Address;
            addPatient.patient.Phone = patientSelected.Phone;
            addPatient.patient.Gender = patientSelected.Gender;
            addPatient.patient.Status = patientSelected.Status;
            formUpdate.ShowDialog();

            Patient p = (Patient)listPatient[index];
            p.ID = addPatient.patient.ID;
            p.Name = addPatient.patient.Name;
            p.Address = addPatient.patient.Address;
            p.Phone = addPatient.patient.Phone;
            p.Gender = addPatient.patient.Gender;
            p.Status = addPatient.patient.Status;
            addPatient.patient = null;
            LoadPatient();
            MessageBox.Show("Update Successful");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Information_Patient.listPatient.Remove(this.patientSelected);
            LoadPatient();
            listPatient.Clear();
            MessageBox.Show("Remove Successful");
        }       
    }
}
