namespace BlazorApi.DTO
{
    public class TeacherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
    }
    public class CreateTeacherModel 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
    }
    public class UpdateTeacherModel 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
    }
         
}
