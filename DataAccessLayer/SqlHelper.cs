
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Model;
using System.Xml;

namespace DataAccessLayer
{
    public class SqlHelper
    {
        private string ConnectionString
        {
            get
            {
                return "Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;";
            }
        }

        public Result AddClass(UniversityClasses universityClasses)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO UniversityClass ([Name]) VALUES (@ClassName)", connection);
                connection.Open();

                command.Parameters.AddWithValue("@ClassName", universityClasses.ClassName);

                command.ExecuteNonQuery();

                return new Result()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new Result()
                {
                    Exeption = ex,
                    IsSuccess = false
                };

            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public List<UniversityClasses> GetClass(UniversityClasses universityClasses)
        {
            List<UniversityClasses> universityClassList = new List<UniversityClasses>();

            SqlConnection connection =
                new SqlConnection(ConnectionString);
            try
            {
                SqlCommand command = new("SELECT [ID],[Name] FROM [dbo].[UniversityClass] WHERE Name LIKE (@ClassName)", connection);

                connection.Open();

                command.Parameters.AddWithValue("@ClassName", "%" + universityClasses.ClassName + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    universityClassList.Add(new UniversityClasses()
                    {
                        ID = (int)reader["ID"],
                        ClassName = reader["Name"].ToString(),
                    });
                }

                return universityClassList;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public Result RemoveClass(UniversityClasses universityClasses)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM [dbo].[UniversityClass] WHERE ID = (@ClassID)", connection);
                connection.Open();

                command.Parameters.AddWithValue("@ClassID", universityClasses.ID);

                command.ExecuteNonQuery();

                return new Result()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new Result()
                {
                    Exeption = ex,
                    IsSuccess = false
                };
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public Result AddStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Student] ([Firstname] ,[Lastname] ,[Age],[NationalCode]) VALUES (@Firstname , @Lastname , @Age, @NationalCode)", connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@Firstname", student.Firstname);
                command.Parameters.AddWithValue("@Lastname", student.Lastname);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@NationalCode", student.NationalCode);

                command.ExecuteNonQuery();

                return new Result()
                {
                    IsSuccess = true
                };
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                return new Result()
                {
                    IsSuccess = false
                };
            }

            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public List<Student> GetStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand("SELECT * FROM [AmoozeshyarDB].[dbo].[Student] WHERE Firstname +' '+ Lastname LIKE @Fullname", connection);

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@Fullname", "%" + student.Firstname + " " + student.Lastname + "%");
                SqlDataReader reader = command.ExecuteReader();

                List<Student> students = new List<Student>();

                while (reader.Read())
                {
                    int? id = reader.IsDBNull(0) ? (int?)null : (int?)reader[0];
                    string firstname = reader.IsDBNull(1) ? null : reader.GetString(1);
                    string lastname = reader.IsDBNull(2) ? null : reader.GetString(2);
                    int? age = reader.IsDBNull(3) ? (int?)null : (int?)reader[3];
                    string nationalCode = reader.IsDBNull(4) ? null : reader.GetString(4);

                    students.Add(new Student
                    {
                        ID = id,
                        Firstname = firstname,
                        Lastname = lastname,
                        Age = age,
                        NationalCode = nationalCode
                    });
                }
                return students;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public Result RemoveStudent(Student student)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Student] WHERE ID = (@StudentID)", connection);
                connection.Open();

                command.Parameters.AddWithValue("@StudentID", student.ID);

                command.ExecuteNonQuery();

                return new Result()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return new Result()
                {
                    Exeption = ex,
                    IsSuccess = false
                };
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public Result AddClassForStudent(StudentUniversityClasses studentUniversityClasses)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[ClassStudent] ([StudentID] , [ClassID]) VALUES (@StudentID , @ClassID) ", connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@StudentID", studentUniversityClasses.StudentID);
                command.Parameters.AddWithValue("@ClassID", studentUniversityClasses.ClassID);

                command.ExecuteNonQuery();

                return new Result()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                return new Result()
                {
                    Exeption = ex,
                    IsSuccess = false
                };
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public List<ClassStudents> ClassStudents(UniversityClasses universityClasses)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand("SELECT  uc.Name, s.Firstname + ' ' + s.Lastname As [Full Name] , s.ID AS [Student ID] FROM [UniversityClass] uc JOIN [ClassStudent] cs ON cs.ClassID = uc.ID JOIN [AmoozeshyarDB].[dbo].[Student] s ON s.ID = cs.StudentID WHERE cs.ClassID = (@ClassID)", connection);

            List<ClassStudents> classStudents = new List<ClassStudents>();

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@ClassID", universityClasses.ID);

                SqlDataReader reader = command.ExecuteReader();

                

                while (reader.Read())
                {
                    classStudents.Add(new ClassStudents()
                    {
                        ClassName = reader[0].ToString(),
                        StudentFullname = reader[1].ToString(),
                        StudentID = (int)reader[2]
                    });
                }

                return classStudents;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public Result RemoveStudentFromClass(StudentUniversityClasses studentUniversityClasses)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM [dbo].[ClassStudent] WHERE ClassID = (@ClassID) AND StudentID = (@StudentID)", connection);
                connection.Open();

                command.Parameters.AddWithValue("@StudentID", studentUniversityClasses.StudentID);
                command.Parameters.AddWithValue("@ClassID", studentUniversityClasses.ClassID);

                command.ExecuteNonQuery();

                return new Result()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return new Result()
                {
                    Exeption = ex,
                    IsSuccess = false
                };
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public List<Schedule> ShowSchedule()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlCommand command = new SqlCommand("SELECT uc.[Name] , s.Firstname + ' ' + s.Lastname AS [Full Name] FROM [AmoozeshyarDB].[dbo].[UniversityClass] uc JOIN [ClassStudent] cs ON uc.ID = cs.ClassID JOIN [Student] s ON s.ID = cs.StudentID ORDER BY 1", connection);

            List<Schedule> schedules = new List<Schedule>();

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    schedules.Add(new Schedule()
                    {
                        ClassName = reader[0].ToString(),
                        StudentFullname = reader[1].ToString()
                    });
                }
                return schedules;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
                return null;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
