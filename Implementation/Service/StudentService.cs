using BlazorApi.DTO;
using BlazorApi.Interface.IRepository;
using BlazorApi.Interface.IService;

namespace BlazorApi.Implementation.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentService)
        {
            _studentRepository = studentService;
        }
        public bool AddStudent(CreateStudentModel model)
        {
            var student = new Student
            {
                
                Name = model.Name,
                Age = model.Age,
                Course = model.Course,
                Department = model.Department,
                Email = model.Email,
            };
            _studentRepository.AddStudent(student);
            return true;
        }

        public void DeleteStudent(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            _studentRepository.DeleteStudent(student);

        }

        public StudentDTO GetStudent(int id)
        {
            var student = _studentRepository.GetStudentById(id);
            if (student == null) throw new Exception($"Dear {student} your id-{id} is invalid");
            return new StudentDTO
            {
                Id = student.Id,
                Age = student.Age,
                Name = student.Name,
                Department = student.Department,
                Course = student.Course,
                Email = student.Email
            };
        }

        public List<StudentDTO> GetStudentByAll()
        {
            return _studentRepository.GetAllStudent().Select(d => new StudentDTO
            {
                Id = d.Id,
                Name = d.Name,
                Email = d.Email,
                Department = d.Department,
                Course = d.Course,

            }).ToList();


        }
        public bool UpdateStudent(int id, UpdateStudentModel model)
        {
            var student = _studentRepository.GetStudentById(id);
            
            student.Course = model.Course;
            student.Email = model.Email;
            student.Age = model.Age;
            student.Department = model.Department;
            
            _studentRepository.UpdateStudent(student);
            return true;
        }
    }
}
