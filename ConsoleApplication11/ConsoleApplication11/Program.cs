
namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "Brown", "English");
            Instructor Mike = new Instructor("Mike", "Tom", "Math");
            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);
            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);

            John.SetStudentGrade(Jane,95);
            John.SetStudentGrade(Joe, 85);
            Mike.SetStudentGrade(Melissa, 92);
            Mike.SetStudentGrade(Matt, 92);

            @static.Divider(); 
            Jane.PrintNameGradeandTeacherinfromation (); 
            @static.Divider(); 
            Joe.PrintNameGradeandTeacherinfromation (); 
            @static.Divider();          
            Melissa.PrintNameGradeandTeacherinfromation(); 
            @static.Divider(); 
            Matt. PrintNameGradeandTeacherinfromation(); 

            @static.Divider(); 


            
            System.Console.WriteLine("Press any key to countues....");
            System.Console.ReadKey();
            
            
           
            

            
     
            

        }
    }
}
