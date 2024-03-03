using Factory.AbstractFactory.AbstractFactory;
using Factory.AbstractFactory.Client;
using Factory.AbstractFactory.ConcreteFactory;
using Factory.Enum;
using Factory.FactoryMethod;
using Factory.Manager;
using Factory.Model;

// Simple Factory
Factory.SimpleFactory.EmployeeManagerFactory employeeManagerFactory = new();
IEmployeeManager contractEmployeeManager = employeeManagerFactory.GetEmployeeManager(EmployeeType.Contract);
IEmployeeManager permanentEmployeeManager = employeeManagerFactory.GetEmployeeManager(EmployeeType.Permanent);

Console.WriteLine("Contract Employee Bonus: {0} and Pay: {1}",
                   contractEmployeeManager.GetBonus(),
                   contractEmployeeManager.GetPay());

Console.WriteLine("Permanent Employee Bonus: {0} and Pay: {1}",
                   permanentEmployeeManager.GetBonus(),
                   permanentEmployeeManager.GetPay());

// Factory Method
Employee employee = new("Parth Baudhanwala", EmployeeType.Permanent);
EmployeeManagerFactory employeeManager = new();
BaseEmployeeFactory baseEmployeeFactory = employeeManager.CreateFactory(employee);
baseEmployeeFactory.ApplySalary();

// Abstract Factory
EmployeeComputerFactory employeeComputerFactory = new();
IComputerFactory computerFactory = employeeComputerFactory.Create(employee);
EmployeeComputerManager employeeComputerManager = new(computerFactory);
employee.ComputerDetails = employeeComputerManager.GetComputerDetails();

Console.WriteLine("Employee Name: {0}, Bonus: {1}, Pay: {2}, HRA: {3}, Computer: {4}",
                   employee.Name,
                   employee.Bonus,
                   employee.HourlyPay,
                   employee.HouseAllowance,
                   employee.ComputerDetails);
