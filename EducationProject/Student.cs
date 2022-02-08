using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject {

    public class Student {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SAT { get; set; }
        public decimal GPA { get; set; }
        public Major Major { get; set; } // Instance of the major class

        // Method
        public Major GetMajorByDescription(string description,
            List<Major> majors) {
            foreach(Major major in majors) {
                if(description == major.Description) {
                    return major;
                }
            }
            return null;
        }

        // Constructor to put in FirstName, Last Name, SAT & GPA
        public Student(string firstname, string lastname,
            int sat, decimal gpa) {
            FirstName = firstname;
            LastName = lastname;
            SAT = sat;
            GPA = gpa;
        }
    }
}
