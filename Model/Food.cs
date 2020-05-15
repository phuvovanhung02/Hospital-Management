using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotAssistant.Model
{
    public class Food
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Kind { get; set; }
        public string DOM { get; set; }
        public string ED { get; set; }
        public Food()
        {
            this.ID = "";
            this.Name = "";
            this.Unit = "";
            this.Kind = "";
            this.DOM = "";
            this.ED = "";
        }
        public Food(string ID,string Name,string Unit,string Kind,string DOM,string ED)
        {
            this.ID = ID;
            this.Name = Name;
            this.Unit = Unit;
            this.Kind = Kind;
            this.DOM = DOM;
            this.ED = ED;
        }

        public Food(Food f)
        {
            this.ID = f.ID;
            this.Name = f.Name;
            this.Unit = f.Unit;
            this.Kind = f.Kind;
            this.DOM = f.DOM;
            this.ED = f.ED;
        }
    }
}
