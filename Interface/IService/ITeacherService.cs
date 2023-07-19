using BlazorApi.DTO;

namespace BlazorApi.Interface.IService
{
    public interface ITeacherService
    {
        bool AddTeacher(CreateTeacherModel model);
        void DeleteTeacher(int id);
        TeacherDTO GetTeacher(int id);
        List<TeacherDTO> GetAllTeacher();
        bool UpdateTeacher( int id, UpdateTeacherModel model);
    }   
}
