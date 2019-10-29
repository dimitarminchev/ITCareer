# 451. Дефиниране на интерфейс IPerson

Дефинирайте интерфейс **IPerson** със свойства **Name** и **Age**. Дефинирайте клас **Citizen**, който имплементира **IPerson** и има конструктор, който взема **string** с името и **int** с възрастта.

За да се тества успешно задача, добавете следния код към Main метода си:
```
public static void Main(string[] args)
{
    Type personInterface = typeof(Citizen).GetInterface("IPerson");
    PropertyInfo[] properties = personInterface.GetProperties();
    Console.WriteLine(properties.Length);
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    IPerson person = new Citizen(name, age);
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
}
```
Ако сте дефинирали интерфейса и сте го имплементирали правилно, тестовете би трябвало да минат.

| Вход  | Изход |
|-------|-------|
| Pesho | 2     |
| 25    | Pesho |
|       | 25    |