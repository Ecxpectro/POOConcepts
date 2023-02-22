using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("==========");

Employee employee1 = new SalaryEmployee()
{
	Id = 1010,
	FirstName = "Henrique",
	LastName = "Schraiber Cunha",
	BirthDate = new Date(1998, 12, 23),
	HiringDate = new Date(2022, 1, 15),
	IsActive= true,
	Salary = 1815453.45M,
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
	Id = 2010,
	FirstName = "Patricia",
	LastName = "Gutierrez",
	BirthDate = new Date(1995, 1, 23),
	HiringDate = new Date(2022, 2, 15),
	IsActive = true,
	Sales = 320000000M,
	CommissionPercentaje= 0.03F,

};
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
	Id = 2031,
	FirstName = "Gonzalo",
	LastName = "Cardona",
	BirthDate = new Date(1995, 10, 23),
	HiringDate = new Date(2022, 2, 15),
	IsActive = true,
	HourValue = 12356.56M,
	Hours= 123.5F,
};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
	Id = 3030,
	FirstName = "Jazmin",
	LastName = "Salazar",
	BirthDate = new Date(1991, 10, 23),
	HiringDate = new Date(2021, 2, 15),
	IsActive = true,
	Base = 860000.45M,
	Sales = 58000000M,
	CommissionPercentaje = 0.015F
};
//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
	employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
	Console.WriteLine(employee);
	payroll = payroll + employee.GetValueToPay();
}
Console.WriteLine("                                =================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}", 18}");

Invoice Invoice1 = new Invoice()
{
	Description = "Iphone 13",
	Id = 1,
	Price = 4700M,
	Quantity = 6
};
Invoice Invoice2 = new Invoice()
{
	Description = "Posta Premium",
	Id = 2,
	Price = 16700M,
	Quantity = 17.5F
};
Console.WriteLine(Invoice1);
Console.WriteLine(Invoice2);
Console.ReadKey();