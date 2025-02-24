// Ini adalah komentar untuk melakukan print
Console.WriteLine("Enter username:");
// Membuat variabel username untuk menerima input user
string userName = Console.ReadLine();
// Melakukan print panjang string input
Console.WriteLine("The length of the input string is: " + userName.Length);
// Melakukan print dengan menggabungkan string dengan input user
Console.WriteLine("Username is: " + userName);

int myNum = 5;
myNum = myNum + 3;
int myNum2 = 3 * 4;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";

int time = 22;
if (time < 10)
{
    Console.WriteLine("Good morning.");
}
else if (time < 20)
{
    Console.WriteLine("Good day.");
}
else
{
    Console.WriteLine("Good evening.");
}
// Outputs "Good evening."

string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
for (int i = 0; i < cars.Length; i++)
{
    Console.WriteLine(cars[i]);
}