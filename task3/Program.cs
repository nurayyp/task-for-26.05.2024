using task3;

public static class Program
{
    public static void Main()
    {
        Student student = new Student();
        student.AddGrade("Nuray", new List<int> { 89,93,80 });
        student.AddGrade("Aytac", new List<int> { 78, 67, 97 });
        student.AddGrade("Nezrin", new List<int> { 56, 100, 98 });
        student.GetAllGradesByStudent("Nuray");
        student.RemoveGrade("Aytac");
        student.GetAverageGrade("Nezrin");
        student.GetAverageGrade("Nuray");
    }
}