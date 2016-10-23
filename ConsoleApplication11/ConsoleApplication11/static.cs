
namespace ConsoleApplication11
{
    class @static
    {
       



        public static void Title() 
        { 
            System.Console.WriteLine("I actually like this class."); 

        }
        public static void SpaceDivider() 
        { 
            System.Console.WriteLine("     "); 
        }    
         public static void Divider() 
        { 
            System.Console.WriteLine("x//////////////////////////////////////////////////////////////////////x"); 
        }
         public static void  Studentinformation(string student, int grade, Instructor Teacher) 
        {             
            @static.lineone("Hi. My name"  + student+"   . My Teacher is  " + Teacher.GetNameAndCourse());
            @static.linetwo ("   I have a " + grade + " in the course.");          
        } 

        public static void lineone(string lineone) 
        { 
            System.Console.WriteLine("I" + lineone.PadRight(70) + "I");        
        } 
        public static void linetwo(string linetwo) 
        { 
            System.Console.WriteLine("I" + linetwo.PadRight(70) + "I"); 
        } 

        



        

       
     }

}