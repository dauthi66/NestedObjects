using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    Email = "Annemarie@cptc.edu",
    FullName = "Annemarie Smith",
    OfficeLocation = "B17 Rm 150"
};

Student student = new Student()
{
    FirstName = "Lisa",
    LastName = "Simpson",
    DateOfBirth = new DateOnly(2000, 3, 20),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "2534686485",
    SchoolEmail = "L.Simpson@students.cptc.edu"
};

Console.WriteLine($"Student: {student.FirstName} {student.LastName} has {student.AssignedAdvisor.FullName} as their advisor");