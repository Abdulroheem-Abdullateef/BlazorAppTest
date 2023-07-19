using BlazorApi.Context;
using BlazorApi.Interface.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BlazorApi.Implementation.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _context;
        public StudentRepository(MyDbContext context)
        {
            _context = context;
        }
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public void DeleteStudent(Student student)
        {

            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public Student GetStudentById(int id)
        {

            return _context.Students.FirstOrDefault(c => c.Id == id);
            
        }

        public List<Student> GetAllStudent()
        {
            return _context.Students.ToList();
        }

        public Student UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
            return student;
        }
    }
}
