using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wasap");

            IList<Student> students = new List<Student>();

            students.Add(new Student("Mary Jane", "BSCS", "1"));

            students.Add(new Student("Kim Jong Un", "BAFA", "2"));

            students.Add(new Student("Mao Ze Dong", "BSBio", "3"));


           

            while (true)
            {
                Console.WriteLine("total = " + students.Count);
                Console.WriteLine("[1] Register\n[2] Delete\n[3] Update\n[4] Search\n[5] Exit\n");
                Console.WriteLine();
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        bool notduplicate = true;
                        Console.WriteLine("Enter student number of student to be added.");
                        string studentNumber = Console.ReadLine();
                        foreach (Student s in students)
                        {
                            if (studentNumber.Equals(s.StudentNumber))
                            {
                                Console.WriteLine("Student exists already");
                                notduplicate = false;
                                break;
                            }
                        }
                        if (!notduplicate)
                        {
                            break;
                        }
                        
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Course: ");
                        string course = Console.ReadLine();
                        

                        Student newStudent = new Student(name, course, studentNumber);
                        students.Add(newStudent);
                        Console.WriteLine("New student added with the following details:\n" + newStudent.ToString());
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Enter student number of student to be deleted:");
                        string studentToDelete = Console.ReadLine();
                        bool found = false;
                        foreach (Student s in students)
                        {
                            if (s.StudentNumber.Equals(studentToDelete))
                            {
                                found = true;
                                students.Remove(s);
                                Console.WriteLine("Student deleted successfully");
                                break;
                            }
                           
                        }
                        if (!found)
                        {
                            Console.WriteLine("Student is not in the list anymore");
                            break;
                        }
                        break;

                    case 3:

                        Console.WriteLine("Please enter the student number of student to update");
                        studentNumber = Console.ReadLine();
                        int ctr = 0;
                        bool studentFound = false;
                        foreach (Student s in students)
                        {

                            ctr++;
                            if (studentNumber.Equals(s.StudentNumber))
                            {
                                Console.WriteLine("[1] Name\n[2] Course\n\n");
                                Console.WriteLine("Choose the field you would like to update");
                                int field = Convert.ToInt32(Console.ReadLine());
                                studentFound = true;
                                switch (field)
                                {
                                    case 1:
                                        Console.WriteLine("Name = " + s.Name);
                                        Console.WriteLine("Enter edited name: ");
                                        string editedName = Console.ReadLine();
                                        s.Name = editedName;

                                        Console.WriteLine(s.Name +" is the new name");

                                        break;
                                    case 2:

                                        Console.WriteLine("The course of {0} is {1}", s.Name,s.Course);
                                        string editedCourse = Console.ReadLine();
                                        s.Course = editedCourse;
                                        Console.WriteLine("{0} shifted to {1}", s.Name, s.Course);
                                        break;
                                    
                                    default:
                                        Console.WriteLine();
                                        break;
                                }
                            } 
                            if (ctr == students.Count && !studentFound)
                            {
                                Console.WriteLine("Student does not exist");
                            }                           
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("Enter student number to search for student");
                        string studentToSearch = Console.ReadLine();
                        bool foundStudent = false;
                        foreach(Student s in students)
                        {
                            if (studentToSearch.Equals(s.StudentNumber))
                            {
                                foundStudent = true;
                                Console.WriteLine("Student found with the following details:\n"+s.ToString());
                            }
                            
                        }
                        if (!foundStudent)
                        {
                            Console.WriteLine("Student not found");
                            break;
                        }
                        break;
                    case 5:
                        System.Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("...");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
