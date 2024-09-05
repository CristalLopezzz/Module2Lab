//Declaring variables
int numberOfGuests;
int slicesPerGuest = 3; // Assuming each guest eats 3 slices
int slicesPerPizza = 8; // Standard pizza has 8 slices

Console.Write("Enter the number of guests: ");

//Using the parse method will convert string to int
numberOfGuests = int.Parse(Console.ReadLine());

//Calculating the number of slices needed
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//Calculating the number of pizza required
int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicesPerPizza);

//Final output in calculation
Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");
