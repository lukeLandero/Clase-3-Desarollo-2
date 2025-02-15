using Clase_3_Desarollo_2;

//Declaration only:
float temperature;
string name;
MyClass myClass;

//Declaration with initializers (four examples):
char firstLetter = 'C';
var limit = 3;
int[] source = { 0, 1, 2, 3, 4, 5 };
var query = from item in source
            where item <= limit
            select item;

//Implicit conversion. A long can hold any value an int can hold, and more!
int num = 2147483647;
long bigNum = num;

//Conversiones explicitas
//class test 
//{
// static void Main()
//{
double x = 1234.7;
int a;
//Cast double to int. 
a = (int)x;
System.Console.WriteLine(a);
//}
//}

//Operador de incremento ++
int i = 3;
Console.WriteLine(i);   // output: 3
Console.WriteLine(i++); // output: 3
Console.WriteLine(i);   // output: 4

double b = 1.5;
Console.WriteLine(b);   // output: 1.5
Console.WriteLine(++b); // output: 2.5
Console.WriteLine(b);   // output: 2.5

//Operador de decremento --
int d = 3;
Console.WriteLine(d);   // output: 3
Console.WriteLine(d--); // output: 3
Console.WriteLine(d);   // output: 2

double e = 1.5;
Console.WriteLine(e);   // output: 1.5
Console.WriteLine(--e); // output: 1.5
Console.WriteLine(e);   // output: 0.5

//Operadores aritmeticos
// operador + y operador - unario
Console.WriteLine(+4);      // output: 4

Console.WriteLine(-4);      // output: -4 
Console.WriteLine(-(-4));   // output: 4

uint f = 5;
var g = -f;
Console.WriteLine(g);           // output: -5
Console.WriteLine(g.GetType()); // output: System.Int64

Console.WriteLine(-double.NaN); // output: NaN

//Operador de multiplicacion *
Console.WriteLine(5 * 2);           // output: 10
Console.WriteLine(0.5 * 2.5);       // output: 1.25
Console.WriteLine(0.1m * 23.4m);    // output: 2.34

//Operador de division /
Console.WriteLine(13 / 5.0);        // output: 2.6

int h = 13;
int j = 5;
Console.WriteLine((double)h / j);   // output: 2.6

//Operador de resto %
Console.WriteLine(5 % 4);   // output: 1
Console.WriteLine(5 % -4);  // output: 1
Console.WriteLine(-5 % 4);  // output: -1
Console.WriteLine(-5 % -4); // output: -1

//Instruccion if
DisplayWeatherReport(15.0); // output: Cold.
DisplayWeatherReport(24.0); // output: Perfect!

void DisplayWeatherReport(double tempInCelsius)
{
    if (tempInCelsius < 20.0)
    {
        Console.WriteLine("Cold.");
    }
    else
    {
        Console.WriteLine("Perfect!");
    }
}
//
DisplayMeasurement(45); // output: The measurement value is 45
DisplayMeasurement(-3); // outout: Warning: not acceptable value! The measurement value is -3

void DisplayMeasurement(double value)
{
    if (value < 0 || value > 100)
    {
        Console.WriteLine("Warning: not acceptable value! ");
    }
    Console.WriteLine($"The measurement value is  {value}");
}

//Instrucciones de seleccion if, if else, y switch.
DisplayCharacter('f');  // output: A lowercase letter: f
DisplayCharacter('R');  // output: An uppercase letter: R
DisplayCharacter('8');  // output: A digit: 8
DisplayCharacter(',');  // output: Not alphanumeric character: ,

void DisplayCharacter(char ch)
{
    if (char.IsUpper(ch))
    {
        Console.WriteLine($"An uppercase letter: {ch}");
    }
    else if (char.IsLower(ch))
    {
        Console.WriteLine($"A lowercase letter: {ch}");
    }
    else if (char.IsDigit(ch))
    {
        Console.WriteLine($"A digit: {ch}");
    }
    else
    {
        Console.WriteLine($"Not alphanumeric character: {ch}");
    }
}

//Instruccion switch
DisplayMeasurement2(-4);            // Output: Measured value is -4; too low.
DisplayMeasurement2(5);             // Output: Measured value is 5.
DisplayMeasurement2(30);            // Output: Measured value is 30; too high.
DisplayMeasurement2(double.NaN);    // Output: Failed measurement.

void DisplayMeasurement2(double measurement)
{
    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; too low.");
            break;

        case > 15.0:
            Console.WriteLine($"Measured value is {measurement}; too high");
            break;

        case double.NaN:
            Console.WriteLine($"Failed measurement.");
            break;

        default:
            Console.WriteLine($"Measured value is {measurement}.");
            break;
    }
}

// instrucciones de iteracion for
for (int k = 0; k < 3; k++)
{
    Console.Write(k);
}
Console.WriteLine();
// Output: 012

// instrucciones de iteracion foreach
List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}
Console.WriteLine();
// Output: 0 1 1 2 3 5 8 13

//Instruccion do
int l = 0;
do
{
    Console.Write(l);
    l++;
} while (l < 5);
Console.WriteLine();
//Output: 01234

//Instruccion while
int m = 0;
while (m < 5)
{
    Console.Write(m);
    m++;
}
Console.WriteLine();
//Output: 01234


// METODO

// Call the static method to use NameManager
NameManagerHelper.DisplayNames();
