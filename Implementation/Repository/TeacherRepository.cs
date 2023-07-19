using BlazorApi.Context;
using BlazorApi.Interface.IRepository;

namespace BlazorApi.Implementation.Repository
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly MyDbContext _context;
        public TeacherRepository(MyDbContext context)
        {
            _context = context;
        }
        public Teacher AddTeacher(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        public void DeleteTeacher(Teacher teacher)
        {
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }

        public List<Teacher> GetAllTeacher()
        {
            return _context.Teachers.ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return _context.Teachers.SingleOrDefault(i => i.Id == id);
        }

        public Teacher UpdateTeacher(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
            return teacher;
        }
    }
}
