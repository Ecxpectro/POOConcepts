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
Console.WriteLine(employee1);

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
Console.WriteLine(employee2);
Console.ReadKey();