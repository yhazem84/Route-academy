//Assignment No.1
#region Q1
Book b01 = new Book();
b01.pages = 10;
b01.title = "Title";
object obj01 = b01;
Console.WriteLine("obj01 is a " + obj01);
#endregion
Console.WriteLine("---------------------------------");
#region Q2
Console.WriteLine("b01 string = " + b01.ToString());
Console.WriteLine("b01 equals itself is " + b01.Equals(b01));
Console.WriteLine("Address of b01 is " + b01.GetHashCode());
Console.WriteLine("Type of b01 is " + b01.GetType());

#endregion
Console.WriteLine("---------------------------------");
#region Q3
int num01 = 10;
int num02 = 0;
try
{
    Console.WriteLine("num01/num02 = " + num01 / num02);
}
catch (Exception e)
{
    Console.WriteLine("Can not divide by zero");
}
finally
{
    Console.WriteLine("Done");
}
#endregion
Console.WriteLine("---------------------------------");
#region Q4
int pages = 300;
double pagesDouble;
pagesDouble = pages;
Console.WriteLine("pages = " + pagesDouble);
#endregion
Console.WriteLine("---------------------------------");
#region Q5
double price = 49.99;
int priceInteger = (int)price;
Console.WriteLine("price = " + priceInteger);
#endregion
Console.WriteLine("---------------------------------");
#region Q6
string pagesText = "464";
int pagesInteger = Convert.ToInt32(pagesText);
Console.WriteLine("pagesText = " + pagesInteger);
#endregion
Console.WriteLine("---------------------------------");
#region Q7
#region Part1
string yearText = "2023";
int yearInt = int.Parse(yearText);
Console.WriteLine("Year = " + yearInt);
#endregion
#region Part2
string badText = "abc";
int num;
bool newText = int.TryParse(badText, out num);
Console.WriteLine("Invalid number");
#endregion
#endregion
Console.WriteLine("---------------------------------");
#region Q8
int pages02 = 464;
Console.WriteLine(pages02.ToString().GetType());
#endregion
Console.WriteLine("---------------------------------");
#region Q9
int copies = 100;
object boxedCopies = copies;
int unboxedCopies = (int)boxedCopies;
Console.WriteLine("Boxed copies = " + boxedCopies);
Console.WriteLine("Unboxed copies = " + unboxedCopies);
#endregion
Console.WriteLine("---------------------------------");
class Book
{
    public string title;
    public int pages;
} 




