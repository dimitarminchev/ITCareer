# Модул 3. Увод в обектно-ориентирано програмиране
[Материали](03.%20Увод%20в%20ООП.%20Материали.zip) |
[Задачи](03.%20Увод%20в%20ООП.%20Задачи.pdf) |
[Решения](03.%20Увод%20в%20ООП.%20Решения.zip)

## Съдържание
1. [Дефиниране на класове](1.%20Дефиниране%20на%20класове)
2. [Полета и методи](2.%20Полета%20и%20методи)
3. [Енкапсулация на данни](3.%20Енкапсулация%20на%20данни)
4. [Статични полета и методи](4.%20Статични%20полета%20и%20методи)
5. [Допълнителни задачи](5.%20Допълнителни%20задачи)
6. [Подготовка за изпит](6.%20Подготовка%20за%20изпит)

## 1. Дефиниране на класове

### Абстрактни типове данни
- Абстрактните типове данни описват: множество от данни и възможните операции в рамките на този тип.
- Абстрактните типове данни ни позволяват да опишем конкретна структура, без обаче да се интересуваме от детайлите в тази реализация.

### Дефиниране на прост клас
- Класовете служат за създаване на **имплементация** на aбстрактни типове данни
- Класовете ни дават начин да опишем и създадем обекти
```cs
class Dice 
{
  …
}
```

### Именуване на класове
- Класовете са **PascalCase**
- Използвайте описателни съществителни
- Избягвайте абревиатури 
```cs
class Dice { … }
class BankAccount { … }
class IntegerCalculator { … }
```

### Членове на класа
- **Класа** съдържа състояния и действия
- **Полетата** съдържат състоянието
- **Методите** описват действието
```cs
class Dice {
  int sides;
  string type;
  void Roll() { … }
}
```

### Създаване на обект
Класът може да има много **инстанции** (обекти)
```cs
class Program 
{
  public static void Main() 
  {
    Dice diceD6 = new Dice();
    Dice diceD8 = new Dice();
  }
}
```

### Обектна референция
Декларирането на променлива създава **референция** 
```cs
Dice diceD6 = new Dice();
```

### Класове и Обекти
Класовете ни позволяват да описваме и създаваме **обекти**.
Обектът е една инстанция на класа.

### Задача: Дефинирайте клас Person
Дефинирайте клас **Person**, като за него пазете информация за името и възрастта на човек и реализирайте единствено действието **IntroduceYourself**(), което отпечатва представяне на човека. След това създайте и използвайте обект от класа **Person**.
```cs
class Person {
  private string name;
  private int age;
  public String Name { //реализираме свойство Name
    get { return name; }
    set { name = value; }
  }
  public int Age { //реализираме свойство Age
    get { return age; }
    set { age = value; }
  }
  public void IntroduceYourself() {
    Console.WriteLine("Здравейте! Аз съм {0} и съм на {1} години.", name, age);
  }
}
```
Сега е време да използваме класа и да направим обект в Main метода ни в **Program.cs**:
```cs
static void Main(string[] args) 
{
  Person firstPerson = new Person();
  firstPerson.Name = "Гошо";
  firstPerson.Age = 15;
  firstPerson.IntroduceYourself();
}
```
За момента няма да акцентираме на теоретичния смисъл на кода от по-рано – той ще се уточни допълнително в следващите теми.

### Задача: Човекът и неговите пари
Дефинирайте клас **Person**, като за него пазете информация за името и възрастта на човек, както и информация за банкови сметки (клас **BankAccount**). Направете метод **GetBalance**(), който дава информация каква е общата стойност на парите, които притежава човек.

- Първо ще създадем файл за клас **BankAccount**.
- След това ще направим възможно в **Person** да се пази списък от банковите сметки на човека
- Последно в класа **Person** ще добавим метод, който изчислява сумата от балансите на всички смекти в списъка

```cs
class BankAccount 
{
  private int id;
  private double balance;

  public int ID 
  {
    get { return id; }
    set { id = value; }
  }

  public double Balance 
  {
    get { return balance; }
    set { balance = value; }
  }
}
```
В **Person.cs** добавете поле, в което ще се пази списък от банковите сметки, както и свойство:
```cs
class Person 
{
  // TODO: добавете полета за име и възраст
  private List<BankAccount> accounts = new List<BankAccount>();
  // TODO: добавете свойства за име и възраст
  public List<BankAccount> Accounts 
  {
    get { return accounts; }
    set { accounts = value; }
  }
}
```
В **Person.cs** добавете метода, който ще изчислява стойността на сумата от балансите на всички сметки:
```cs
class Person 
{
  // ...
  public double GetBalance() 
  {
    return accounts.Sum(element => element.Balance);
  }
}
```

