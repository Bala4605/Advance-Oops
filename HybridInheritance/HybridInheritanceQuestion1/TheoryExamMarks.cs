using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritanceQuestion1
{
    public class TheoryExamMarks : PersonalInfo
    {
        public int[] sem1={60,70,75,87,78,87};
        public int[] sem2={60,70,75,87,78,87};
        public int[] sem3={60,70,75,87,78,87};
        public int[] sem4={60,70,75,87,78,87};
        public TheoryExamMarks(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender) : base(name, fatherName, phone, mail, dob, gender)
        {
        }
    }
}