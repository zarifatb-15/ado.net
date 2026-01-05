using adonet.Models;

namespace adonet.Repositories;

public class StudentRepository:IStudentRepository
{
    public void AddStudent(Student student)
    {
        Console.WriteLine( student.Id + " Id № Student Added");
    }

    public List<Student> GetAllStudents()
    {
        throw new NotImplementedException();
    }

    public Student GetStudent(int id)
    {
        throw new NotImplementedException();
    }

    public Student GetStudent(int id, string name)
    {
        throw new NotImplementedException();
    }

    public void UpdateStudent(Student student)
    {
        throw new NotImplementedException();
    }

    public void DeleteStudent(int id)
    {
        throw new NotImplementedException();
    }
}