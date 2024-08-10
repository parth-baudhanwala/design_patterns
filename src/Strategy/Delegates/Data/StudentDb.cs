using Strategy.Delegates.Model;

namespace Strategy.Delegates.Data;

internal static class StudentDb
{
    public static void InsertStudent(Func<Student> func)
    {
        Students = Students.Append(func());
    }

    public static void UpdateStudent(Func<Student, bool> func, Action<Student> action)
    {
        Student student = Students.First(func);
        action(student);
    }

    public static IEnumerable<Student> GetStudents(Predicate<Student> predicate)
    {
        foreach (var student in Students)
        {
            if (predicate(student))
            {
                yield return student;
            }
        }
    }

    private static List<Student> GetStudents(StudentDelegate studentDelegate)
    {
        List<Student> students = [];

        foreach (var student in Students)
        {
            if (studentDelegate(student))
            {
                students.Add(student);
            }
        }

        return students;
    }

    private delegate bool StudentDelegate(Student student);

    private static IEnumerable<Student> Students = [
        new Student(1, "Jaimin", "Chauhan", "jaiminchauhan@yahoo.com", 18, "Artificial Intelligence"),
        new Student(2, "Aatish", "Chaudhari", "aatishchaudhari@hotmail.com", 13, "Aeronautics"),
        new Student(3, "Parth", "Baudhanwala", "parthbaudhanwala@gmail.com", 8, "Quantum Mechanics"),
        new Student(4, "Meet", "Charola", "meetcharola@cornhub.com", 14, "Computer Science"),
        new Student(5, "Monil", "Modi", "monilmodi@outlook.com", 5, "Fluid Mechanics"),
        new Student(6, "Harsh", "Kelawala", "harshkelawala@noob.com", 31, "Human Biotechnology"),
        new Student(7, "Yash", "Mehta", "yashmehta@yahoo.com", 17, "Data Science")
    ];
}
