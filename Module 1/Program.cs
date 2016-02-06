using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edX
{
    class Module1
    {
        static void Main(string[] args)
        {
            //Student Information Variables 

            String stud_firstname, stud_lastname, stud_bday, stud_addline1, stud_addline2, stud_city, stud_state, stud_country;
            String stud_zip;

            //Student Information Assignment

            stud_firstname = "Surya";
            stud_lastname = "Raman";
            stud_bday = "13/11/1995";
            stud_addline1 = "Address Line 1";
            stud_addline2 = "Address Line 2";
            stud_city = "Chennai";
            stud_state = "TN";
            stud_country = "India";
            stud_zip = "12345";

            //Displaying Student Information

            Console.WriteLine("Students's Name : {0} {1}. The DOB is {2}. \n The address is {3}\n{4}\n{5}--{6}\n{7},{8}",
             stud_firstname, stud_lastname, stud_bday, stud_addline1, stud_addline2, stud_city, stud_zip, stud_state, stud_country);

            //Teacher Information Variables

            String te_firstname, te_lastname, te_bday, te_addline1, te_addline2, te_city, te_state, te_country;
            String te_zip;

            //Teacher Information Assignment

            te_firstname = "FirstName";
            te_lastname = "LastName";
            te_bday = "12/11/1975";
            te_addline1 = "Address Line 1";
            te_addline2 = "Address Line 2";
            te_city = "Mumbai";
            te_state = "MH";
            te_country = "India";
            te_zip = "43456";

            //Displaying Teacher Information

            Console.WriteLine("\nProfessor's Name : {0} {1}. The DOB is {2}. \n The address is {3}\n{4}\n{5}--{6}\n{7},{8}",
                te_firstname, te_lastname, te_bday, te_addline1, te_addline2, te_city, te_zip, te_state, te_country);
            
            //UProgram Information Variables 

            String upname,updepthead,updeg;

            //UProgram Details Assignment 

            upname = "DE204x";
            updepthead = "Nadella";
            updeg = "MSDNCerti";

            //Degree Information Variables

            String degName; int reqCredits;

            //Degree Information Assignment

            degName = "Bachelor of Engineering";
            reqCredits = 60;

            //Course Information Variables

            String courseName, teacher;
            int courseCredits, duration;

            //Course Information Assignment 

            courseName = "Development using C#";
            teacher = "Some Random Dude";

            courseCredits = 20;
            duration = 5;

            Console.WriteLine("\nThe program name is {0}. The Department Head is {1} and the degrees are {2},\nThe Degree is {3} and the number of credits required is " + reqCredits,
                upname,updepthead,updeg,degName);
            Console.WriteLine("\n The course name is {0}. The Credits availble in this course are " + courseCredits,courseName);
            Console.WriteLine("\nIt will be handled by {0} for " + duration + " weeks.",teacher);

            Console.ReadKey(true);

        }
    }
}
