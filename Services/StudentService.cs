using adonet.Repositories;

namespace adonet.Services;

public class StudentService
{
 private readonly IStudentRepository _studentRepository;

 public StudentService(IStudentRepository studentRepository)
 {
  _studentRepository= studentRepository;
 }

 public void CreatStudent()   
 {
  _studentRepository
   .AddStudent(new Models.Student(){Id=1,Name="John",Descriotion="A good student"});
 }
}