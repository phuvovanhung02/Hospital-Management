using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssistant.Model
{
    public class Patient
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public Patient()
        {
            this.ID = "";
            this.Name = "";
            this.Address = "";
            this.Phone = "";
            this.Gender = "";
            this.Status = "";
        }
        public Patient(string ID,string Name,string Address,string Phone,string Gender,string Status)
        {
            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Gender = Gender;
            this.Status = Status;
        }
        public Patient(Patient p)
        {
            this.ID = p.ID;
            this.Name = p.Name;
            this.Address = p.Address;
            this.Phone = p.Phone;
            this.Gender = p.Gender;
            this.Status = p.Status;
        }
    }
}
