using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassQuestion2
{
    public partial class StudentInfo
    {
          public StudentInfo( string name,Gender gender,DateTime dob,string mobile,int maths,int physics,int chemistry){
            StudentID="EID"+s_studentID++;
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
    }
}