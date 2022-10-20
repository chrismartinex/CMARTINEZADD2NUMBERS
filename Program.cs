//Chris Martinez
// GitHub Challenge ADD TWO NUMBERS
// 10/18/22
// adding two numbers is the main function of this game, now I can also count with the added feature, that which is Data Validation.

string numberOne = "";
string numeroTwo = "";
int Num1 = 0;
int Num2 = 0;

Console.Clear(); Console.WriteLine("lets add two numbers");

bool validation = true;
while (validation == true)
{
 Console.WriteLine("Enter First Number"); 
 numberOne = Console.ReadLine();
 //numberone = "dog";
//    num1 =  false           "dog"             
 bool num1 = Int32.TryParse(numberOne, out Num1);
 if (num1 == true)
 {
  validation = false;
 }
}
validation = true;

while (validation == true)
{
 Console.WriteLine("Enter Second Number"); numeroTwo = Console.ReadLine();
 bool num2 = Int32.TryParse(numeroTwo, out Num2);
 if (num2 == true)
 {
  validation = false;
 }
}
// int Num1 = Convert.ToInt32(numberOne);
// int Num2 = Convert.ToInt32(numeroTwo);


Console.WriteLine("Your sum is:" + (Num1 + Num2));


