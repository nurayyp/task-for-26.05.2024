using System;

namespace task3
{
    internal class Student
    {
        public Dictionary<string, List<int>> Grades { get; set; }
        public Student()
        {
            Grades = new Dictionary<string, List<int>>();
        }
        public void AddGrade(string studentName, List<int> studentGrades)
        {
            if (!Grades.ContainsKey(studentName))
            {
                Grades[studentName] = studentGrades;
            }
            else
            {
                Grades[studentName].AddRange(studentGrades);
            }
        }
        public void RemoveGrade(string studentName)
        {
            Grades.Remove(studentName);
        }
        public void GetAverageGrade(string studentName)
        {
            int sum = 0;
            int count = 0;
            foreach (var grade in Grades[studentName])
            {
                sum += grade;
                count++;
            }
            Console.WriteLine($"average is - {sum / count}");
        }
        public void GetAllGradesByStudent(string studentName)
        {
            foreach (var grade in Grades[studentName])
            {
                Console.Write(grade + ",");
            }
        }
    }
}
 