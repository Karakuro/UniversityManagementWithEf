namespace UniversityManagementV2.Data
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<ExamResult> Results { get; set; }
    }
}
