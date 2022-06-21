
Console.WriteLine("Welcome to the room calculator. \nIs the room 2D or 3D?");
string response = Console.ReadLine();
if(response == "2D")
{
    Console.WriteLine("What is the length?");
    double length = double.Parse(Console.ReadLine());
    Console.WriteLine("What is the width?");
    double width = double.Parse(Console.ReadLine());
    double area = length * width;
    double perimeter = length * 2 + width * 2;
    Console.WriteLine($"The area of the room is {area} sq feet. \n The perimeter of the room is {perimeter} feet.");
    if(area >= 650)
    {
        Console.WriteLine("This is a large-sized room.");
    }
    if (area < 650 && area > 250)
    {
        Console.WriteLine("This is a medium-sized room.");
    }
    if (area <= 250)
    {
        Console.WriteLine("This is a small-sized room.");
    }
    Console.Read();


}
else if (response == "3D")
{
    Console.WriteLine("What is the length?");
    double length = double.Parse(Console.ReadLine());
    Console.WriteLine("What is the width?");
    double width = double.Parse(Console.ReadLine());
    Console.WriteLine("What is the height?");
    double height = double.Parse(Console.ReadLine());
    double area = length * width;
    double perimeter = length * 2 + width * 2;
    double volume = length * width * height;
    double surfaceArea = 2 * (length * width + length * height + width * height);

    Console.WriteLine($"The volume of the room is {volume} cubic feet. \nThe area of the room is {area} sq feet. \nThe perimeter of the room is {perimeter} feet. \n The surface area is {surfaceArea}.");
    if (area >= 650)
    {
        Console.WriteLine("This is a large-sized room.");
    }
    if (area < 650 && area > 250)
    {
        Console.WriteLine("This is a medium-sized room.");
    }
    if (area <= 250)
    {
        Console.WriteLine("This is a small-sized room.");
    }
    Console.Read();
}
else
{
    Console.WriteLine("Invalid response.");
    Console.Read();
}