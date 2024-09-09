double tip, sand, top, discount, total;
int numSand, numTop;

discount = 0.9;
sand = 4.75;
top = 0.55;
Console.Clear();
Console.WriteLine("How Many Sandwiches Would you like?");

numSand = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("How Many Toppings Would you like?");

numTop = int.Parse(Console.ReadLine());

total = (numSand * sand + numTop * top) * discount;
Console.Clear();
Console.Write("Your Subtotal is $");
total = Math.Round(total, 2);
Console.Write(total);
Console.WriteLine(". Please enter your tip, expressed as a decimal.");


tip = double.Parse(Console.ReadLine());

total = total + total *tip;

Console.Clear();
Console.Write("Your Total is $");

total = Math.Round(total, 2);
Console.WriteLine(total);

