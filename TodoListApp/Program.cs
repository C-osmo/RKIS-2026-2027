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

string[] todos = new string[2];
int taskCount = 0;

while (true)
{
    Console.Write("Введите команду: ");
    string input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input)) continue;

    string parts = input.Split(' ', 2);
    string command = parts.ToLower();

    switch (command)
    {
        case "help":
            Console.WriteLine("help — список команд; profile — данные пользователя; add \"задача\" — добавить задачу; view — показать задачи; exit — выход");
            break;
        
        case "add":
            if (parts.Length < 2)
                {
                    Console.WriteLine("Ошибка: укажите текст задачи в кавычках. Формат: add \"текст задачи\"");
                    break;
                }
                string task = parts.Trim('"');

                todos[taskCount++] = task;
                Console.WriteLine("Задача добавлена.");
                break;

        case "profile":
            Console.WriteLine($"{firstName} {secondName} возраст: {age}");
            break;
        
        case "view":
            if (taskCount == 0)
            {
                Console.WriteLine("Список задач пуст.");
            }
            else
            {
                for (int i = 0; i < taskCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }
            break;
        
        case "exit":
            Console.WriteLine("Завершение программы...");
            return;
        
        default:
            Console.WriteLine("Неизвестная комманда. Введите help, для отображения списка команд");
            break;
    }
}