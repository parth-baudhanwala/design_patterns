namespace Strategy.Delegates.Model;

internal class Student(int id,
                     string firstName,
                     string lastName,
                     string email,
                     int rank,
                     string course)
{
    public int Id { get; set; } = id;
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;
    public string Email { get; set; } = email;
    public int Rank { get; set; } = rank;
    public string Course { get; set; } = course;
}
