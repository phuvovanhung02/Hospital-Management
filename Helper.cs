using RobotAssistant.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssistant
{
    public class Helper
    { 
        public static bool IsNumeric(object Expression)
        {
            double retNum; 
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public static string LastIdDoctor(List<Doctor> list)
        {
            string id = "";
            // 3 doctor thì last index 0, 1, 2 => Length - 1 = 3 - 1 = 2
            Doctor temp = (Doctor)list[list.Count() - 1];
            // lấy id cuối cùng trong bảng Doctor
            int lastId = Convert.ToInt32(temp.id);
            // id = 10
            // => 0010 thêm 2 số 0
            // 4 - id.ToString().Length 5=> 1 ; 14 => 2; 154 => 3  
            for (int i=0;i < 4-lastId.ToString().Length; i++)
            {
                id += "0";
            }
            return id + (lastId+1).ToString();
        }
       public static string LastIdPatient(List<Patient>list1)
        {
            string id1 = "";
            Patient temp1 = (Patient)list1[list1.Count() - 1];
            int lastid1 = Convert.ToInt32(temp1.ID);
            for(int i=0;i<4-lastid1.ToString().Length;i++)
            {
                id1 += "0";
            }
            return id1 + (lastid1 + 1).ToString();
        }
       public static string LastIdFood(List<Food>list2)
        {
            string id2 = "";
            Food temp2 = (Food)list2[list2.Count() - 1];
            int lastid2 = Convert.ToInt32(temp2.ID);
            for(int i=0;i<4-lastid2.ToString().Length;i++)
            {
                id2 += "0";
            }
            return id2 + (lastid2 + 1).ToString();
        }

        
    }
}
