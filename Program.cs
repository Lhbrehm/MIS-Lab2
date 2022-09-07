// See https://aka.ms/new-console-template for more information

Console.WriteLine("How many total rooms are there?");
double totalRooms = double.Parse(Console.ReadLine());

Console.WriteLine("How many rooms are booked?");
double roomsBooked = double.Parse(Console.ReadLine()); 


double HOURS_PER_ROOM = 1.25;
double CLEANERS_WAGE = 12.37;

 //Creating the variables
double occupancyRate = (roomsBooked/totalRooms);
double hoursToClean = (roomsBooked*HOURS_PER_ROOM);
double costOfCleaning = (hoursToClean*CLEANERS_WAGE);

 //Delivering needed information
Console.WriteLine("It will take " + hoursToClean + " hours to clean the Hotel.");
Console.WriteLine("The cleaners will cost $" + costOfCleaning);
Console.WriteLine("The occupancy rate will be " + occupancyRate);