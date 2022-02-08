using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject {

    public class Major {
        // Properties
        private static int NextId { get; set; } = 1;
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSAT {get; set;}

        // Constructor to inialize the Description & MinSAT
        public Major(string description, int minSAT) {
            Id = NextId;
            NextId++; // Another way to do in 1 step is to do Id = NextID++;
            Description = description;
            MinSAT = minSAT;
        }
    }
}
