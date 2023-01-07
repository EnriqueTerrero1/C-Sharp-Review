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




//WORKING WITH STRING 
// is good to know that a string is a array of character


//Substring,IndexOf,LastIndexOf, string methods

//Substring method 

string testString = "this is some string to use it for our example";

//with variableString.substring(int)  this method is going to return you
// a new string from the int lenght to the lenght n-1;
string partWithoutLength = testString.Substring(10);


string partWithLength = testString.Substring(5,10);

Console.WriteLine(partWithoutLength);
Console.WriteLine(partWithLength);

//IndexOf

int charPosition = testString.IndexOf('i');
Console.WriteLine(charPosition);
int stringPosition = testString.IndexOf("some");
Console.WriteLine(stringPosition);
int charPosWithtartIndex = testString.IndexOf('s', 10);
Console.WriteLine(charPosWithtartIndex);
int stringPosWithStartIndex = testString.IndexOf("some", 10);

int lasPosition = testString.LastIndexOf('o');



//Constains,StartsWith,EndsWith

bool containsResult = testString.Contains("for");

bool startWithResults = testString.StartsWith('t');
bool endWithResults = testString.EndsWith("example");

// Remove,Insert

string loweredString = testString.Remove(10);
string loweredStringWithCount = testString.Remove(10, 9);


string stringWithInsert = testString.Insert(13, "Updated");

Console.WriteLine(stringWithInsert);


/// real examples

Console.WriteLine("Enter your full name");
string fullName = Console.ReadLine();

int blankPosition = fullName.IndexOf(' ');
string name = fullName.Substring(0, blankPosition);
string lastName = fullName.Substring(blankPosition+1);
Console.WriteLine(lastName);


Console.WriteLine("Enter a sentence");

string completeSentence = Console.ReadLine();

int firstSpace = completeSentence.IndexOf(' ');

completeSentence = completeSentence.Remove(0, firstSpace+1);

int lastSpace = completeSentence.LastIndexOf(' ');

completeSentence = completeSentence.Remove(lastSpace);

Console.WriteLine(completeSentence);

