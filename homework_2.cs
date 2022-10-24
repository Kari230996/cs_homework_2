
// Первое задание

Console.WriteLine("Write a 3-digit-number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(Math.Abs(number) < 1000)
{
while(Math.Abs(number) > 999)
{
number = number / 10;
}

Console.WriteLine($"The second-digit of {number} is {(number % 100) / 10}");
}

else
{
Console.WriteLine("Error. Write a 3-digit-number");
}
//////////////////////////////////////////////////////////////////////////////////
/*
// Второе задание

Console.WriteLine("Write a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(Math.Abs(number) > 99)
{
while(Math.Abs(number) > 999)
{
number = number / 10;
}
int thirdNum = number % 10;
Console.WriteLine(thirdNum);
}

else
{
Console.WriteLine("There's no third digit in this number");
}

*/
/////////////////////////////////////////////////////////////////////////
/*
// Третье задание

Console.WriteLine("Write a number(day) of the week. We will check if this day is considered as weekend");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8) {
    if (number == 6 || number == 7) {
        Console.WriteLine($"Yes, day {number} is a weekend");
    }
    else {
        Console.WriteLine($"No, day {number} is NOT a weekend");
    }
} else {
    Console.WriteLine("There's no such a day of week");
}

*/