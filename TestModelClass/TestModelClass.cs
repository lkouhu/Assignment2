using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace TestModelClass
{
    public class TestModelClass
    {
        //Define the properties
        //customerNumber
        [DisplayName("First Name")]
        public string First_name { get; set; }

        [DisplayName("Last Name")]
        public string Last_name { get; set; }

        [DisplayName("Gender")]
        public enum Gender { get; set; }

        //Employee Information Properties
        [DisplayName("Employee ID")]
        public int Emp_no { get; set; }

        [DisplayName("Hire Date")]
        public string Hire_date { get; set; }

        [DisplayName("Gender")]
        public string Gender { get; set; }
    }
}
