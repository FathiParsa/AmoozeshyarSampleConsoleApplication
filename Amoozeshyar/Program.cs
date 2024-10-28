using DataAccessLayer;
using Microsoft.IdentityModel.Tokens;
using Model;
using System.Data.SqlTypes;

namespace Amoozeshyar
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nGreetings! and Welcome to The Amoozheshyar!");
                Console.WriteLine("======================");
                Console.WriteLine("1. Add Class");
                Console.WriteLine("2. Remove Class");
                Console.WriteLine("3. Add Student");
                Console.WriteLine("4. Remove Student");
                Console.WriteLine("5. Select Class For Sudent");
                Console.WriteLine("6. Remove Student From Class");
                Console.WriteLine("7. Display Schedule");
                Console.WriteLine("8. Exit");
                Console.WriteLine("======================");
                Console.Write("Please Enter an Option: ");

                string? inputValue = Console.ReadLine();

                ValidateInput vi = new ValidateInput();

                int validateInput;

                while (!vi.ValidateSelectedOption(inputValue, out validateInput, 1, 8))
                {
                    Console.WriteLine("Wrong Input! Please Try Again...");
                    Console.Write("Please Enter an Option: ");
                    inputValue = Console.ReadLine();
                }
                if (validateInput == 8)
                {
                    break;
                }

                if (validateInput == 1)
                {
                    Console.Write("Please enter name of class: ");
                    SqlHelper sqlHelper = new SqlHelper();

                    Result res = sqlHelper.AddClass(new UniversityClasses()
                    {
                        ClassName = Console.ReadLine()
                    });

                    vi.ValidateOperation(res , "Class Added To Database Successfully! ", "Error in Saving Data...");
                }

                if (validateInput == 2)
                {
                    Console.Write("Please Enter The Name of The Class You Want to Delete : ");

                    SqlHelper sqlHelper = new SqlHelper();

                    Result resultGetClass = sqlHelper.GetClass(new UniversityClasses()
                    {
                        ClassName = Console.ReadLine()
                    });

                    vi.ValidateOperation(resultGetClass , "" , "Error in Getting Classes...");

                    Console.WriteLine("Now , Enter The Exact ID of Class To Permanently Remove It : ");

                    Result resultRemoveClass = sqlHelper.RemoveClass(new UniversityClasses()
                    {
                        ID = int.Parse(Console.ReadLine())
                    });

                    vi.ValidateOperation(resultRemoveClass, "Class Removed Successully! ", "Error in Deleting Class...");
                }
                if (validateInput == 3)
                {
                    Console.Write("Please Enter The Firstname of Student : ");
                    string firstName = Console.ReadLine();
                    Console.Write("Please Enter The Lastame of Student : ");
                    string lastName = Console.ReadLine();

                    Console.Write("Please Enter The Age of Student : ");
                    int age = int.Parse(Console.ReadLine());

                    while (!vi.ValidateAge(age))
                    {
                        Console.Write("Wrong Age. Please Enter The Right Age : ");
                        age = int.Parse(Console.ReadLine());
                    }

                    Console.Write("Please Enter The National Code of Student : ");
                    string nationalCode = Console.ReadLine();

                    while (!vi.ValidateNationalCode(nationalCode))
                    {
                        Console.Write("Wrong National Code. Please Try again : ");
                        nationalCode = Console.ReadLine();
                    }

                    SqlHelper sqlHelper = new SqlHelper();

                    Result addStudentResult = sqlHelper.AddStudent(new Student()
                    {
                        Age = age,
                        Firstname = firstName,
                        Lastname = lastName,
                        NationalCode = nationalCode
                    });

                    vi.ValidateOperation(addStudentResult, "Student Added To Database Successfully!", "Error in Adding New Student...");
                }

                if (validateInput == 4)
                {
                    Console.WriteLine("For Delete Any Student You should Search Student Name And Then Enter The Exact ID of It. \n");

                    string firstName = "";
                    string lastName = "";

                    do
                    {
                        Console.Write("Enter The Firstname : ");
                        firstName = Console.ReadLine();
                        Console.Write("Enter The Lastname : ");
                        lastName = Console.ReadLine();
                        if (firstName.IsNullOrEmpty() && lastName.IsNullOrEmpty())
                        {
                            Console.WriteLine("Oops! Enter A Name...!");
                        }
                    } while (firstName.IsNullOrEmpty() && lastName.IsNullOrEmpty());

                    SqlHelper sqlHelper = new SqlHelper();

                    Result resultGetStudent = sqlHelper.GetStudent(new Student()
                    {
                        Firstname = firstName,
                        Lastname = lastName
                    });
                    vi.ValidateOperation(resultGetStudent, "", "Error in Getting Students...");

                    Console.WriteLine("Now , Enter The Student ID To Permanently Remove It : ");

                    Result resultRemoveStudent = sqlHelper.RemoveStudent(new Student()
                    {
                        ID = int.Parse(Console.ReadLine())
                    });

                    vi.ValidateOperation(resultRemoveStudent, "Studet Removed From Database Successfully!", "Error in Removing Student From Database...");
                }
                if (validateInput == 5)
                {
                    Console.Write("\n Enter Student ID : ");
                    int StudentID = int.Parse(Console.ReadLine());
                    Console.WriteLine(" ");

                    SqlHelper sqlHelper = new SqlHelper();

                    Result resultGetClass = sqlHelper.GetClass(new UniversityClasses
                    {
                        ClassName = " "
                    });

                    vi.ValidateOperation(resultGetClass, " ", "Error in Getting Classes...");

                    Console.Write("Now , Enter ID of Class That You Want To Select For Student : ");

                    Result resultAddClassForStudent = sqlHelper.AddClassForStudent(new StudentUniversityClasses
                    {
                        StudentID = StudentID,
                        ClassID = int.Parse(Console.ReadLine())
                    });

                    vi.ValidateOperation(resultAddClassForStudent, "Class Added For This Student Successfully ", "Error in Adding Class For Student...");
                }
                if (validateInput == 6)
                {
                    SqlHelper sqlHelper = new SqlHelper();

                    Result resultGetClass = sqlHelper.GetClass(new UniversityClasses
                    {
                        ClassName = " "
                    });

                    vi.ValidateOperation(resultGetClass, " ", "Error in Getting Classes...");

                    Console.Write("Select Class By Entering Class ID : ");
                    int classID = int.Parse(Console.ReadLine());

                    Result resultClassStudents = sqlHelper.ClassStudents(new UniversityClasses
                    {
                        ID = classID,
                    });

                    vi.ValidateOperation(resultClassStudents, "", "Error in Getting Data...");

                    Console.Write("\n\nWhich Student You Want To Delete From Class? Enter The Student ID : ");

                    Result resultRemoveStudentFromClass = sqlHelper.RemoveStudentFromClass(new StudentUniversityClasses
                    {
                        StudentID = int.Parse(Console.ReadLine()),
                        ClassID = classID
                    });

                    vi.ValidateOperation(resultRemoveStudentFromClass, "Student Removed From Class :( ", "Error in Deleting Student From Class...");
                }
                if (validateInput == 7)
                {
                    Console.WriteLine("This Is The Schedule : ");

                    SqlHelper sqlHelper = new SqlHelper();

                    Result resultShowSchedule = sqlHelper.ShowSchedule();

                    vi.ValidateOperation(resultShowSchedule, "Schedule Showed Successfully!", "Error In Showing Schedule...");
                }
            }
        }
    }
}
