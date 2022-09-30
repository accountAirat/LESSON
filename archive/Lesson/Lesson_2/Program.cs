Console.Clear();

int number = new Random().Next(10, 1000);

Console.WriteLine(number);

int firstDigit = number % 10;
int lastDigit = number / 10 % 10;
int Digit3 = number / 100 % 10;


