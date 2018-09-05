# 452. Множествена имплементация
Използвайки кода от предната задача, дефинирайте интерфейс **IIdentifiable** със свойство **Id** от тип **string** и интерфейс **IBirthable** със свойство **Birthdate** от тип **string** и ги имплементирайте в клас **Citizen**. Пренапишете конструктора, така че да приема новите параметри.

За да се тества успешно задача, добавете следния код към **Main** метода си:
```
public static void Main(string[] args)
{
    Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
    Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
    PropertyInfo[] properties = identifiableInterface.GetProperties();
    Console.WriteLine(properties.Length);
    Console.WriteLine(properties[0].PropertyType.Name);
    properties = birthableInterface.GetProperties();
    Console.WriteLine(properties.Length);
    Console.WriteLine(properties[0].PropertyType.Name);
    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    string id = Console.ReadLine();
    string birthdate = Console.ReadLine();
    IIdentifiable identifiable = new Citizen(name, age,id, birthdate);
    IBirthable birthable = new Citizen(name, age, id, birthdate);
}
```
Ако сте дефинирали интерфейса и сте го имплементирали правилно, тестовете би трябвало да минат.

| Вход       | Изход  |
|------------|--------|
| Pesho      | 1      |
| 25         | String |
| 9105152287 | 1      |
| 15/05/1991 | String |

