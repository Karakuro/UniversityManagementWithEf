namespace UniversityManagementV2.Data
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FiscalCode { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Course>? Courses { get; set; }
        public List<ExamResult>? Results { get; set; }
    }
}
