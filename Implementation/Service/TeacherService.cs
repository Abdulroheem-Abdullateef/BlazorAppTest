using BlazorApi.DTO;
using BlazorApi.Interface.IRepository;
using BlazorApi.Interface.IService;

namespace BlazorApi.Implementation.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public bool AddTeacher(CreateTeacherModel model)
        {
            var teacher = new Teacher
            {

                Name = model.Name,
                Course = model.Course,
                Email = model.Course
            };

            _teacherRepository.AddTeacher(teacher);
            return true;
        }

        public void DeleteTeacher(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            _teacherRepository.DeleteTeacher(teacher);
        }

        public List<TeacherDTO> GetAllTeacher()
        {
            return _teacherRepository.GetAllTeacher().Select(d => new TeacherDTO
            {
                Id = d.Id,
                Name = d.Name,
                Email = d.Email,
                Course = d.Course
            }).ToList();
        }

        public TeacherDTO GetTeacher(int id)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            if (teacher == null)
            {
                throw new Exception($"Dear {teacher} your id {id} is invalid ");
            }
            else
            {
                return new TeacherDTO
                {
                    Id = teacher.Id,
                    Name = teacher.Name,
                    Email = teacher.Email,
                    Course = teacher.Course,
                };
            }

        }

        public bool UpdateTeacher(int id, UpdateTeacherModel model)
        {
            var teacher = _teacherRepository.GetTeacherById(id);
            teacher.Email = model.Email;
            teacher.Course = model.Course;
            teacher.Name = model.Name;

            return true;
        }
    }

}

