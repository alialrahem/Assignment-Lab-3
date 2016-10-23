
namespace ConsoleApplication11
{
    class Instructor
    {
        private string FirstName;
        private string LastName;
        private string CourseName;
        public string GetNameAndCourse()
        {

            return this.FirstName + this.LastName + " Who teaches " + this.CourseName + ".   "


                ;
        }






        public Instructor(string FirstName, string LastName, string CourseName)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CourseName = CourseName;




        }


        public void SetStudentGrade(Student student, int grade)
        {


            student.SetGrade(grade);


        }


        public void PrintNameAndCourse()
        {

            System.Console.WriteLine(GetNameAndCourse());



        }


    }


}
         
          


       












          
   

            

 
 

