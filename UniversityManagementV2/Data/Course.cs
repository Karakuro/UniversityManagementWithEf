namespace UniversityManagementV2.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public List<Exam> Exams { get; set; }
        public List<Student> Students { get; set; }
    }
}
