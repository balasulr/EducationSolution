using System;
using System.Collections.Generic;

namespace EducationProject {
    class Program {
        static void Main(string[] args) {
            // Creates a Collection called majors which is plural
            List<Major> majors = new List<Major>(); // Major is the Class name
            // Adding some majors to the Collection
            Major business = new Major("Business", 1000);
            majors.Add(business);
            Major nursing = new Major("Nursing", 1200);
            majors.Add(nursing);
            Major theater = new Major("Theater", 1100);
            majors.Add(theater);

            // Displaying what is in the collection in a foreach loop
            foreach (Major major in majors) {
                Console.WriteLine($"{major.Id}|{major.Description}|{major.MinSAT}");
            }

            // Creating another Collection called Student
            List<Student> students = new List<Student>();
            Student alex = new Student("Alex", "Alex", 1350, 3.4m);
            alex.Major = alex.GetMajorByDescription("Business", majors);
            Student drew = new Student("Drew", "Drew", 1350, 3.45m);
            drew.Major = drew.GetMajorByDescription("Business", majors);
            Student steven = new Student("Steven", "Steven", 1350, 3.4m);

            // Adding Students
            students.Add(alex);
            students.Add(drew);
            students.Add(steven);

            foreach(Student student in students) {
                // Ternery statement
                string MajorDescription = student.Major == null
                    ? "Undecided" : student.Major.Description;
                // Console.WriteLine Statement showing First & Last Name & Major
                Console.WriteLine($"{student.FirstName} {student.LastName} " +
                    $"Major: {MajorDescription}");
            }
        }
    }
}
