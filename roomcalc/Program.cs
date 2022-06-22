Console.WriteLine("Welcome to the room calculator.");

//ask for values
Console.WriteLine("Please enter the length of the room.");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the width of the room.");
double width = double.Parse(Console.ReadLine());

//Calculations
double area = length * width;
double perimeter = 2 * (length + width);

//Display Results
Console.WriteLine("Area:" + area);
Console.WriteLine("Perimeter:" + perimeter);