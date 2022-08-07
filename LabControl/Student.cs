using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace LabControl
{
    public class Lab
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public int LabId { get; set; }
        public Lab() { }
    }
    public class Student
    {
        public string name { get; set; }
        public string group { get; set; }
        public string subgroup { get; set; }
        public int id { get; set; }
        public  BindingList<Lab> labs { get; set; }
        public int lab_count { get; set; }
    }
}
