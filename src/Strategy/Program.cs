using Strategy.Delegates.Data;
using Strategy.Delegates.Model;

// Strategy Design Pattern with Delegates

Func<decimal, decimal, decimal> multiplication = (x, y) => x * y;
decimal answer = multiplication(3.3M, 8.11M);

Console.WriteLine(answer);

Func<Func<decimal>, decimal> calculate = (func) => func();
answer = calculate(() => 2 ^ 3);

Console.WriteLine(answer);

StudentDb.InsertStudent(() =>
{
    Student student = new(7, "Hailee", "", "hailee@gmail.com", 1, "Acting Film & Television");
    return student;
});

StudentDb.UpdateStudent(x => x.FirstName == "Jaimin", student =>
{
    student.Rank = 2;
});

var students = StudentDb.GetStudents(x => x.Rank < 15);

foreach (var student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName} {student.Email} {student.Rank} {student.Course}");
}
