namespace Assingment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Array Size: ");
            int size = int.Parse(Console.ReadLine());

            var Employees = new Employee[size];
            var emp1 = new Employee
            {
                Id = 1,
                Name = "Ahmed",
                Salary = 10000,
                HiringDate = new HiringDate { Day = 1, Month = 1, Year = 1980 },
                Gender = Gender.Male
            };
            var emp2 = new Employee
            {
                Id = 2,
                Name = "Mohamed",
                Salary = 20000,
                HiringDate = new HiringDate { Day = 11, Month = 10, Year = 1960 },
                Gender = Gender.Male
            };
            var emp3 = new Employee
            {
                Id = 3,
                Name = "Hassan",
                Salary = 30200,
                HiringDate = new HiringDate { Day = 20, Month = 6, Year = 1999 },
                Gender = Gender.Male
            };
            var emp4 = new Employee
            {
                Id = 4,
                Name = "Mona",
                Salary = 10000,
                HiringDate = new HiringDate { Day = 5, Month = 2, Year = 2000 },
                Gender = Gender.Female
            };
            var emp5 = new Employee
            {
                Id = 5,
                Name = "Mostafa",
                Salary = 9000,
                HiringDate = new HiringDate { Day = 2, Month = 3, Year = 1967 },
                Gender = Gender.Male
            };

            Employees[0] = emp1;
            Employees[1] = emp2;
            Employees[2] = emp3;
            Employees[3] = emp4;
            Employees[4] = emp5;

            Console.WriteLine("Before Sorting!\n\n");
            foreach(var employee in Employees)
                Console.WriteLine(employee);

            Console.WriteLine("After Sorting!\n\n");
            foreach (var employee in Employees)
                Console.WriteLine(employee);


        }
    }
}
