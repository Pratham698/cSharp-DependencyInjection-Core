namespace FirstCoreMVCWebApplication.Models
{
    //Service Interface
    public interface IStudentRepository
    {
        Student GetStudentById(int StudentId);
        List<Student> GetAllStudent();
    }
}