- Създайте три обекта от клас **Person** в **Main**().
- Създайте един обект от клас **BankAccount**, задайте му **ID** и баланс и го добавете към първия човек, използвайки метода **Add**() - не забравяйте, че .**Accounts** е списък и има метод **Add**()
- Аналогично за втория човек създайте две сметки и му ги добавете, а за третия – три;
- Изкарайте трите суми – състоянието на първия, втория и третия човек

## 2. Полета и методи

### Елементи на класа
- Клас се дефинира чрез **състояние** и **поведение**
- Полетата **съхраняват състоянието**
- Методите **описват поведението**
```cs
class Dice 
{
  int sides;
  string type;
  void Roll(){ … }
}
```

### Полета
Полетата на класа имат тип и име
```cs
class Dice 
{
  string type;
  int sides;
  int[] rollFrequency;
  Person owner;
  …
}
```

### Модификатори
- Класовете и елементите на класа **имат модификатори**
- Модификаторите **определят видимостта**
```cs
public class Dice 
{
  private int sides;
  public void Roll(int amount);
}
```

### Свойства
Използва се за създаване на **методи за четене** (getters) и **методи за промяна** (setters).
```cs
class Dice 
{
  private int sides;
  public int Sides
  {
    public get { return this.sides; }
    public set { this.sides = value; }
  }
}
```

### Задача: Описване на клас Банкова сметка
Създайте клас **BankAccount** със следното съдържание:
```cs
private string id;
private decimal balance;
public string Id
{
      get { return this.id; }
      set { this.id = value; }
}
public decimal Balance
{
      get { return this.balance; }
      set { this.balance = value; }
}
```

### Методи
Те са **изпълним код** (алгоритъм), който променя състоянието:
```cs
class Dice 
{
  public int sides;
  private Random rnd = new Random();
  public int Roll()
  {
     int rollResult = rnd.Next(1, this.sides + 1); 
     return rollResult;
  }
}
```

### Задача: Getter-и и Setter-и
Създайте клас **BankAccount** със следното съдържание:
```cs
private double balance;
public void Deposit(double amount)
{
  this.balance += amount;
}
public void Withdraw(double amount)
{
  this.balance -= amount; 
}
public override string ToString()
{ 
  return $"Account {this.id}, balance {this.balance}";
}
```

### Конструктори
Специален вид методи, извиквани при създаване на обекта
```cs
class Dice
{
  int sides;
  public Dice()
  {
    this.sides = 6;
  }
}
```
Може да имате множество конструктори за даден клас
```cs
class Dice
{
  int sides;
  public Dice()
  {
    this.sides = 6;
  }
  public Dice(int sides)
  {
    this.sides = sides;
  }
}
```

### Начално състояние на обекта
Конструкторите задават началното състояние на обекта
```cs
class Dice
{
  int sides; int[] rollFrequency;
  public Dice(int sides)
  {
    this.sides = sides;
    this.rollFrequency = new int[sides];
  }
}
```

### Верижно извикване на конструктори
Конструкторите могат да се извикват един друг
```cs
class Dice 
{
  int sides;
  public Dice() : this(6)
  {
  }
  public Dice(int sides) 
  {
    this.sides = sides;
  }
}
```

### Задача: Дефиниране на клас физическо лице
Създайте клас **Person** със следното съдържание
```cs
public class Person
{
  private string name;
  private int age;
  private List<BankAccount> accounts;
  public Person(string name, int age)
      : this(name, age, new List<BankAccount>))
    {}
  public Person(string name, int age, List<BankAccount> accounts)
  {
    this.name = name;
    this.age = age;
    this.accounts = accounts;
  }
}
```

## 3. Енкапсулация на данни

### Капсулация
Процесът на **обединяване** на кода и данните в едно **цяло** (обект).

Полетата на обекта трябва да са **private**
```cs
private int age; 
```
Използване на **getters** и **setters** за достъп до данните
```cs
class Person
{
  public int Age => return this.age
}  
```

### Задача: Клас Creature
- Създайте клас **Creature**
- Creature трябва да има полета **name**, **years**, **areal**, съответно за име, възраст  и местообитание
- Създайте методи за достъп до обектите **getters** и **setters** за полетата
```cs
private string name;
private int years;
Private string areal;

public string getName()
{
  return this.name;
}
public void setName(string value)
{
  this.name = value;
}
public int getYears()
{
  return this.years;
}
public void setYears(int value)
{
  this.years = value;
}
public string getAreal()
{
  return this.areal;
}
public void setAreal(string value)
{
  this.areal = value;
}
```

