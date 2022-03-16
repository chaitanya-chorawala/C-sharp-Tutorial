// See https://aka.ms/new-console-template for more information
using C_sharp_Tutorial;

Console.WriteLine("Hello, World!");

void getName()
{
    Console.WriteLine("Chaitanya");
}

getName();

Console.WriteLine($"{0.1 + 0.1 + 0.1} - {(0.1 + 0.1 + 0.1) == 0.3}");
Console.WriteLine($"{0.1m + 0.1m + 0.1m} - {(0.1m + 0.1m + 0.1m) == 0.3m}");

Console.WriteLine("----------------Date-----------------");
DateTime dateTime = DateTime.Now;
DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
TimeOnly timeOnly = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(dateTime);
Console.WriteLine($"{dateOnly} - {timeOnly}");


//Car
Console.WriteLine("----------------Car-----------------");
Car car = new Car();
car.Company = "Ford";
car.Model = "Mustang";
car.Year = 2022;
car.Color = "Black";

Console.WriteLine($"Company: {car.Company}," +    
    $"\nModel: {car.Model}," +
    $"\nYear: {car.Year}," +
    $"\nColor: {car.Color}");
Console.WriteLine("Market Value: {0:N}", car.DetermineMarketValue());

TestVirtual test = new TestVirtual();
test.Display();

test = new Car();
test.Display();

//Rectangle
Console.WriteLine("----------------Rectangle-----------------");
Rectangle rect = new Rectangle(10, 20);
rect.Display();
rect.Area();
rect.Perimeter();

//Calculator
Console.WriteLine("----------------Calculator-----------------");
Calculator calculator = new Calculator(10,5);
Calculator calc1 = new Calculator(5, 2);
Console.WriteLine($"Addition: {calculator.Addition()}");
Console.WriteLine($"Subtraction: {calculator.Subtraction()}");
Console.WriteLine($"Multiplication: {calculator.Multiplication()}");
Console.WriteLine($"Division: {calculator.Division()}");
Console.WriteLine($"Modulus: {calculator.Modulus()}");

Console.WriteLine("----------------Action as parameter-----------------");
Console.WriteLine($"{calculator.x} + {calculator.y}: {calculator.Action("+")}");
Console.WriteLine($"{calculator.x} - {calculator.y}: {calculator.Action("-")}");
Console.WriteLine($"{calculator.x} * {calculator.y}: {calculator.Action("*")}");
Console.WriteLine($"{calculator.x} / {calculator.y}: {calculator.Action("/")}");
Console.WriteLine($"{calculator.x} % {calculator.y}: {calculator.Action("%")}");

Console.WriteLine("----------------Operator overloading-----------------");
Console.WriteLine($"Calc1: {calculator.Display()}");
Console.WriteLine($"Calc2: {calc1.Display()}");
Console.WriteLine($"Operator +: {calculator + calc1}");
Console.WriteLine($"Operator -: {calculator - calc1}");

//My Delegate
Console.WriteLine("----------------Delegate-----------------");
MyDelegate myDelegate = new MyDelegate();
MyDelegate.delegateCallMethod calculate = new MyDelegate.delegateCallMethod(myDelegate.add);
calculate(10, 5);

calculate = new MyDelegate.delegateCallMethod(myDelegate.sub);
calculate(10, 5);

//Abstract
Console.WriteLine("----------------Abstract-----------------");
Bike trumph = new Bike(true,"Trumph",2);
Console.WriteLine(trumph.ToString());
trumph.Start();
trumph.TurnLeft();
trumph.TurnRight();
trumph.Stop();

Console.WriteLine("---------------------------------");
Rikshaw evGreenRikshaw = new Rikshaw(false, "EV Green Rikshaw", 3);
Console.WriteLine(evGreenRikshaw.ToString());
evGreenRikshaw.Start();
evGreenRikshaw.TurnLeft();
evGreenRikshaw.TurnRight();
evGreenRikshaw.Stop();

Console.WriteLine("---------------------------------");
Truck evGreenTruck = new Truck(false, "EV Green Truck", 6);
Console.WriteLine(evGreenTruck.ToString());
evGreenTruck.Start();
evGreenTruck.TurnLeft();
evGreenTruck.TurnRight();
evGreenTruck.Stop();

//Interface
Console.WriteLine("----------------Multiple Interface-----------------");
Player chaitanya = new Player("Chaitanya", ".NET Department");
chaitanya.GetDetail();
chaitanya.Run();
chaitanya.Happy();

Player player2 = new Player("player2", "Player2 Desciption");
player2.GetDetail();
player2.Walk();
player2.Happy();

//File
Console.WriteLine("----------------File-----------------");
FileHandling fileHandling = new FileHandling();
fileHandling.WriteToFile("test.txt", "Hello World this is line 1\nLine 2"); //Write to file
fileHandling.ReadFile("test.txt", out string msg);
Console.WriteLine(msg);

//Collection
Console.WriteLine("\n----------------Collection List-----------------\n");
MyCollection myCollection = new MyCollection();
myCollection.GetAllEmployee();

Console.WriteLine("\n----------------Insert Mayur-----------------\n");

Department dept = new Department();
dept.DepartmentID = 99;
dept.DepartmentName = "Testing";

Employee emp = new Employee();
emp.EmployeeName = "Mayur";
emp.Department = dept;

myCollection.ManageEmployee(emp);
myCollection.GetAllEmployee();

Console.WriteLine("\n----------------Insert test and department as null-----------------\n");
Employee emp1 = new Employee();
emp1.EmployeeName = "Test";

myCollection.ManageEmployee(emp1);
myCollection.GetAllEmployee();

Console.WriteLine("\n----------------Update CHAITANYA-----------------\n");
Employee emp2 = new Employee();
emp2.EmployeeID = 1;
emp2.EmployeeName = "CHAITANYA";
myCollection.ManageEmployee(emp2);
myCollection.GetAllEmployee();

Console.WriteLine("\n----------------Department .NET wise Employee-----------------\n");
myCollection.DepartmentwiseEmployee(".NET");

Console.WriteLine("\n----------------Delete by ID: 10-----------------\n");
myCollection.DeleteEmployee(10);
myCollection.GetAllEmployee();

Console.WriteLine("\n----------------Delete all employee that has null department-----------------\n");
myCollection.DeleteAllNullDepartment();
myCollection.GetAllEmployee();

Console.WriteLine("\n----------------Sort by name--------------\n");
myCollection.SortByName();

Console.WriteLine("\n----------------Order by desc--------------\n");
myCollection.OrderByDesc();

Console.WriteLine("\n----------------Order by specific field : DepartmentName--------------\n");
myCollection.OrderBySpecificField(emp => emp.Department.DepartmentName);

Console.WriteLine("\n----------------Department group wise employee--------------\n");
myCollection.GroupByDepartment();

Console.WriteLine("\n----------------JoinEmployeeWithDepartment--------------\n");
myCollection.JoinEmployeeWithDepartment();

Console.WriteLine("\n----------------GroupJoinEmployeeWithdepartment--------------\n");
myCollection.GroupJoinEmployeeWithdepartment();

Console.WriteLine("\n----------------Select method--------------\n");
myCollection.SelectMethod();

Console.WriteLine("\n----------------MAX EmployeeID--------------\n");
myCollection.MaxEmployeeID();

Console.WriteLine("\n----------------MIN EmployeeID--------------\n");
myCollection.MaxEmployeeID();

Console.WriteLine("\n----------------Dictionary Implemetation--------------\n");
myCollection.DictionaryImplemetation();