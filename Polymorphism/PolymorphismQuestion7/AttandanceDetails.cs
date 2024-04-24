namespace PolymorphismQuestion7
{
    public class AttendanceDetails
    {
        public int TotalWorkingDays { get; set; }
        public int NoOfLeaves { get; set; }
        public int NoOfPermisson { get; set; }

        public AttendanceDetails(int totalWorkingDays,int noOfLeaves,int noOfPermisson){
            TotalWorkingDays=totalWorkingDays;
            NoOfLeaves=noOfLeaves;
            NoOfPermisson=noOfPermisson;
        }
        public static AttendanceDetails operator+(AttendanceDetails value1,AttendanceDetails value2){
            AttendanceDetails attendance=new AttendanceDetails(0,0,0);
            attendance.TotalWorkingDays=value1.TotalWorkingDays+value2.TotalWorkingDays;
            attendance.NoOfLeaves=value1.NoOfLeaves+value2.NoOfLeaves;
            attendance.NoOfPermisson=value1.NoOfPermisson+value2.NoOfPermisson;
            return attendance;
        }
    }
}