### Ключова дума this
- **this** е препратка към текущия обект
- **this** може да сочи към променлива, която е инстанция (представител) на текущия клас
```cs
public Person(string name)
{
  this.name = name;
}
```
- **this** може да се предава като аргумент в метод или като извикване на конструктор 
- **this** може да се върне като стойност на метод
- **this** може да извика метод на текущия клас
```cs
private string FirstName
{ 
  get { return this.fname } 
}
public string FullName
{
  return this.FirstName + " " + this.LastName
}
```
- **this** може да извиква конструктор на текущия клас
```cs
public Person(string firstName, string lastName)
{
  this.firstName = firstName;
  this.lastName = lastName;
}
public Person (string fname, string lName, int age) : this(fName, lName);
{
  this.age = age;
}
```

### Private Модификатор за достъп 
Основен начин за капсулиране на обект и скриване на данни от външния свят
```cs
private string name;
Person (string name)
{
  this.name = name;
}
```
- Класовете и интерфейсите не могат да са **private**. Идеята за интерфейс е да се даде възможност за връзка с "външния свят" – т.е. – трябва да са достъпни 
- Могат да бъдат достъпни само в декларацията на класа

### Protected Модификатор за достъп
- Могат да бъдат достъпни само от подкласове
```cs
class Person
{
  protected string FullName { get; set; }
}
```
- Модификаторът за достъп **protected** не може да бъде приложен за класове и интерфейси
- Предотвратява външни класове да се опитват да го използват

### Internal модификатор за достъп
**internal** е модификатор по подразбиране в C#. 
```cs
class Person
{
  string Name { get; set; }
  internal int Age { get; set; }
}
```
Дава достъп на всеки друг клас в същия проект
```cs
Team rm = new Team("Real");
rm.Name("Real Madrid");
```

### Public модификатор за достъп
Клас, метод, конструктор, деклариран в **public** клас може да бъде достъпен от всеки клас, принадлежащ на .NET 
```cs
public class Person
{
  public string Name { get; set; }
  public int Age { get; set; }
}
```
- Употребата се налага ако се опитваме да достъпим **public** клас в друг namespace
- Методът **Main()** в приложението трябва да е **public**
- Интерфейсите са **public**. Тъй като смисълът им е да дават връзка с външния свят

### Задача: Подредете Persons по Name и Age
Create a class **Person**
```cs
public class Person {
  private string firstName;
  private string lastName;
  private int age;
  public string FirstName => return this.firstName;
  public int Age => return this.lastName;
  public override string ToString()
  {
    // TODO: Add logic
  }
}
```

### Задача: Увеличение на заплатата
- Добавете към класа Person поле salary
- Добавете getter за заплата
- Добавете метод, който променя заплатата с даден процент
- Persons, по-млади от 30 вземат половината от увеличението
```cs
private double salary;
public void IncreaseSalary(double percent)
{
  if (this.age > 30)
    this.salary += this.salary * percent / 100;
  else
    this.salary += this.salary * percent / 200;
}
```

### Валидация
Валидацията на данни се случва в **setters**
```cs
public double Salary
{
  set
  {
    if (salary < 460)
      throw new ArgumentException("...");
    this.salary = value;
  }
}
```
Сътрудник на вашия клас трябва да се грижи за обработка на изключенията.
Конструкторите използват private setter с валидационна логика.
```cs
public Person(string firstName, string lastName, int age, double salary)
{
  this.FirstName = firstName;
  this.LastName = lastName;
  this.Age = age;
  this.Salary = salary;
}
```
Гарантират валидно състояние на обекта при неговото създаване.

### Задача: Валидация на данни
- Разширете **Person** с валиация за всяко поле
- **Names** трябва да са с не по-малко от 3 символа
- **Age** не може да е  нула или отрицателно
- **Salary** да не е по-малко от 460
```cs
// TODO: Add validation for firstName
// TODO: Add validation for lastName
private void setAge(int age)
{
  if (age < 1) 
    throw new ArgumentException("...");
  this.age = age;
}
// TODO: Add validation for salary
```

### Непроменими (Immutable) обекти
Когато имате препратка **reference** към инстанция на обект, съдържанието, на която не може да бъде променяно.
```cs
string myString = "old String"
Console.WriteLine( myString );
myString.replaceAll( "old", "new" );
Console.WriteLine( myString );
```

### Променими полета
Променимите **private** полета все още не са капсулирани
```cs
class Team 
{
  private String name;
  private List<Person> players;
  public List<Person> Players
  {
    get { return this.players; }
  }
} 
```
Тогава getter-а е също и setter

