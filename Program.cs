using System;

System.Console.WriteLine("Enter firstnumber: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter secondnumber: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());

if(firstnumber > secondnumber)
{
    System.Console.WriteLine("First number is bigger.");
}
else if(firstnumber == secondnumber)
{
    System.Console.WriteLine("Both number is equel.");
}
else
{
    System.Console.WriteLine("Second number is bigger.");
}



// System.Console.WriteLine($"1st number is greater then 2dn number: {firstnumber > secondnumber}");
// System.Console.WriteLine($"1st number is les then 2dn number: {firstnumber < secondnumber}");
// System.Console.WriteLine($"1st number is the same with 2dn number: {firstnumber == secondnumber}");
// System.Console.WriteLine($"1st number is greater or same then 2dn number: {firstnumber >= secondnumber}");
// System.Console.WriteLine($"1st number is les or same 2dn number: {firstnumber <= secondnumber}");
// System.Console.WriteLine($"1st number is not equel 2dn number: {firstnumber != secondnumber}");
