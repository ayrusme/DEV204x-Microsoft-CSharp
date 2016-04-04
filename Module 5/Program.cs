using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_edX
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating three student objects, since it's at least three.

            Student stud1 = new Student("Surya", "Raman", "haha@haha.com");
            Student stud2 = new Student("Narendra", "Mdoi","lol@lol.com");
            Student stud3 = new Student("Barack", "Obama", "blah@blah.com");

            //Now creating the course object with dev204X

            Course course = new Course("DEV204X", 5);

            //Using the method at the end of this code to add students to course

            course.addStudent(stud1);
            course.addStudent(stud2);
            course.addStudent(stud3);

            // Creating one teacher object since that's the minimum number

            Teacher teacher = new Teacher("Bruce", "Wayne", "iambatman@justiceleague.com");

            // Using the method at the end of this code to add teacher to course

            course.addTeacher(teacher);

            // Creating Degree object, assuming Computer Science and Engineering degree

            Degree degree = new Degree("Computer Science and Engineering", 250, null);

            // Adding Course object to the Degree object

            degree.Course = course;

            //Creating UProgram object with Bachelor of Engineering

            UProgram uProgram = new UProgram("Bachelor of Engineering", "Lex Luthor", null);

            // Adding the Degree object to the UProgram object

            uProgram.Degree = degree;

            // Printing everything as per the Assignment instructions

            Console.WriteLine("The {0} program contains the {1} degree\n", uProgram.ProgramName, degree.DegreeName);

            Console.WriteLine("The {0} degree contains the course {1}\n", degree.DegreeName, course.CourseName);
            
            Console.WriteLine("The {0} course contains {1} student(s)\n", course.CourseName, course.studentNumber);
            Console.ReadKey();
        }

        public class Student
        {
            //Variable Declarations

            string studFirstName, studLastName, studEmailID;

            // Student Class Constructor

            public Student(string firstName, string lastName, string emailID)
            {
                this.studFirstName = firstName;
                this.studLastName = lastName;
                this.studEmailID = emailID;

            }

            //Student Variable properties

            public string FirstName
            {
                get { return this.studFirstName; }
                set { if (value != null) { this.studFirstName = value; } }
            }

            public string LastName
            {
                get { return this.studLastName; }
                set { if (value != null) { this.studLastName = value; } }
            }

            public string Email
            {
                get { return this.studEmailID; }
                set { if (value != null){ this.studEmailID = value; } }
            }


        }

        public class Teacher
        {
            // Teacher variables

            string teacherFirstName, teacherLastName, teacherEmailID;

            // Teacher Class Constructor

            public Teacher(string firstName, string lastName, string emailID)
            {
                this.teacherFirstName = firstName;
                this.teacherLastName = lastName;
                this.teacherEmailID = emailID;
            }

            //Teacher Variable properties

            public string FirstName
            {
                get { return this.teacherFirstName; }
                set { if (value != null) { this.teacherFirstName = value; } }
            }

            public string LastName
            {
                get { return this.teacherLastName; }
                set { if (value != null) { this.teacherLastName = value; } }
            }

            public string Email
            {
                get { return this.teacherEmailID; }
                set { if (value != null) { this.teacherEmailID = value; } }
            }

        }

        public class UProgram
        {
            // UProgram variables 

             string programName, departmentHead;
             Degree degree;

            // UProgram Class Constructor

            public UProgram(string pName, string departmentH, Degree degree)
            {
                this.programName = pName;
                this.departmentHead = departmentH;
                this.degree = degree;
            }

            // UProgram Variable properties
            
            public string ProgramName 
            {
                get { return this.programName; }
                set { if (value != null) { this.programName = value; } } 
            }

            public string DepartmentHead
            {
                get { return this.departmentHead; }
                set { if (value != null) { this.departmentHead = value; } } 
            }

            public Degree Degree
            {
                get { return this.degree; }
                set { if (value != null) { this.degree = value; } } 
            }
        }

        public class Degree
        {
            // Degree variables

            private string degreeName;
            private int totalCredits;
            private Course course;

            // Degree Class Constructor

            public Degree(string dName, int credits, Course course)
            {
                this.degreeName = dName;
                this.totalCredits = credits;
                this.course = course;
            }

            // Degree Variable Properties

            public string DegreeName
            {
                get { return this.degreeName; }
                set { if (value != null) { this.degreeName = value; } } 
            }

            public int TotalCredits
            {
                get { return this.totalCredits; }
                set { if (value != null) { this.totalCredits = value; } } 
            }

            public Course Course 
            {
                get { return this.course; }
                set { if (value != null) { this.course = value; } } 
            }
        }

        public class Course
        {
            
            // Course variables

             public string courseName;
             public int courseCredits, studentNumber=0, teacherNumber=0;
             Student[] students;
             Teacher[] teachers;

            // Course Class Constructor

            public Course(string cName, int credits)
            {
                this.courseName = cName;
                this.courseCredits = credits;
                this.students = new Student[3];
                this.teachers = new Teacher[3];
            }

            // Course Variable Properties

            public string CourseName
            {
                get { return this.courseName; }
                set { if (value != null) { this.courseName = value; } }
            }

            public int CourseCredits
            {
                get { return this.courseCredits; }
                set { if (value != null) { this.courseCredits = value; } }
            }

            // Adding a Student 

            public void addStudent(Student student)
            {
                int n = this.studentNumber;
                this.students[n] = student;
                this.studentNumber++;
            }

            // Adding a Teacher

            public void addTeacher(Teacher teacher)
            {
                int n = this.teacherNumber;
                this.teachers[n] = teacher;
                this.teacherNumber++;
            }
                
            }
        }

    }