### Задача: Първи и Резервен отбор
- Разширете вашия проект с клас **Team**
- Team трябва да има два комплекта отбори първи отбор и втори отбор
- Въведете persons от клавиатурата и ги добавете към отбора
- Ако те са по-млади от 40, тогава ги добавете към първи отбор
- Изведете броя на играчите на всеки отбор 
```cs
private string name;
private List<Person> firstTeam;
private List<Person> reserveTeam;
public Team(string name)
{
  this.name = name;
  this.firstTeam = new List<Person>();
  this.reserveTeam = new List<Person>();
}
public IReadOnlyCollection<Person> FirstTeam
{
 get { return this.firstTeam.AsReadOnly(); }
}
// TODO: add getter for reserve team
public void AddPlayer(Person player)
{
  if (player.Age < 40)
    firstTeam.Add(player);
  else
    reserveTeam.Add(player);
}
```

## 4. Статични полета и методи

### Статични полета
Статичните полета в класа:
- Принадлежат на самия клас
- Имат една и съща стойност за всеки обект
- Могат да бъдат достъпени и само чрез класа - без създаване на обект от този клас

Подобно на полетата останалите членове на класа също могат да бъдат статични.

### Статични свойства
Статичните свойства в класа:
- Принадлежат на самия клас
- Могат да бъдат достъпени и само чрез класа - без създаване на обект от този клас

Използването на свойства е удобно, когато имаме статични полета, но не искаме да позволим тяхната промяна в друг клас, който използва нашия. Ако трябва да използваме само поле, то за да го достъпим извън класа, трябва да е public, което пък би позволило неговото изменение. Именно тук идват статичните свойства.

### Задача: Преброй хората
Напишете програма, която да поддържа информация колко обекта от клас **Person** има създадени до момента. Реализирайте я използвайки статично поле и свойство.

Ще създадем статично поле, което ще поддържа информацията. След това ще направим статично свойство, което ще има само get, понеже в противен случай ще можем да манипулираме брояча, когато използваме класа, а в случая идеята е ползвателя на класа да не може да промени полето, в което е записан броя, а само да го достъпи.

Броячът ще се увеличава в рамките на конструктора на класа.

```cs
class Person 
{ // останалите части на класа са пропуснати
  private static int count = 0;
  public Person(string name, int age) 
  {
    // в конструктора добавяме реда, който променя стойността на count:
    Person.count += 1;
  }
  public static int Count 
  { // статично свойство
    get { return count; }
  }
}
```

### Статични методи
Статичните методи в класа:
- Принадлежат на самия клас
- Могат да бъдат достъпени само чрез класа - без създаване на обект от този клас
- Удобни са за извършване на действия върху всички обекти от класа или за извършване на действия, които нямат пряко отношение към обектите

### Задача: Аритметични действия
Създайте клас, който поддържа статични методи за аритметични действия върху две цели числа:
- Add(int, int) – събира числата
- Multiply(int, int) – умножава числата.

Използвайте методите от този клас в Main метода да извършите засичане на команда и извършете операцията.

```cs
class Arithmetics
{
  public static int Add(int a, int b)
  {
    return a+b;
  }
  public static int Multiply(int a, int b) 
  {
    return a * b;
  }
}
```
Извиквайте методите по аналогичен начин в **Main**(): **Arithmetics.Add(10, 15);**

### Статични класове
В решението оставихме класа си нестатичен. Това означава, че от него може да се направи обект. В случая това обаче би било безсмислено. За да не се допуска създаване на обект от даден клас, който има само статични членове ние можем да поставим думата static пред class: **static class**.

Когато отбележим един клас като статичен това означава, че неговите членове също ще са статични и от този клас няма да може да се създават обекти, а ще може членовете му да се ползват само статично. Много класове от .NET са статични (например Math)

### Статични конструктори
Конструкторите в един клас също могат да бъдат статични.

Ако един конструктор е статичен той се изпълнява, когато едно от тези събития се случи за първи път:
-  Създаде се обект от класа (ако той е нестатичен)
- Достъпва се статичен член от класа

Най-често статични конструктори се използват за инициализация на статични полета.

### Задача: Заявка за корен
Напишете клас, който съдържа метод, който връща корен квадратен при подадена заявка. Възможно е да получите голям брой заявки, така че трябва да отговаряте бързо на всяка една от тях.
```cs
public static class SquareRootPrecalculator 
{
  public const int MaxValue = 1000;
  private static double[] sqrtValues;
  static SquareRootPrecalculator() 
  {
    sqrtValues = new double[MaxValue+1];
    for (int i = 1; i <= MaxValue; i++)
      sqrtValues[i] = Math.Sqrt(i);
  }
  public static double GetSqrt(int value) 
  {
    return sqrtValues[value];
  }
}
```