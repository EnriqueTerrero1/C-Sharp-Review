// See https://aka.ms/new-console-template for more information
Console.WriteLine("Implicit conversion");

double xb = 12.45;
int c = 10;

xb = xb + c;

Console.WriteLine("B is "+ xb);

//2 variable stored in a variable

int y = 5;
int x = 21;
double z;
z = y / x;

//3 the expression is evaluated from the right first so
// as the operation is between 2 integer number, the result is converted
//into a integer , later the compiler convert it in double 
//but the result is already truncated as a integer
// we can un explicit conversion and cast the result to get a double


double num3 = (double)x / y;


//EXPLICIT CONVERSION IN C#


//Using CAST

int a;
double b = 10.7;

a = (int)b;


//USING THE CONVERT CLASS IN C#
int num1 = 15;
//string s = num1; this is a imposible operation because
//with are trying to convert  a integer into a string

//This is a class conversion
string s = Convert.ToString(num1);
string s2 = num1.ToString();
double amount = 200.33;
int salary = Convert.ToInt32(amount);



