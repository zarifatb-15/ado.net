using adonet.Models;

namespace adonet.Repositories;

public interface IStudentRepository
{
    void AddStudent(Student student);
    
    List<Student> GetAllStudents();
    
    Student GetStudent(int id);
    
    Student GetStudent(int id, string name);
    
    void UpdateStudent(Student student);
    
    void DeleteStudent(int id);
}