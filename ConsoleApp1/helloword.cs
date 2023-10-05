// Aula 01 
// Console.WriteLine("I like Pizza!");
// Console.WriteLine("It's really good!");
// Console.Beep();

// Aula 02
// Console.Write("hey");
// Console.WriteLine("Hello");
// // backslash + a char. Ex: \t represents a tab
// Console.WriteLine("\tBroCode");
// Console.WriteLine("\bBroCode");
// Console.WriteLine("Bro\nCode");

// Aula 03
// int x; // declarations
// x = 123; // initialization
// int y = 444; // initialization + declaration
// int z = x + y;
//
// int age = 21; // whole integer
// double height = 300.5;
// bool alive = false; // true or false
// char symbol = '@';
// String name = "Bro";
// Console.WriteLine("Hello " + name);
// Console.WriteLine("Your age is "+ age);
// Console.WriteLine("Your height is "+ height + "cm");
// Console.WriteLine("Are you Alive? " + alive);
// Console.WriteLine("Your symbol is: " + symbol);
// String username = symbol + name;
// Console.WriteLine("Your user is: " + username);

// Aula 04 
//
// // constants = immutable values which are know at compile time and do not change for the life of the program
// const double pi = 3.14159;
// pi = 420; // different of JavaScript that this variable can change

// Aula 05 
// double a = 3.14;
// int b = Convert.ToInt32(a);
//
// int c = 123;
// double d = Convert.ToDouble(c);
//
// int e = 321;
// String f = Convert.ToString(e);
//
// String g = "$";
// char h = Convert.ToChar(g);
//
// String i = "false";
// bool j = Convert.ToBoolean(i);
//
//
// Console.WriteLine(j.GetTypeCode());

// Aula 06
// Console.WriteLine("What's your name? ");
// String name = Console.ReadLine();
// Console.WriteLine("Hello, " + name);
//
// Console.WriteLine("What's your age? ");
// int age = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("You are  " + age + " years old");

// Aula 07
int friends = 10;
// friends = friends + 2;
// friends += 2;
// friends++; // increment 1

// friends = friends - 1;
// friends -= 1;
// friends--;

// friends = friends * 2;
// friends *= 2;

// friends = friends / 2;
// friends /= 2;

// int remainder = friends % 3; // restante da divisão
//
// Console.WriteLine(friends);

// Aula 08
// double x = 3.14;
// double y = 3.99;
// double y = 5;
// double a = Math.Pow(x, 2); // x elevado a 2
// double b = Math.Sqrt(x); // square root (raíz quadrada) 

// double c = Math.Abs(x); // aboslute value, negative becomes positive
// double d = Math.Round(x); // round = arredondamento 
// double e = Math.Ceiling(x); // ceiling = arredondamento para cima
// double f = Math.Floor(x);  // floor = arredondmento para baixo
// double g = Math.Max(x, y); // max value 
// double g = Math.Min(x, y); // min value

// Aula 09
// Random random = new Random();
// // int num = random.Next(1, 7);  // Random number between 1 and 6 (1 until 6)
// double num = random.NextDouble(); // Random number between 0 and 1 
// Console.WriteLine(num);

// Aula 10
// Console.WriteLine("Hypotenuse calculator");
//
// Console.WriteLine("Enter the leg A:");
// int legA = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Enter the leg B:");
// int legB = Convert.ToInt32(Console.ReadLine());
//
// double hypotenuse = Math.Sqrt(Math.Pow(legA, 2) + Math.Pow(legB, 2));
// Console.WriteLine("The hypotenuse is: "+ hypotenuse);

// Aula 11
String fullName = "Bro Code";
// fullName = fullName.ToUpper(); // all the string becomes upper case
// fullName = fullName.ToLower(); // all the string becomes lower case

// String phoneNumber = "123-456-7890";
// phoneNumber = phoneNumber.Replace("-", "");
// Console.WriteLine(phoneNumber);

// String userName = fullName.Insert(0, "@");
// Console.WriteLine(userName);
// Console.WriteLine(fullName.Length);

// String firstName = fullName.Substring(0,3 );
// Console.WriteLine(firstName);
// String lastName = fullName.Substring(4,4);
// Console.WriteLine(lastName);