
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Model;
using System.Xml;

namespace DataAccessLayer
{
    public class SqlHelper
    {
        public Result AddClass(UniversityClasses universityClasses)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

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

        public Result GetClass(UniversityClasses universityClasses)
        {
            List<UniversityClasses> universityClassList = new List<UniversityClasses>();

            SqlConnection connection =
                new SqlConnection(
                    "Server=;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");
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

                Console.WriteLine("These Are Classes Found : ");

                foreach (var uniClass in universityClassList)
                {
                    Console.WriteLine(uniClass.ID + ". " + uniClass.ClassName);
                }
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


        public Result RemoveClass(UniversityClasses universityClasses)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

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
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

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

        public Result GetStudent(Student student)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

            SqlCommand command = new SqlCommand("SELECT * FROM [AmoozeshyarDB].[dbo].[Student] WHERE Firstname +' '+ Lastname LIKE @Fullname", connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@Fullname", "%" + student.Firstname + " " + student.Lastname + "%");

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.Write("ID : " + reader[0].ToString() + " ".PadLeft(4));
                    Console.Write(" Firstname : " + reader[1].ToString() + " ".PadLeft(4));
                    Console.Write(" Lastname : " + reader[2].ToString() + " ".PadLeft(4));
                    Console.Write(" Age : " + reader[3].ToString() + " ".PadLeft(4));
                    Console.WriteLine(" National Code : " + reader[4].ToString() + " ");
                }

                return new Result()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error : {ex.Message}");
                return new Result()
                {
                    IsSuccess = false
                };
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }

        public Result RemoveStudent(Student student)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

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

            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

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
        public Result ClassStudents(UniversityClasses universityClasses)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

            SqlCommand command = new SqlCommand("SELECT  uc.Name, s.Firstname + ' ' + s.Lastname As [Full Name] , s.ID AS [Student ID] FROM [UniversityClass] uc JOIN [ClassStudent] cs ON cs.ClassID = uc.ID JOIN [AmoozeshyarDB].[dbo].[Student] s ON s.ID = cs.StudentID WHERE cs.ClassID = (@ClassID)", connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@ClassID", universityClasses.ID);

                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine("These Are Students in This Class : ");

                while (reader.Read())
                {
                    Console.Write("\nClass Name : " + reader[0].ToString() + " ".PadLeft(4));
                    Console.Write("Student Name  : " + reader[1].ToString() + " ".PadLeft(4));
                    Console.Write("          ID  : " + reader[2].ToString() + " ".PadLeft(4));
                }

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
                    IsSuccess = false
                };
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        public Result RemoveStudentFromClass(StudentUniversityClasses studentUniversityClasses)
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

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

        public Result ShowSchedule()
        {
            SqlConnection connection = new SqlConnection("Server=.;Database=AmoozeshyarDB;Trusted_Connection=True;TrustServerCertificate = True;");

            SqlCommand command = new SqlCommand("SELECT uc.[Name] , s.Firstname + ' ' + s.Lastname AS [Full Name] FROM [AmoozeshyarDB].[dbo].[UniversityClass] uc JOIN [ClassStudent] cs ON uc.ID = cs.ClassID JOIN [Student] s ON s.ID = cs.StudentID ORDER BY 1", connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.Write("\nClass Name : " + reader[0].ToString() + " ".PadLeft(4));
                    Console.Write("Student Name : " + reader[1].ToString() + " ".PadLeft(4));
                }

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
    }
}
