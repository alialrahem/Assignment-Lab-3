

namespace ConsoleApplication11
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;
        
        

        public void SetGrade(Instructor Teach, int SetGrade)
        {
            


        }
        public int getgrade()
        {

            return this.Grade;

        }
        public void SetGrade(int z)         {  
            this.Grade = z ; 
        } 

        public Student()
        {


             Grade = 0;
            



        }
       

        
        

        public Student(string Name, Instructor Teacher)
        {

            this.Name = Name;
            this.Teacher = Teacher;

        }
        public void PrintNameGradeandTeacherinfromation()
        {


            @static.Studentinformation(this.Name, this.Grade, this.Teacher);

        }




    }

}