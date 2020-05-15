using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssistant.Model
{
    public class Doctor
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; } 
        public List<Patient> listPatient { get; set; }


        public Doctor()
        {
            this.id = "";
            this.name = "";
            this.phone = "";
            this.address = "";
            this.listPatient = new List<Patient>();

            // Cách 1: 1-n
            // 1 doctor có thể chữa n patient
            // 1 patient được chữa bởi 1 doctor
            // doctor có list patient 
            // patient có 1 property Doctor

            // Cách 2: n-1
            // 1 doctor chữa 1 patient
            // 1 patient được chữa bởi nhiều doctor
            // doctor có 1 property Patient
            // patient sẽ có list Doctor 

            // Cách 3: n-n
            // 1 doctor có thể chữa n patient
            // 1 patient có thể được chữa bởi n doctor
            // 1 doctor có 1 list patient 
            // 1 patient có 1 list doctor
            
            // Cách 4: 1-1
            // 1 doctor có thể chữa 1 patient
            // 1 patient có thể được chữa bởi 1 doctor
            // 1 doctor có 1 patient 
            // 1 patient có 1 doctor  
        }
        public Doctor(string id, string name, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.address = address;
            this.listPatient = new List<Patient>();
        }

        public Doctor(Doctor d)
        {
            // vì từng property trong doctor là kiểu value type
            // nên là sẽ trả ra giá trị
            // nếu là reference type thì trả ra địa chỉ 
            this.id = d.id;
            this.name = d.name;
            this.phone = d.phone;
            this.address = d.address;
            this.listPatient = new List<Patient>();
        }



    }
}
