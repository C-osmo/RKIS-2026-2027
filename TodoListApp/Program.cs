Console.WriteLine("Работу выполнили Деркач и Остапенко");
Console.WriteLine("Введите вашу фамилию");
String firstName = Console.ReadLine();
Console.WriteLine("Введите ваше имя");
String secondName = Console.ReadLine();
Console.WriteLine("Введите год рождения");
int year = int.Parse(Console.ReadLine());
int number = (int)2026;
int age = number - year;
Console.WriteLine($"{firstName} {secondName} возраст: {age}");

