namespace BlazorApi.Interface.IRepository
{
    public interface ITeacherRepository
    {
        Teacher  AddTeacher (Teacher teacher);
        Teacher UpdateTeacher (Teacher teacher);
        void DeleteTeacher (Teacher teacher);
        Teacher GetTeacherById (int id);
        List<Teacher>  GetAllTeacher ();
    }
}
