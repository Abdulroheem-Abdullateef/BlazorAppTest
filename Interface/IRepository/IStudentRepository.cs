namespace BlazorApi.Interface.IRepository
{
    public interface IStudentRepository
    {
        Student AddStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(Student student);
        Student GetStudentById(int id);
        List<Student> GetAllStudent();

    }
}
