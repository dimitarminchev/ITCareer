# Модул 4. Увод в Алгоритмите и структурите от данни
[Материали](04.%20Увод%20в%20АСД.%20Материали.zip) |
[Задачи](04.%20Увод%20в%20АСД.%20Задачи.pdf) |
[Решения](04.%20Увод%20в%20АСД.%20Решения.zip) |
[Видео](https://youtube.com/playlist?list=PL-w_n7hgFuN0vg-7PWxHo2PlSnhKWbGyF)

## Съдържание
1. [Въведение в алгоритмите](1.%20Въведение%20в%20алгоритмите)
2. [Линейни структури от данни](2.%20Линейни%20структури%20от%20данни)
3. [Алгоритми върху линейни структури](3.%20Алгоритми%20върху%20линейни%20структури)
4. [Алгоритми за сортиране](4.%20Алгоритми%20за%20сортиране)
5. [Алгоритми за търсене](5.%20Алгоритми%20за%20търсене)
6. [Допълнителни задачи](6.%20Допълнителни%20задачи)
7. [Подготовка за изпит](7.%20Подготовка%20за%20изпит)

## 1. Въведение в алгоритмите

#### Алгоритъм
Алгоритъм наричаме краен брой, еднозначно определени стъпки (команди), водещи до решаването на даден проблем. Алгоритмите биват **линейни** и **разклонени** и имат следните свойства:  дискретност, определеност, крайност, масовост, сложност.

#### Анализ 
Предсказване на небходимите ресурси за алгоритъма:
- Изчислително време (CPU)
- Необходимо количество оперативна памет (RAM)
- Операции с твърдия диск (HDD)
- Употреба на всякакви времеемки и енергоемки ресурси

#### Време за изпълнение
Очакваното **време за изпълнение** на алгоритъма представлява общият брой изпълнени **елементарни операции** (машинно-зависими стъпки).*.

Измерва се: Процесорно време, Консумация на памет, Брой стъпки, Брой частични операции, Брой дискови операции, Брой мрежови пакети, Асимптотична сложност.

- **Най-лош случай** е горната граница на времето за изпълнение.
- **Най-добър случай** е долната граница на времето за изпълнение (оптимален случай).
- **Средно аритметичен случай** представлявва средно време за изпълнение.

#### Сложност на алгоритъм
**Сложност на алгоритъм** e груба преценка на броя на изпълняваните стъпки, в зависимост от входните данни.
Имерват се с **Асимптотчна нотация**.
- O(f(n)) – Горна граница
- Θ(f(n)) – Горна & Долна граница
- Ω(f(n)) – Долна граница

#### Монотонност (растене) на функция
- **O(1)** означава, че функцията не расте, когато n расте
- **О(n)** означава, че функцията расте линейно, когато n расте
- **O(n^2)** означава, че функцията расте експоненциално, когато n расте

#### Типове сложности

| Сложност             | Нотация     | Описание                            |
|----------------------|-------------|-------------------------------------|
| константна           | O(1)        | n = 1 000 => 1-2 операции           |
| логаритмична         | O(log(n))   | n = 1 000 => 10 операции            |
| линейна              | O(n)        | n = 1 000 => 1 000 операции         |
| Линейно-логаритмична | O(n*log(n)) | n = 1 000 => 10 000 операции        |
| Квадратична          | O(n^2)      | n = 1 000 => 1 000 000 операции     |
| Кубична              | O(n^3)      | n = 1 000 => 1 000 000 000 операции |
| Експоненциална       | O(n^n)      | n = 10 => 10 000 000 000 операции   |

#### Времева сложност и скорост на програмата

| Сложност    | 10       | 20     | 50      | 100    | 1 000  | 10 000 | 100 000  |
|-------------|----------|--------|---------|--------|--------|--------|----------|
| O(1)        | < 1 с.   | < 1 с. | < 1 с.  | < 1 с. | < 1 с. | < 1 с. | < 1 с.   |
| O(log(n))   | < 1 с.   | < 1 с. | < 1 с.  | < 1 с. | < 1 с. | < 1 с. | < 1 с.   |
| O(n)        | < 1 с.   | < 1 с. | < 1 с.  | < 1 с. | < 1 с. | < 1 с. | < 1 с.   |
| O(n*log(n)) | < 1 с.   | < 1 с. | < 1 с.  | < 1 с. | < 1 с. | < 1 с. | < 1 с.   |
| O(n^2)      | < 1 с.   | < 1 с. | < 1 с.  | < 1 с. | < 1 с. | 2 с.   | 3-4 мин. |
| O(n^3)      | < 1 с.   | < 1 с. | < 1 с.  | < 1 с. | 20 с.  | 5 часа | 231 дни  |
| O(2^n)      | < 1 с.   | < 1 с. | 260 дни | увисва | увисва | увисва | увисва   |
| O(n!)       | < 1 с.   | увисва | увисва  | увисва | увисва | увисва | увисва   |
| O(n^n)      | 3-4 мин. | увисва | увисва  | увисва | увисва | увисва | увисва   |

## 2. Линейни структури от данни

### Разтеглив масив

**Какво са структурите от данни?**

Структурата от данни е начинът,  по който съхраняваме, организираме и обработваме данните, така че те да могат да бъдат използвани ефективно.

**Какво е разтеглив масив?**

Разтеглив масив е структура от данни, която е масив по своята същност, но за разлика от обикновеният масив може да променя размера си. 

**Заделяне на памет при разтеглив масив**

При запълване се заделя двойно място на наличното досега място.

```cs
public class ArrayList<T> : IEnumerable<T>
{
	private T[] items;
	public int Count { get; private set; }
	public T this[int index] {}
	public void Add(T item) {}
	public T Get(int index) {}
	public void Set(int index, T item) {}
	public T RemoveAt(int index) {}
}
```

C# и .NET ни предоставят "наготово" доста структури от данни. Можем да разполагаме и с няколко списъчни такива: **ArrayList** (разтеглив масив), **List<T>** (списък) и **LinkedList<T>** (свързан списък).

**Коя от всичките списъчни структури да ползваме?**

| Структура     | Добавяне/изтриване | Търсене | Достъп до индекс | Използвана памет |
|---------------|--------------------|---------|------------------|------------------|
| LinkedList<T> | бързо              | бавно   | бавно            | икономичен       |
| List<T>       | бавно              | бързо   | бързо            | неикономичен     |
| ArrayList     | бавно              | бързо   | бързо            | неикономичен     |

### Свързан списък
Списък е наредена поредица от елементи, с променлива дължина и поддържа следните операции: добавяне на елемент (Add), извличане на стойност на елемент (Get), присвояване на стойност на елемент (Set), премахване на елемент (Remove). Може да се имплементира чрез масив или списък от свързани възли.

**Свързаният списък** е структура от данни, която съхранява информацията във вид на елементи, в които се пази информация за стойността и за това кой е следващият елемент, откъдето идва и името му.

Реализирането на такава структура става чрез създаването на клас **Node**, който описва структурата на един елемент от списъка:
```cs
public class Node
{
	private object element;
	private Node next;
	
	public Node(object element, Node prevNode)
	{
		this.element = element;
		prevNode.next = this;
	} 
	public Node(object element)
	{
		this.element = element;
		next = null;
	}
}
```
Самият списък се създава в клас **DynamicList**
```cs
public class DynamicList
{
      private Node head;
      private Node tail;
      private int count;
	  
      public DynamicList() {…}
      public void Add(object item) { … }
      public object Remove(int index) { … }
      public int Remove(object item) { … }
      public int IndexOf(object item) { … }
      public bool Contains(object item) { … }
      public object this[int index] { …}
}
```

### Опашка
**Опашката** е структура от данни, която има поведение от тип "първи влязъл, първи излиза". Опашката може да се реализира: **Статично**, чрез масив и **Динамично**, чрез възел със стойност и указател към следващ елемент.

**Статична (кръгова) опашка**

Статична (базирана на масив) имплементация. Имеплентира се като "кръгов масив". Има ограничен капацитет (когато се запълни се заделя двойно място). Има индекси за начало (**head**) и край (**tail**), сочещи към началото и края на кръговата опашка.

**Свързана Опашка**

Динамична имплементация. Всеки възел (**node**) има 2 полета: стойност (**value**) и следващ елемент (**next**). Позволява динамично създаване и изтриване.

**Queue<T> в .NET**

Queue<T> имплементира опашка чрез кръгов разтеглив масив. Елементите са от един и същ тип T. T може да бъде какъв да е тип (Queue<int>, Queue<float>, Queue<DateTime>). Размерът се увеличава динамично при нужда.

**Queue<T> базова функционалност**

| Метод        | Описание                                 | Пример                            |
|--------------|------------------------------------------|-----------------------------------|
| Enqueue(T)   | добавя елемент в края на опашката        | queue.Enqueue(5);                 |
| Dequeue()    | премахва и връща елемента от началото    | int number = queue.Dequeue();     |
| Peek()       | връща елемента от началото без триене    | int number = queue.Peek();        |
| Count        | връща броя елементи                      | int elementCount = queue.Count;   |
| Clear()      | премахва всички елементи                 | queue.Clear();                    |
| Contains(T)  | проверява дали елемент се среща в опашка | bool isFound = queue.Contains(5); |
| ToArray()    | преобразува опашка в обикновен масив     | int[] arr = queue.ToArray();      |
| TrimExcess() | изтрива допълнителното място             | queue.TrimExcess();               |

### Стек
**Стекът** е структура от данни, която има поведение от тип "последен влязъл, първи излиза", т.е. можем да добавяме и извличаме елемент само от най-"горния" край.

**Операции при стек**

- **Push** = добавя елемент най-горе в стека
- **Pop** = премахва най-горния елемент в стека
- **Peek** = връща най-горния елемент в стека, без да го премахва

**Статичен стек**

Статична (базирана на масив) имплементация. Има фиксиран капацитет. Има индекс, който оказва най-горния елемент (**top**), който се движи наляво/надясно според това дали е премахнат / добавен елемент. При запълване на капацитета, се заделя двойно място, по принципа на разтегливия масив.

**Свързан стек**

Динамична (свързана) реализация. Всеки възел (**node**) има 2 полета: стойност (**value**) и следващ елемент (**next**). Специален указател съдържа най-горния елемент (**top**).

**Stack<T> Class в .NET Framework**

Реализиран посредством масив. Елементите са от един и същ тип T. T може да бъде всякакъв тип (Stack<int>, Stack<float>, Stack<Customer>). Размерът се увеличава автоматично при растене на стека.

**Stack<T> базова функционалност**

| Метод        | Описание                                       | Пример                            |
|--------------|------------------------------------------------|-----------------------------------|
| Push(T)      | добавя елемент към стека                       | stack.Push(5);                    |
| Pop()        | премахва и връща елемента най-горе в стека    | int number = stack.Pop();         |
| Peek()       | връща елемента най-горе в стека без да го маха | int number = stack.Peek();        |
| Count        | връща броя елементи                            | int elementCount = stack.Count;   |
| Clear()      | премахва всички елементи                       | stack.Clear();                    |
| Contains(T)  | проверява дали елемент се среща в стека        | bool isFound = stack.Contains(5); |
| ToArray()    | преобразува стека в обикновен масив            | int[] arr = stack.ToArray();      |
| TrimExcess() | изтрива допълнителното място                   | stack.TrimExcess();               |

## 3. Алгоритми върху линейни структури
**Стекът** е малко парче памет с фиксиран размер (1MB). Пази точката в която всяка активна подпрограма трябва да върне контрола, когато завърши изпълнението си.

#### Задача: Undo списък от адреси
Запазете историята на браузъра. Ще получите възможни команди: URL – отваря дадената страница, back – връща към предната страница, exit – спира програмата.
```cs
if (command == "back")
{
  if (stack.Count != 0) {
    Console.WriteLine(stack.Pop());
  }
  previous = null;
}
else
{
  if (previous != null) {
    stack.Push(previous);                
  }
  previous = command;
}
```

#### Задача: Съответстващи си квадратни скоби
Даден е аритметичен израз със скоби (може и вложени). Цел: извличане на всички под-изрази в скоби.
```cs
for (int index = 0; index < expression.Length; index++)
{
  char ch = expression[index];
  if (ch == '(')
    stack.Push(index);
  else if (ch == ')')
  {
    int startIndex = stack.Pop();
    int length = index - startIndex + 1;
    string contents = expression.Substring(startIndex, length);
    Console.WriteLine(contents);
  }
}
```

#### Задача: Редица N, N+1, 2*N ...
За дадено число N, намерете членът на редицата с индекс P. Номерацията започва от 1. 
```cs
int n = 3, p = 16;
Queue<int> queue = new Queue<int>();
queue.Enqueue(n);
int index = 0;
while (queue.Count > 0)
{
    int current = queue.Dequeue();
    index++;
    if (current == p) {
        Console.WriteLine("Index = {0}", index);
        break;
    }
    queue.Enqueue(current + 1);
    queue.Enqueue(2 * current);
}
```

#### Обединение и сечение на списъци
Нека сега разгледаме един по-интересен пример - да напишем програма, която може да намира обединенията и сеченията на две множества числа.

Можем да приемем, че имаме два списъка и искаме да вземем елементите, които се намират и в двата едновременно (сечение) или търсим тези, които се намират поне в единия от двата (обединение).

Едно възможно решение е с директно следване на  определенията за обединение и сечение на множества. Използваме методите Съдържа ли се елемент в списък и Добави елемент към списък.

**Обединение** – това са елементите на първия и тези от втория, които се срещат само в него
```cs
public static List<int> Union(List<int> firstList, List<int> secondList )
{
  List<int> union = new List<int>();
  union.AddRange(firstList);
  foreach (var item in secondList)
  {
    if (!union.Contains(item))
    {
       union.Add(item);
    }
  }
  return union;
}
```
**Сечение** – това са елементите на единия списък, които се съдържат в другия
```cs
public static List<int> Intersect(List<int> firstList, List<int> secondList)
{
  List<int> intersect = new List<int>();
  foreach (var item in firstList)
  {
    if (secondList.Contains(item))
    {
       intersect.Add(item);
    }
  }
  return intersect;
}
```
Извеждаме списък с метода **PrintList**
```cs
public static void PrintList(List<int> list)
{
  Console.Write("{ ");
  foreach (var item in list)
  {
    Console.Write(item);
    Console.Write(" ");
  }
  Console.WriteLine("}");
}

```
В Main() извикваме методите Add(), Union(), Interesect() и PrintList()
```cs
public static void Main()
{
	List<int> firstList = new List<int>();
	firstList.Add(1); firstList.Add(2); firstList.Add(3);firstList.Add(4); firstList.Add(5);     
	Console.Write("firstList=");
	PrintList(firstList);
	
	List<int> secondList = new List<int>();
	secondList.Add(2); secondList.Add(4); secondList.Add(6); 
	Console.Write("secondList = ");
	PrintList(secondList);
	
	List<int> unionList = Union(firstList, secondList);
	Console.Write("union = ");
	PrintList(unionList);
	
	List<int> intersectList = Intersect(firstList, secondList);
	Console.Write("intersect = ");
	PrintList(intersectList);
}
```

#### Задача: Подредици – най-дълга подредица от равни числа 
Дадена е последователност от числа. Върнете като резултат числото, което се повтаря последователно най-много пъти.

Въвеждаме елементите, разделяме ги по интервал и ги парсваме като int и ги записваме в списък:
```
var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
```
В началото за текуща стойност, както и за най-често срещания елемент даваме стойност на първия елемент в списъка:
```cs
int listCount = list.Count();
int currVal = list[0]; 
int currCount = 1; 
int maxCount = 1; 
int maxVal = currVal;
```
В цикъл обхождаме останалите елементи. Ако стойността на следващите се запази, увеличаваме броя им и ако последносрещания елемент е с повече появявания от максимлния до момента - го запомняме, както и броя на появяванията му. 
```cs
for ( int i = 1; i<listCount; i++ ) 
{
    if ( list[i] == currVal )
    {
      currCount ++;
      if ( currCount > maxCount ) 
      {  
        maxCount = currCount; 
        maxVal = currVal; 
       }
     }
	...
```
Иначе – пак проверяваме дали последносрещания елемент е с повече появявания от максимaлния до момента:
```cs
	...
	else
	{
		if ( currCount > maxCount ) 
		{ 
			maxCount = currCount; 
			maxVal = currVal;
		}
		currCount=1; 
		currVal=list[i];
	}
}  
Console.WriteLine("{0} {1}", maxVal, maxCount);
```

### Какво е рекурсия?
Техника за решаване на задачи. Разделяне на задачата на подзадачи от същия тип. Включва самоизвикване на функция. Функцията трябва да има основен случай (край или дъно). Всяка стъпка на рекурсията трябва да отива към основния случай.

#### Задача: Сума на масив
Създайте рекурсивен метод, който намира сбора на всички числа, съхранявани в int[] array, като числата се въвеждат от клавиатурата (конзолата).
```cs
static int Sum(int[] array, int index)
{
  if (index == array.Length - 1)
  {
    return array[index];
  }
  return array[index] + Sum(array, index + 1);
} 
```

#### Задача: Рекурсивен факториел
Създайте рекурсивен метод, който изчислява n! Въведете n от клавиатурата.
```cs
static long Factorial(int num)
{
	if (num == 0) return 1; 
	return num * Factorial(num - 1);
} 
```

### Пряка и косвена рекурсия
- **Пряка рекурсия**, когато метод директно се самоизвиква. 
- **Непряка (косвена) рекурсия**, когато метод А извиква метод B, а метод B извиква метод А Или  A -> B -> C -> A.

#### Рекурсия с предварително действие и с последващо действие
Рекурсивните методи имат 3 части:
- **Предварително действие** (преди извикване на рекурсията)
- **Рекурсивни извиквания** (стъпка навътре)
- **Последващо действие** (след връщане от рекурсията)
```cs
static void Recursion()
{
	// Pre-actions
	Recursion();
	// Post-actions
} 
```

#### Задача: Рекурсивно чертаене
Cъздайте рекурсивен метод, който чертае фигура.
```cs
static void PrintFigure(int n)
{
    if (n == 0) // Bottom of the recursion
      return;

    // предварително действие: отпечатва n звездички
    Console.WriteLine(new string('*', n));

    // рекурсивно извикване: отпечатва фигура с размер n-1
    PrintFigure(n - 1);

    // последващо действие: отпечатва n хештаг-а # (диез)
    Console.WriteLine(new string('#', n));
}
```

#### Производителност: Рекурсия срещу итерация (цикъл
Рекурсивните обръщения са малко по-бавни от итерацията. Параметрите и върнатите стойности минават през стека на всяка стъпка. Предпочита се за линейни изчисления (без разклонени обръщения).

Рекурсивен факториел:
```cs
static long RecurFact(int n)
{
	if (n == 0) return 1; 
	else return n * Fact(n - 1);
} 
```
Итеративен факториел:
```cs
static long IterFact(int num)
{
	long result = 1;
	for (int i = 1; i <= n; i++) result *= i;
	return result;
} 
```

#### Безкрайна рекурсия
**Безкрайна рекурсия** = метод, извикващ себе си безкрайно. Обикновено, безкрайна рекурсия = грешка в програмата. Липсва край (дъно) на рекурсията или е грешно зададено. В C# / Java / C++ предизвиква грешка "**stack overflow**". 

#### Рекурсията може да бъде и вредна!
Когато се използва неправино, рекурсията може да отнеме прекалено много памет и изчислителна мощ.
```cs
static decimal Fibonacci(int n)
{
    if ((n == 1) || (n == 2)) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
static void Main()
{
    Console.WriteLine(Fibonacci(10)); // 89
    Console.WriteLine(Fibonacci(50)); // This will hang!
}
```

**Как работи рекурсивното изчисляване на членовете на редицата на Фибоначи?**
fib(n) прави около fib(n) рекурсивни обръщения. Една и съща стойност се изчислява многократно!

#### Кога се ползва рекурсия?
Избягвайте рекурсия, когато съществува очевидна итеративен алгоритъм.

## 4. Алгоритми за сортиране
Сортиращият алгоритъм подрежда елементите на списък в ненамаляващ ред.

### Въведение

**Класификация на алгоритмите за сортиране**

Сортиращите алгоритми често са класифицирани според:
- Изчислителната сложност и обема на използваната памет
- Как се държат в най-лошия, обичаен и най-добрия случай
- Рекурсивни и нерекурсивни
- Стабилни и нестабилни
- Базирано на сравнение сортиране и неизползващи сравнение
- По метода за сортиране: вмъкване, замяна (метод на мехурчето и бързо сортиране), селекция (пирамидално сортиране), сливане, последователно или паралелно и т.н.

**Стабилност на сортирането**

- **Стабилни** сортиращи алгоритми: Запазват подредбата на еднаквите елементи. Ако два елемента след сравнение са равни, редът им един спрямо друг се запазва.
- **Нестабилни** сортиращи алгоритми: Пренареждане на еднаквите елементи в непредсказуем ред.
- Често различни елементи имат един и същ ключ, използван за сравнение при сортиране.

**Помощни методи при сортиране**
```cs
public static class Help
{
    // Размяна на два елемента = O(1)
    public static void Swap<T>(T[] elements, int first, int second)
    {
        T temp = elements[first];
        elements[first] = elements[second];
        elements[second] = temp;
    }

    // Дали даден елемент е по малък от друг = O(1)
    public static bool IsLess(IComparable first, IComparable second)
    {
        return first.CompareTo(second) < 0;
    }

    // Проверка дали структурата е сортирана = O(N)
    public static bool IsSorted<T>(T[] elements) where T : IComparable
    {
        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i - 1].CompareTo(elements[i]) > 0)
            {
                return false;
            }
        }
        return true;
    }
}
```

### Selection Sort = Сортиране по метода на пряката селекция = O(N^2)
Сортиране чрез пряка селекция, работи посредством размяна на първия с минималния от елементите отдясно, после втория, третия и т.
```cs
public static void Selection<T>(T[] elements) where T : IComparable
{
    for (int i = 0; i < elements.Length; i++)
    {
        int min = i;
        for (int j = i + 1; j < elements.Length; j++)
        {
            if (Help.IsLess(elements[j], elements[min]))
            {
                min = j;
            }
        }
        Help.Swap(elements, min, i);
    }
}
```

### Bubble Sort = Сортиране по метода мехурчето = O(N^2)
Сортиране чрез метода на мехурчето, работи посредством размяна на съседни елементи, които не са подредени, до пълно сортиране.
```cs
public static void Bubble<T>(T[] elements) where T : IComparable
{
    for (int i = 0; i < elements.Length; i++)
    {
        for (int j = 0; j < elements.Length; j++)
        {
            if (Help.IsLess(elements[i], elements[j]))
            {
                Help.Swap(elements, i, j);
            }
        }
    }
}
```

### Insertion Sort = Сортиране чрез вмъкване = О(N^2)
Сортиране чрез вмъкване, работи посредством преместване на първия несортиран елемент  наляво на мястото му.
```cs
public static void Insertion<T>(T[] elements) where T : IComparable
{
    for (int i = 1; i < elements.Length; i++)
    {
        int prev = i - 1;
        int curr = i;
        while (true)
        {
            if (prev < 0 || Help.IsLess(elements[prev], elements[curr]))
            {
                break;
            }
            Help.Swap(elements, curr, prev);
            prev--;
            curr--;
        }
    }
}
```

### Fisher–Yates Shuffling = Разбъркване = O(N)
**Разбъркването** представлява постигане на случаен ред на елементите в колекция.

> Генерирането на случайни числа е прекалено важно, за да бъде оставено на > шанса. —Robert R. Coveyou 

Алгоритъм за разбъркване на Fisher–Yates
```cs
public static Random random = new Random();
public static void Shuffle<T>(T[] elements)
{
    for (int i = 0; i < elements.Length; i++)
    {
        int r = i + random.Next(0, elements.Length - i);
        Help.Swap(elements, i, r);
    }
}
```

### Merge Sort = Сортиране чрез сливане = O(N*log(N))
Сортиране чрез сливане е ефективен алгоритъм за сортиране, който:
1. Разделя списъка на подсписъци (обикновено 2 подсписъка)
2. Сортира всеки подсписък (рекурсивно извиквайки merge-sort)
3. Слива сортираните подсписъци в един списък
```cs
public static void Merge<T>(T[] elements) where T : IComparable
{
    MergeAlgo(elements, 0, elements.Length);
}

// Merge Algorithm
private static void MergeAlgo<T>(T[] elements, int left, int right) where T : IComparable
{
    // Difference
    int diff = right - left;

    // Recursion Exit Clause
    if (diff <= 1) return;

    // Recurrsion
    int mid = left + diff / 2;
    MergeAlgo(elements, left, mid);
    MergeAlgo(elements, mid, right);

    // Post-Recurrsion
    T[] temp = new T[diff];
    int i = left, j = mid;
    for (int k = 0; k < diff; k++)
    {
        if (i == mid) temp[k] = elements[j++];
        else if (j == right) temp[k] = elements[i++];
        else if (Help.IsLess(elements[j], elements[i])) temp[k] = elements[j++];
        else temp[k] = elements[i++];
    }
    for (int k = 0; k < diff; k++)
    {
        elements[left + k] = temp[k];
    }
}
```

### Quick Sort = Бързо сортиране = O(N*log(N))
Бързо сортиране e ефективен алгоритъм за сортиране, който работи така: избира се "опорен" елемент; премества по-малките елементи вляво от него, а по-големите - вдясно; сортира лявата и дясната част.
```cs
public static void Quick<T>(T[] elements) where T : IComparable
{
    QuickAlgo(elements, 0, elements.Length - 1);
}

// Quick Algo
private static void QuickAlgo<T>(T[] elements, int left, int right) where T : IComparable
{
    if (left > right || left < 0 || right < 0) return;
    int pivot = QuickPartitionSort(elements, left, right);
    if (pivot != -1)
    {
        QuickAlgo(elements, left, pivot - 1);
        QuickAlgo(elements, pivot + 1, right);
    }
}

// Quick Partition Sort
private static int QuickPartitionSort<T>(T[] elements, int left, int right) where T : IComparable
{
    if (left > right) return -1;
    int end = left;
    T pivot = elements[right];
    for (int i = left; i < right; i++)
    {
        if (Help.IsLess(elements[i], pivot))
        {
            Help.Swap(elements, i, end);
            end++;
        }
    }
    Help.Swap(elements, end, right);
    return end;
}
```

### Сравнение на сортиращи алгоритми

| Име           | Най-добре | Средно   | Най-зле  | Памет    | Стабилен | Метод     |
|---------------|-----------|----------|----------|----------|----------|-----------|
| SelectionSort | n^2       | n^2      | n^2      | 1        | Не       | Селекция  |
| BubbleSort    | n         | n^2      | n^2      | 1        | Да       | Размяна   |
| InsertionSort | n         | n^2      | n^2      | 1        | Да       | Вмъкване  |
| QuickSort     | n*log(n)  | n*log(n) | n^2      | log(n)   | Зависи   | Разделяне |
| MergeSort     | n*log(n)  | n*log(n) | n*log(n) | 1 (or n) | Да       | Сливане   |


## 5. Алгоритми за търсене
**Алгоритъм за търсене** e алгоритъм за намиране на елемент с указани свойства всред колекция от елементи.

### Linear Search = Линейно търсене = O(n)
Последователно (или линейно) търсене намира определена стойност в списък.
Проверява последователно всеки от елементите, един по един, докато открие желания.
```cs
public static int Linear<T>(T[] elements, T key) where T : IComparable
{
    for (int index = 0; index < elements.Count(); index++)
    {
        if (elements[index].CompareTo(key) == 0)
        {
            return index; // Found
        }
    }
    return -1; // Not Found
}
```
 
### Binary Search = Двоично търсене = O(log(n))
Двоичното търсене намира елемент в подредена структура от данни. 
На всяка стъпка, сравнява въведеното със средния елемент.
Алгоритъмът продължава да търси в лявата или дясната подструктура.
```cs
public static int Binary<T>(T[] elements, T key) where T : IComparable
{
    int start = 0, end = elements.Count() - 1;
    while (end >= start)
    {
        // middle
        int mid = (start + end) / 2;

        // compare
        if (elements[mid].CompareTo(key) > 0)
        {
            // (mid > key) => key must be on left 
            end = mid - 1;
        }
        else if (elements[mid].CompareTo(key) < 0)
        {
            // (mid < key) => key must be on right 
            start = mid + 1;
        }
        else
        {
            // (mid == key) => found
            return mid;
        }
    }
    // not found
    return -1;
}
```

### Interpolation Search = Интерполационно търсене = O(log(log(N))
Търсене чрез интерполация е алгоритъм за търсене по даден ключ в подреден индексиран масив.
Подобно на това как хората търсят в телефонен указател.
Изчислява къде в оставащата част трябва да е търсения елемент.
Двоичното търсене винаги избира средния елемент.
```cs
public static int Interpolational<T>(T[] elements, T key) where T : IComparable
{
    int low = 0, high = elements.Count() - 1;
    // algo
    while (elements[low].CompareTo(key) <= 0 && elements[high].CompareTo(key) >= 0)
    {
        int mid = low + (((dynamic)key - (dynamic)elements[low]) * (high - low)) /
                         ((dynamic)elements[high] - (dynamic)elements[low]);

        // compare
        if (elements[mid].CompareTo(key) > 0)
        {
            // (mid > key) => key must be on left 
            high = mid - 1;
        }
        else if (elements[mid].CompareTo(key) < 0)
        {
            // (mid < key) => key must be on right 
            low = mid + 1;
        }
        else
        {
            // (mid == key) => found
            return mid;
        }
    }
    // not found
    return -1;
}
```