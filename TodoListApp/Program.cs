using System;
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

    string[] parts = input.Split(' ', 2);
    string command = parts[0].ToLower();

    switch (command)
    {
        case "help":
            Console.WriteLine("help — список команд");
            Console.WriteLine("profile — данные пользователя");
            Console.WriteLine("add \"задача\" — добавить задачу");
            Console.WriteLine("view — показать задачи");
            Console.WriteLine("exit — выход");
  
            break;

        
        case "add":
            if (parts.Length < 2)
                {
                    Console.WriteLine("Ошибка: укажите текст задачи в кавычках. Формат: add \"текст задачи\"");
                    break;
                }
                string task = input.Substring(4).Trim('"');

            if (taskCount >= todos.Length)
                {
                    string[] newTodos = new string[todos.Length * 2];
                        for (int i = 0; i < todos.Length; i++)
                        {
                            newTodos[i] = todos[i];
                        }
                        todos = newTodos;
                }

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