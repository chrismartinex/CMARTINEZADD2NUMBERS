//Chris Martinez
// GitHub Challenge ADD TWO NUMBERS
// 10/18/22

string numberOne ="";
string numeroTwo ="";
int wht = 0;

Console.Clear();Console.WriteLine ("lets add two numbers");

 bool validation = true; 
 while (validation == true)
{
Console.WriteLine("Enter44 First Number"); numberOne = Console.ReadLine();
bool num1 = Int32.TryParse (numberOne, out wht);
if (num1 == true)
{
 validation = false;
}}
 validation = true;

 while(validation == true){
 Console.WriteLine("Enter Second Number"); numeroTwo = Console.ReadLine();
bool num2 = Int32.TryParse (numeroTwo, out wht);
if (num2 == true)
{
 validation = false;
}
}
 int Num1 = Convert.ToInt32(numberOne);
  int Num2 = Convert.ToInt32(numeroTwo);


Console.WriteLine("Your sum is:" + (Num1 + Num2));


