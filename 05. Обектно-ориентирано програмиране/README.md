# Модул 5. Обектно-ориентирано програмиране
[Материали](05.%20Обектно-ориентирано%20програмиране.%20Материали.zip) |
[Задачи](05.%20Обектно-ориентирано%20програмиране.%20Задачи.pdf) |
[Решения](05.%20Обектно-ориентирано%20програмиране.%20Решения.zip) |
[Видео](https://youtube.com/playlist?list=PL-w_n7hgFuN00GAvC4kPjsykDhgExD38y)

## Съдържание
1. [Компонентно тестване](01.%20Компонентно%20тестване)
2. [Дефиниране на класове](02.%20Дефиниране%20н%20класове)
3. [Шаблонни класове](03.%20Шаблонни%20класове)
4. [Наследяване, абстракция, интерфейси](04.%20Наследяване,%20абстракция,%20интерфейси)	
5. [Полиморфизъм](05.%20Полиморфизъм)
6. [Работа с обекти](06.%20Работа%20с%20обекти)
7. [Елементи от функционалното програмиране](07.%20Елементи%20от%20функционалното%20програмиране)
8. [Комуникация между обекти](08.%20Комуникация%20между%20обекти) 
9. [Изключения](09.%20Изключения) 
10. [Работа с потоци и файлове](10.%20Работ%20с%20потоци%20и%20файлове)
11. [Подготовка за изпит](11.%20Подготовка%20за%20изпит)

## Unit Testing

Get started with unit testing:
https://docs.microsoft.com/en-us/visualstudio/test/getting-started-with-unit-testing?view=vs-2019

### Visual Studio Team Tests (VSTT)
```cs
[TestClass] 
public class TheClassName
{
	[TestMethod] 
	public void TheTestName()
	{
		...
```

### AAA = Arrange + Act + Assert
```cs
[TestMethod] 
public void DespositMoneyTest()
{
	// Arrange
	BankAccount bank = new BankAccount();

	// Act
	bank.Deposit(50);

	// Assert
	Assert.IsTrue(bank.Balance == 50);
}
```

### Atributes
```
[TestClass] = denotes a class holding unit tests
[TestMethod] = denotes a unit test method
[ExpectedException] = test causes an exception
[Timeout] = sets a timeout for test execution
[Ignore] = temporary ignored test case
[ClassInitialize], [ClassCleanup] = setup / cleanup logic for the testing class
[TestInitialize], [TestCleanup] = setup / cleanup logic for each test case
```

### Asserts
```cs
AreEqual(expected value, calculated value [,message]) = compare two values for equality
AreSame(expected object, current object [,message]) = compare object references
IsNull(object [,message])
IsNotNull(object [,message])
IsTrue(condition)
IsFalse(condition)
Fail(message) = Forced test fail
```

## Зависимости
- Добрa практики за избягване на взаимообвързване на класовете е използването на интерфейсти.
- Интерфейсите са договор, който показва, че дадения клас който наследява интерфейса е задължен да има съответната функционалност.

## Имитиране на обекти 
Userfull Reading:
- [MOQ Quickstart](https://github.com/Moq/moq4/wiki/Quickstart)
- [C# Writing unit tests with NUnit and Moq](https://www.developerhandbook.com/unit-testing/writing-unit-tests-with-nunit-and-moq/)
- [KickStart your Unit Testing using Moq](https://www.codeproject.com/Articles/796014/KickStart-your-Unit-Testing-using-Moq)

## Шаблони
```cs
class List<T> 
{
    public Add (T element) { ... }
    public T Remove () { ... }
    public T { get; }
}
```

## Интерфейси 
```cs
interface IBox<T> 
{
    void Add (T element);
    ...
}
class MyList<T> : IBox<T> { ... }
```

## Ограничители 
Ограничаване до референтен тип
```cs
public void MyMethod<T>() where T : class
```
Ограничаване до примитивен тип
```cs
public void MyMethod<T>() where T : struct
```
Ограничаване до конструктор
```cs
public void MyMethod<T>() where T : new ()
```
Ограничаване до статичен базов клас
```cs
public void MyMethod<T>() where T : BaseClass
```
Ограничаване до шаблонен базов клас
```cs
public void MyMethod<T,U>() where T : U
```

## Наследяване
Наследяващият клас получава всички членове от родителския си клас.
```cs
class Person { ... }
class Student : Person { ... }
```
Конструкторите не се наследяват, но може да се използват.
```cs
public Student(String name, School school) : base(name) { ... }
```
Подкласовете наследават данните с модификатори за достъп (**public**) и  (**protected**), но не и тези с (**private**).
```cs
this.weight; // Достъп до член от тази инстанция
base.weight; // Достъп до член от базовия клас
```
Виртуалнита методи позволяват пренаписване.
```cs
public class Animal
{
  public virtual void Eat() { ... }
}
public class Dog : Animal
{   
  public override void Eat() { ... }
}
```

## Абстракция и интерфейси
Абстракцията се постига чрез интерфейси и абстрактни класове и представлява процес на скриване на подробностите на имплементацията и показване само на функционалностите към потребителя.
```cs
public interface IAnimal {}
public abstract class Mammal {}
public class Person : Mammal, IAnimal {}
```
| Абстрактен клас                                                                                                                                             | Интерфейс                                                                                                                           |
|-------------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------|
| Класът може да наследи само един абстрактен клас.                                                                                                           | Класът може да имплементира няколко интерфейса.                                                                                     |
| Абстрактните класове могат да предоставят целия код и/или само детайлите, които трябва да се презапишат.                                                    | Интерфейсът не може да предоставя никакъв код, предоставя само описание.                                                            |
| Абстрактния клас може да съдържа модификатори за достъп                                                                                                     | Интерфейсите нямат модификатори за достъп. Всичко е публично по подразбиране.                                                       |
| Ако множество имплементации са от сходен вид и имат общо поведение или статут, то абстрактния клас е по-добър избор.                                        | Ако множество имплементации споделят само сигнатурата на методите и нищо друго, то тогава интерфейсът е по-добър избор.             |
| Абстрактният клас може да притежава полета и константи                                                                                                      | Не поддържа полета                                                                                                                  |
| Ако добавим нов метод към абстрактен клас, то имаме опцията да създадем имплементация по подразбиране и така съществуващият код ще може да работи коректно. | Ако добавим нов метод към интерйфес, то трябва да проследим всичките му имплементации и да дефинираме имплементация за новия метод. |

## Презареждане (overloading) 
Методи с едно и също име, но различни сигнатури.
```cs
public int Add(int a, int b)
public double Add(double a, double b, double c)
public decimal Add(decimal a, decimal b, decimal c)
```

## Презаписване (overriding) 
Създаване на метод със същото име и сигнатура в подклас.
```cs
public class Person
{
  public virtual string IntroduceYourself() { ... }
}
public class Student : Person
{
  public override string IntroduceYourself() { ... }
}
```

## Итератори

### IEnumerable<T>
Интерфейс за обхождане на колекция
```cs
public interface IEnumerable<T> : IEnumerable
{
    IEnumerator<T> GetEnumerator();
}
```
### IEnumerator<T>
Предоставя последователно, еднопосочно обхождане на колекция от произволен тип
```cs
public interface IEnumerator<T> : IEnumerator
{
    bool MoveNext();
    void Reset();
    T Current { get; }
}

public interface IEnumerator
{
    bool MoveNext();
    void Reset();
    object Current { get; }
}
```
- **MoveNext()** = премества итератора към следваща позиция 
- **Reset()** = връща итератора на начална позиция 
- **Current** = връща елемента от колекцията на текущата позиция на итератора

## Компаратори
### IComparable<T>
```cs
class Point : IComparable<Point>
{
    public int CompareTo(Point otherPoint)
    {
        ...
    }
}
```
### IComparer<T>
```cs
class CatComparer : IComparer<Cat>
{
    public int Compare(Cat x, Cat y)
    {
        ...
    }
}
```

## Отражение на типове (Reflection)

Техника на програмиране, при която компютърни програми мога да третират други програми като свои данни.

### Type
Основен начин за достъп до метаданните.
```cs
Type myType = typeof(ClassName);
```
### Name
Предоставя  името на класа.
```cs
string fullName = typeOf(SomeClass).FullName;
string simpleName = typeOf(SomeClass).Name;
```
### Class and Interface
```cs
Type baseClassType = testClass.BaseType;
Type[] classInterfaces = testClass.GetInterfaces();
```
### CreateInstance 
Създава екземпляр от класа чрез извикване на конструктора, който най-добре пасва на указаните параметри.
```cs
Type sbType = Type.GetType("System.Text.StringBuilder");
StringBuilder sbInstance = (StringBuilder) Activator.CreateInstance(sbType);
StringBuilder sbInstCapacity = (StringBuilder)Activator.CreateInstance(sbType, new object[] {10});
```
### Fields
Предоставя публичните полета
```cs
FieldInfo field = type.GetField("name"); FieldInfo[] publicFields = type.GetFields();
```
Предоставя всички полета
```cs
FieldInfo[] allFields = type.GetFields(
BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic); 
```
### Field Type
Получаване на името и типа на полето
```cs
FieldInfo field = type.GetField("fieldName");
string fieldName = field.Name;
Type fieldType = field.FieldType;
```
### Access Modifiers
```cs
field.IsPrivate     // частен
field.IsPublic      // публичен
field.IsNonPublic   // не е публичен
field.IsFamily      // защитен (protected)
field.IsAssembly    // вътрешен (internal)
```
### Constructors
```cs
ConstructorInfo[] publicCtors = type.GetConstructors();
```
### Create New Object Instances
```cs
StringBuilder builder = (StringBuilder)constructor.Invoke(new object[] params);
```
### Methods
```cs
MethodInfo[] publicMethods = sbType.GetMethods();
```
Достъп до параметрите на метод и връщания тип данни
```cs
ParameterInfo[] appendParameters = appendMethod.GetParameters();
Type returnType = appendMethod.ReturnType;
```
Извиква методи
```cs
appendMethod.Invoke( builder, new object[] { "hi!" });
```

## Функционално програмиране

### Lambda Expressions
```cs
msg => Console.WriteLine(msg);
(String msg) => { Console.WriteLine(msg); }
() => { Console.WriteLine("hi"); }
(int x, int y) => { return x + y; }
```
### Lambda Functions
| израз         | еквивален                                     |
|---------------|-----------------------------------------------|
| x => x / 2    | static int Func(int x) { return x / 2; }      |
| x => x != 0   | static bool Func(int x) { return x != 0; }    |
| () => 42      | static int Func() { return 42; }              |
| (x, y) => x+y | static int Func(int x, int y) { return x+y; } |

### LINQ & Collections
```
ToArray(), ToList()
Select(), Where(), OrderBy()
Min(), Max(), Sum(), Average(), Count()
First(), Last() , Single()
Skip(), Take()
Distinct() 
Reverse()
Concat()
```

## Изключения (Exception)

### Прихващане на изключенията
```cs
try
{
    ...
}
catch (Exception)
{
    ...
}
finally
{
	...
}
```
**Типове**
- System.ArgumentException
- System.FormatException
- System.NullReferenceException
- System.OutOfMemoryException
- System.StackOverflowException

### Хвърляне на изключения
```cs
throw new ArgumentException("Invalid amount!");
```
**Типове**
- ArgumentException
- ArgumentNullException 
- ArgumentOutOfRangeException
- NotSupportedException
- NotImplementedException

## Потоци (Streams)
Четене от файл
```cs
StreamReader reader = new StreamReader("filename.txt");
string line = reader.ReadLine();
```
Запис във файл
```cs
StreamWriter writer = new StreamWriter("filename.txt");
reader.WriteLine("Hello World");
```

### Стандартни потоци
**File Stream**
```cs
var fileStream = new FileStream("filename.txt",FileMode.Create);
byte[] bytes = Encoding.UTF8.GetBytes(text);
fileStream.Write(bytes, 0, bytes.Length);
fileStream.Close();
```
**Memory Stream**
```cs
var memoryStream = new MemoryStream(bytes)
int readByte = memoryStream.ReadByte();
```
**Network Stream**
```cs
var tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 22);
tcpListener.Start();
NetworkStream stream = tcpListener.AcceptTcpClient().GetStream();

byte[] request = new byte[1024];
stream.Read(request, 0, request.Length);
Console.WriteLine(Encoding.UTF8.GetString(request));

byte[] response = Encoding.UTF8.GetBytes("Hello World");
stream.Write(response, 0, response.Length);
```
