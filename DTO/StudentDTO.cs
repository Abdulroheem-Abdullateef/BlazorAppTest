namespace BlazorApi.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
       
    }
    public class CreateStudentModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
    }
    public class UpdateStudentModel 
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
    }
}
