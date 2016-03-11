using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_edX
{
    class Program
    {
        public struct Student
        {
            /*This area contains all the student variable declarations. There can be a lot of possible variables.
            However, I'm considering only four.*/

            public string studFirstName;
            public string studLastName;
            public string studUnivName;
            public string studCountry;

            public Student(string FirstName, string LastName, string UnivName, string Country)
            {
                //This is the constructor for the Struct Student.

                this.studFirstName = FirstName;
                this.studLastName = LastName;
                this.studUnivName = UnivName;
                this.studCountry = Country;
            }
        }

        public struct Professor
        {
            //Professor Variable Declarations

            public string profFirstName;
            public string profLastName;
            public string profUnivName;

            public Professor(string FirstName, string LastName, string UnivName)
            {
                //Professor struct's constructor

                this.profFirstName = FirstName;
                this.profLastName = LastName;
                this.profUnivName = UnivName;
            }
        }

        //Prog stands for Program. Program is used as the main class name. Hence this struct is called Prog.

        public struct Prog
        {
            //Program Variables

            public string programName;
            public string programHead;
            public int programDegrees;

            //Program Constructor

            public Prog(string pName, string pHead, int pDeg)
            {
                this.programName = pName;
                this.programHead = pHead;
                this.programDegrees = pDeg;
            }

        }

        public struct Course
        {
            //Course Variables 

            public string courseName;
            public int courseCredits;
            public int courseDuration;

            //Course Constructor

            public Course(string cName, int cCredits, int cDuration)
            {
                this.courseName = cName;
                this.courseCredits = cCredits;
                this.courseDuration = cDuration;
            }

        }


        public static void Main(string[] args)
        {
            //Creating array to hol d 5 student structs

            Student[] stud = new Student[5];

            /*Assigning values to one student struct. Assuming that
            struct to be stud[0];*/

            stud[0] = new Student("Surya","Raman","MSFT","India");
 
            //Printing that info

            Console.WriteLine("Student Information\n");
            Console.WriteLine("Student First Name: {0}\n", stud[0].studFirstName);
            Console.WriteLine("Student Last Name: {0}\n", stud[0].studLastName);
            Console.WriteLine("Student University Name: {0}\n", stud[0].studUnivName);
            Console.WriteLine("Student Country: {0}\n", stud[0].studCountry);

            Console.ReadKey();
        }
            
    }
}
