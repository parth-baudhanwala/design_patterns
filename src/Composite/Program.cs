using Composite;
using Composite.Component;
using Composite.Leaf;

IEmployee parth = new Employee("Parth", "R&D");
IEmployee hailee = new Employee("Hailee", "IT");
IEmployee samantha = new Employee("Samantha", "HR");
IEmployee aatish = new Employee("Aatish", "Admin");

IEmployee jaimin = new Manager("Jaimin", "CTO")
{
    subOrdinates = { parth, hailee }
};

IEmployee meet = new Manager("Meet", "COO")
{
    subOrdinates = { aatish, samantha }
};

IEmployee bruce = new Manager("Bruce", "CEO")
{
    subOrdinates = { jaimin, meet }
};

bruce.GetDetails(0);
