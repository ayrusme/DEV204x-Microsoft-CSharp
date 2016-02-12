using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_edX
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Calling all methods in this function 
            GetStudentData();
            GetProfessorData();
            GetUProgramData();
            GetDegreeData();
            GetCourseData();

            //The Exception Mechanism

            try
            {
                exceptionFunction();
            }

            catch(NotImplementedException exp)
            {
                Console.WriteLine(exp.Message);
                Console.ReadKey();
            }

        }

        public static void GetStudentData()
        {   //Getting all the variables

            Console.WriteLine("Enter the student's first name: ");
            string studFirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string studLastName = Console.ReadLine();
            Console.WriteLine("Enter the student's university");
            string studUnivName = Console.ReadLine();

            //Calling Print statements

            PrintStudentData(studFirstName, studLastName, studUnivName);
        }

        public static void PrintStudentData(string firstName, string lastName, string univName)
        {
            Console.WriteLine("The student {0} {1} is studying at {2}", firstName, lastName, univName);            
        }

        public static void GetProfessorData()
        {
            //Getting all the variables for the Professor

            Console.WriteLine("Enter the professors's first name: ");
            string ProfFirstName = Console.ReadLine();
            Console.WriteLine("Enter the professors's last name");
            string ProfLastName = Console.ReadLine();
            Console.WriteLine("Enter the professors's university");
            string ProfUnivName = Console.ReadLine();

            //Calling the Print function for the professor

            PrintProfessorData(ProfFirstName, ProfLastName, ProfUnivName);
        }

        public static void PrintProfessorData(string ProfFirstName, string ProfLastName, string ProfUnivName)
        {
            Console.WriteLine("The Professor {0} {1} works at {2}", ProfFirstName, ProfLastName, ProfUnivName);
        }

        public static void GetUProgramData()
        {
            //Getting all the course data

            Console.WriteLine("Enter the UProgram Name:");
            string uProgramName = Console.ReadLine();
            Console.WriteLine("Enter the UProgram Head:");
            string uProgramHead = Console.ReadLine();
            Console.WriteLine("Enter the UProgram Degrees");
            int uProgramDegrees = Convert.ToInt32(Console.ReadLine());

            //Printing this Information using another function 

            PrintUProgramData(uProgramName, uProgramHead, uProgramDegrees);
        }

        public static void PrintUProgramData(string uProgramName, string uProgramHead, int uProgramDegrees)
        {
            Console.WriteLine("{0} is the head of the undergraduate program {1}. The number of degrees are {2}", uProgramHead, uProgramName, uProgramDegrees);
        }

        public static void GetDegreeData()
        {
            //Getting the Degree Details 

            Console.WriteLine("Enter the Degree Name:");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the number of credits required:");
            int creditsReq = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of courses:");
            int numberOfCourses = Convert.ToInt32(Console.ReadLine());
            //Printing the Degree Details

            PrintDegreeData( degreeName, creditsReq, numberOfCourses);
        }

        public static void PrintDegreeData(string degreeName, int creditsReq, int numberOfCourses)
        {
            Console.WriteLine("{0} Degree has {1} courses with total credits of {2}", degreeName,numberOfCourses, creditsReq);
        }

        public static void GetCourseData()
        {
            //Getting the Course Details

            Console.WriteLine("Enter the Course Name:");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the Course Credits");
            int courseCredits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Duration");
            int courseDuration = Convert.ToInt32(Console.ReadLine());

            //Printing the Course Details 

            PrintCourseData(courseName, courseCredits, courseDuration);
        }

        public static void PrintCourseData(string courseName, int courseCredits, int courseDuration)
        {
            Console.WriteLine("The Course {0} has {1} credits and the duration is {2}", courseName, courseCredits, courseDuration);
        }

        public static void exceptionFunction()
        {
            //The Exception throw 

            throw new NotImplementedException();
        }

    }
}
