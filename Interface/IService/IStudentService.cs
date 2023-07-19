using BlazorApi.DTO;

namespace BlazorApi.Interface.IService
{
    public interface IStudentService
    {
        bool AddStudent(CreateStudentModel model);
        bool UpdateStudent(int id, UpdateStudentModel model);
        void DeleteStudent(int id);
        StudentDTO GetStudent(int id);
        List<StudentDTO> GetStudentByAll();
    }
}
