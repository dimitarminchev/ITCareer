# Модул 1. Увод в програмирането
[Mатериали](01.%20Увод%20в%20програмирането.%20Материали.zip) |
[Задачи](01.%20Увод%20в%20програмирането.%20Задачи.pdf) |
[Решения](01.%20Увод%20в%20програмирането.%20Решенияи.zip)

## Съдържание
1. [Въведение в програмирането](01.%20Въведение%20в%20програмирането)
2. [Пресмятания, оператори, изрази](02.%20Пресмятания%20оператори%20изрази)
3. [Проверки](03.%20Проверки)
4. [Повторения](04.%20Повторения)
5. [Подпрограми](05.%20Подпрограми)
6. [Подготовка за изпит](06.%20Подготовка%20за%20изпит)

## 1. Въведение в програмирането

### Какво означава "да програмираме"?
- Да **програмираме** означава да даваме команди на компютъра какво да прави
- Командите се подреждат една след друга
- Така те образуват **компютърна програма**
- Компютърната програма е поредица от команди
- Програмите се пишат на **език за програмиране** (Например C#, Java, JavaScript, Python, PHP, C, C++)
- Използва се среда за програмиране (Например Visual Studio)

### Компютърни програми
- **Програма** = последователност от команди
- Съдържа команди, пресмятания, проверки, повторения
- Програмите се пишат в текстов формат
- Текстът на програмата се нарича **сорс код**
- Сорс кодът се компилира до **изпълним файл** (Например **Program.cs** се компилира до **Program.exe**)

### Среда за разработка
- За да програмирате, ви трябва **среда за разработка**
- Integrated Development Environment (IDE)
- За C# => Visual Studio за Windows или MonoDevelop за Linux и Max OS X
- за Java => IntelliJ IDEA
- за PHP => PHP Storm

Инсталирайте си Microsoft Visual Studio Community 
- https://visualstudio.microsoft.com/vs/community/

Алтернативни среди за разработка (online)
- https://dotnetfiddle.net/
- https://repl.it/repls/CostlyMonstrousAss

### Създаване на конзолна програма
- Стартирайте Visual Studio
- Създайте нов конзолен проект 
- [File] > [New] > [Project] > [Visual C#] > [Windows] > [Console Application]

### Писане на програмен код
- Сорс кодът на програма се пише в секцията **Main(string[] args)**
- Между отварящата и затварящата скоба **{ ... }**
- Натиснете **[Enter]** след отварящата скоба **{**
- Кодът на програмата се пише отместен навътре
- Напишете следния код: **Console.WriteLine("Hello World");**
- За стартиране на програмата натиснете **[Ctrl + F5]**
- Ако няма грешки, програмата ще се изпълни
- Резултатът ще се изпише на конзолата 

### Тестване на програмата
Тествайте кода си онлайн:
https://judge.softuni.bg/Contests/Practice/Index/600#0

### Типични грешки в програмите
- Писане извън тялото на **Main()** метода
- Бъркане на малки и главни букви
- Липса на **;** в края на всяка команда
- Липсваща кавичка **"** или липсваща скоба **(** или **)**

## 2. Пресмятания, оператори, изрази

### Четене на числа от конзолата
Четене на цяло число:
```
var num = int.Parse(Console.ReadLine());
```
Пример: пресмятане на лице на квадрат със страна а:
```cs
Console.Write("a = ");              
var a = int.Parse(Console.ReadLine());
var area = a * a;
Console.Write("Square = ");
Console.WriteLine(area);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/609#0

### Пресмятания в програмирането
- Компютрите са машини, които обработват данни
- **Данните** се записват в компютърната памет в **променливи**
- **Променливите** имат име, тип и стойност
- Дефиниране на променлива и присвояване на стойност:
```
var count = 5;
```
- След обработка данните се записват отново в променливи

### Типове данни и променливи
Променливите съхраняват стойност от даден **тип**: Число, буква, текст (стринг), дата, цвят, картинка, списък

Типове данни:
- Тип **цяло число**: 1, 2, 3, 4, 5, ...
- Тип **дробно число**: 0.5, 3.14, -1.5, ...
- Тип **буква** от азбуката (символ): 'a', 'b', 'c', ...
- Тип **текст** (стринг): "Здрасти", "Hi", "Beer", ...
- Тип **ден** от седмицата: понеделник, вторник, ...

### Четене на дробно число
Четене на дробно число от конзолата:
```
var num = double.Parse(Console.ReadLine());
```
Пример: прехвърляне от инчове в сантиметри:
```cs
Console.Write("Inches = ");              
var inches = double.Parse(Console.ReadLine());
var centimeters = inches * 2.54;
Console.Write("Centimeters = ");
Console.WriteLine(centimeters);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/609#1

### Четене и печатане на текст
Четене на текст (стринг) от конзолата:
```cs
var str = Console.ReadLine();
```
Пример: поздрав по име:
```cs
Console.Write("Enter your name: ");              
var name = Console.ReadLine();
Console.WriteLine("Hello, {0}!",name);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/609#2

### Съединяване на текст и числа
При печат на текст, числа и други данни, можем да ги съединим, използвайки шаблони {0}, {1}, {2}, ...
```cs
var firstName = Console.ReadLine();
var lastName = Console.ReadLine();
var age = int.Parse(Console.ReadLine());
var town = Console.ReadLine();
Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",firstName, lastName, age, town);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/609#3

### Аритметични операции: +, -, * и /
Събиране на числа (оператор +):
```cs
var a = 5;
var b = 7;
var sum = a + b; // 12
```
Изваждане на числа (оператор -):
```cs
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
var result = a - b;
Console.WriteLine(result);
```
Умножение на числа (оператор *):
```cs
var a = 5;
var b = 7;
var product = a * b; // 35
```
Деление на числа (оператор /):
```cs
var a = 25;
var i = a / 4;      // 6 – дробната част се отрязва
var f = a / 4.0;    // 6.25 – дробно делене
var error = a / 0;  // Грешка: деление на 0
```

### Особености при деление на числа в C#
При деление на цели числа резултатът е цяло число:
```cs
var a = 25;
Console.WriteLine(a / 4);  // Целочислен резултат: 6
Console.WriteLine(a / 0);  // Грешка: деление на 0
```
При деление на дробни числа резултатът е дробно число:
```cs
var a = 15;
Console.WriteLine(a / 2.0);  // Дробен резултат: 7.5
Console.WriteLine(a / 0.0);  // Резултат: Infinity
Console.WriteLine(0.0 / 0.0); // Резултат: NaN
```

### Съединяване на текст и число
Съединяване на текст и число (оператор +):
```cs
var firstName = "Maria";
var lastName = "Ivanova";
var age = 19;
var str = firstName + " " + lastName + " @ " + age;
Console.WriteLine(str);  // Maria Ivanova @ 19
```
Друг пример:
```cs
var a = 1.5;
var b = 2.5;
var sum = "The sum is: " + a + b;
Console.WriteLine(sum);  // The sum is 1.52.5
```

### Числени изрази
В програмирането можем да пресмятаме числени изрази:
```cs
var expr = (3 + 5) * (4 – 2);
```
Изчисляване на лице на трапец:
```cs
var b1 = double.Parse(Console.ReadLine());
var b2 = double.Parse(Console.ReadLine());
var h = double.Parse(Console.ReadLine());
var area = (b1 + b2) * h / 2.0;
Console.WriteLine("Trapezoid area = " + area);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#5

### Закръгляне на числа
В програмирането можем да закръгляме дробни числа.

Закръгляне до следващо (по-голямо) цяло число:
```cs
var up = Math.Ceiling(23.45);		// up = 24
```
Закръгляне до предишно (по-малко) цяло число:
```cs
var down = Math.Floor(45.67);		// down = 45
```
Закръгляне до най-близко число:
```cs
var one = Math.Round(112.345, 1);	// 112.3
var two = Math.Round(123.456, 2);	// 123.46
var three = Math.Round(566.7899, 3);	// 566.79
```

### Задача: Периметър и лице на кръг 
Напишете програма, която въвежда радиуса r на кръг и изчислява лицето и периметъра на кръга.
```cs
Console.Write("Enter circle radius. r = ");
var r = double.Parse(Console.ReadLine());
var area = Math.Round(Math.PI * r * r, 2);
var perimeter = Math.Round(2 * Math.PI * r, 2);
Console.WriteLine("Area = " + area);
Console.WriteLine("Perimeter = " + perimeter);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/151#5

### Задача: Лице на правоъгълник в равнината
Правоъгълник е зададен с координатите на два от своите срещуположни ъгъла.
Да се пресметнат площта и периметъра му.
```cs
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double width = Math.Max(x1, x2) - Math.Min(x1, x2);
double height = Math.Max(y1, y2) - Math.Min(y1, y2);
Console.WriteLine("Area = {0}", width * height);
Console.WriteLine("Perimeter = {0}", 2 * (width + height));
```

## 3. Проверки (условни конструкции)

### Сравняване на числа
В програмирането можем да сравняваме стойности:
```cs
var a = 5;
var b = 10;
Console.WriteLine(a < b);      // True
Console.WriteLine(a > 0);      // True
Console.WriteLine(a > 100);    // False
Console.WriteLine(a < a);      // False
Console.WriteLine(a <= 5);     // True
Console.WriteLine(b == 2 * a); // True
```

### Оператори за сравнение

| Оператор              | Означение |
|-----------------------|-----------|
| Проверка за равенство | ==        |
| Проверка за различно  | !=        |
| По-голямо             | >         |
| По-голямо или равно   | >=        |
| По-малко              | <         |
| По-малко или равно    | <=        |

Пример:
```cs
var result = (5 <= 6);
Console.WriteLine(result); // True
```

### Прости проверки
В програмирането често проверяваме условия и да извършване различни действия според резултата от проверката. 

Пример: въвеждаме оценка и проверяваме дали е отлична (≤ 5.50)
```cs
var grade = double.Parse(Console.ReadLine());
if (grade >= 5.50)
{
   Console.WriteLine("Excellent!");
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/613#0

### Проверки с if-else конструкция
Въвеждаме оценка, проверяваме дали е отлична или не е:
```cs
var grade = double.Parse(Console.ReadLine());
if (grade >= 5.50)
{
   Console.WriteLine("Excellent!");
}
else
{
   Console.WriteLine("Not excellent.");
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/613#1

### За къдравите скоби { } след if / else
Къдравите скоби { } въвеждат блок (група команди).
```cs
var color = "red";
if (color == "red")
{
  Console.WriteLine("tomato");
}
else
{
  Console.WriteLine("banana");
  Console.WriteLine("bye");
}
```

### Задача: Четно или нечетно 
Проверка дали цяло число е четно (even) или нечетно (odd)
```cs
var num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
   Console.WriteLine("even");
}
else
{
   Console.WriteLine("odd");
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/613#2

### Задача: По-голямото число 
Да се напише програма, която чете две цели числа и извежда по-голямото от тях
```cs
Console.WriteLine("Enter two integers:");
var num1 = int.Parse(Console.ReadLine());
var num2 = int.Parse(Console.ReadLine());
if (num1 > num2) { Console.WriteLine("Greater number: " + num1); }
else { Console.WriteLine("Greater number: " + num2); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/613#3

### Живот на променлива
Обхват, в който дадена променлива може да бъде използвана:
```cs
var myBankAccount = Bank.GetMyBankAccount();
if (DateTime.Now().Day >= PayDay)
{
    var salary = Job.GetMyMonthlySalary();
    myBankAccount = myBankAccount + salary;
}

Console.WriteLine(myBankAccount);
// Console.WriteLine(salary) Error!
```

### Серия от проверки
Конструкцията **if-else-if-else** може да е в серия.
Пример: да се изпише с английски текст дадено число (от 0 до 10).
```cs
var num = int.Parse(Console.ReadLine());
if (num == 1) { Console.WriteLine("one"); }
else if (num == 2) { Console.WriteLine("two"); }
else if (num == 3) { Console.WriteLine("three"); } // TODO: add more checks
else { Console.WriteLine("number too big"); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/614#0

### Задача: Бонус точки 
Дадено е цяло число – брой точки:
- Ако числото е до 100 включително, бонус точките са 5
- Ако числото е по-голямо от 100, бонус точките са 20%
- Ако числото е по-голямо от 1000, бонус точките са 10%

Допълнителни бонус точки:
- За четно число -> 1 т.
- За число, което завършва на 5 -> 2 т.

Да се напише програма, която пресмята бонус точките и общия брой точки след прилагане на бонусите.
```cs
Console.Write("Enter score: ");
var num = int.Parse(Console.ReadLine());
var bonusScore = 0.0;
if (num > 1000)
  { bonusScore = num * 0.10; }
else // TODO: write more logic here … 
if (num % 10 == 5)
  { bonusScore += 2; }
else // TODO: write more logic here …
Console.WriteLine("Bonus score: {0}", bonusScore);
Console.WriteLine("Total score: {0}", num + bonusScore);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/614#1

### Задача: Сумиране на секунди 
Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50). Да се пресметне сумарното им време във формат "минути:секунди". Секундите да се изведат с водеща нула (2 -> "02", 7 -> "07", 35 -> "35").
```cs
var sec1 = int.Parse(Console.ReadLine());
// TODO: Read also sec2 and sec3 …
var secs = sec1 + sec2 + sec3;
var mins = 0;
if (secs >= 120)   // TODO: Repeat this…
{ mins+=2; secs = secs - 120; }
if (secs < 10) { Console.WriteLine(mins + ":" + "0" + secs); }
else { Console.WriteLine(mins + ":" + secs); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/614#2

### Задача: Конвертор за мерни единици
Да се напише програма, която преобразува разстояние между посочените в таблицата мерни единици:
```cs
var size = double.Parse(Console.ReadLine());
var sourceMetric = Console.ReadLine().ToLower();
var destMetric = Console.ReadLine().ToUpper();
if (sourceMetric == "km") { size = size / 0.001; }
// Check the other metrics: mm, cm, ft, yd, ...
if (destMetric == "ft") { size = size * 3.2808399; }
// Check the other metrics: mm, cm, ft, yd, ...
Console.WriteLine(size + " " + destMetric);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/614#3

### Дебъгване
Процес на **закачане** към изпълнението на програмата, което ни позволява да проследи процеса на изпълнение . Това ни позволява да откриваме грешки (бъгове).

### Дебъгване във Visual Studio
- Натискане на **[F10]** ще стартира програмата в debug режим.
- Можем да преминем към следващата стъпка отново **[F10]**
- Можем да създаваме **[F9]** стопери – breakpoints
- До тях можем директно да стигнем изпозлвайки **[F5]**

### Вложени проверки
Конструкциите **if-else** могат да се влагат една в друга:
```cs
if(condition1)
{
  if(conditio2)
  {
     Console.WriteLine("condition2 is valid");
  }
  else
  {
     Console.WriteLine("condition2 is NOT valid");
  }
  Console.WriteLine("condition1 is valid");
}
```

### Задача: Обръщение според възраст и пол
Според въведени възраст и пол (m / f) да се отпечата обръщение:
- **Mr.** – мъж (пол **m**) на 16 или повече години
- **Master** – момче (пол **m**) под 16 години
- **Ms.** – жена (пол **f**) на 16 или повече години
- **Miss** – момиче (пол **f**) под 16 години
```cs
var age = double.Parse(Console.ReadLine());
var gender = Console.ReadLine();
if (gender == "f")
{
   if (age < 16) { Console.WriteLine("Miss"); }
   else { Console.WriteLine("Ms."); }
}
else
{
   if (age < 16) { Console.WriteLine("Master"); }
   else { Console.WriteLine("Mr."); }
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#0

### Задача: Квартално магазинче
Предприемчив българин отваря по едно квартално магазинче в няколко града с различни цени за следните продукти:


| city / product | coffee | water | beer | sweets | peanuts |
|----------------|--------|-------|------|--------|---------|
| Sofia          | 0.5    | 0.8   | 1.2  | 1.45   | 1.6     |
| Plovdiv        | 0.4    | 0.7   | 1.15 | 1.3    | 1.5     |
| Varna          | 0.45   | 0.7   | 1.1  | 1.35   | 1.55    |

```cs
var product = Console.ReadLine().ToLower();
var town = Console.ReadLine().ToLower();
var quantity = double.Parse(Console.ReadLine());
if (town == "sofia")
{
   if (product == "coffee") 
      { Console.WriteLine(0.50 * quantity); }
  // TODO: finish this ...
}
if (town == "varna") {}   // TODO: finish this …
if (town == "plovdiv") {} // TODO: finish this …
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#1

### Логическо "И"
Логическо "И" (оператор **&&**) означава няколко условия да са **изпълнени едновременно**:
```cs
if (x >= x1 && x <= x2 && y >= y1 && y <= y2) …
```

- Пример: проверка дали точка {x, y} се намира вътре в правоъгълника {x1, y1} – {x2, y2}
- Необходимо е точката {x, y} да е: надясно от x1 и наляво от x2 и надолу от y1 и нагоре от y2

### Задача: Точка в правоъгълник
Точка е вътрешна за даден правоъгълник, ако е: надясно от лявата му страна, наляво то дясната му страна, надолу от горната му страна и нагоре от долната му страна:
```cs
var x1 = double.Parse(Console.ReadLine());
var y1 = double.Parse(Console.ReadLine());
// TODO: finish this for x2,y2,x,y
if (x >= x1 && x <= x2 && y >= y1 && y <= y2) { Console.WriteLine("Inside"); }
else { Console.WriteLine("Outside"); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#2

### Логическо "ИЛИ"
Логическо "ИЛИ" (оператор **||**) означава да е **изпълнено поне едно** измежду няколко условия:
```cs
if (s == "banana" || s == "apple" || s == "kiwi") Console.WriteLine("fruit");
```

### Задача: плод или зеленчук?
- Плодовете "fruit" са: banana, apple, kiwi, cherry, lemon, grapes
- Зеленчуците "vegetable" са: tomato, cucumber, pepper, carrot
- Всички останали са "unknown"

```cs
var s = Console.ReadLine();
if (s == "banana" || s == "apple" || s == "kiwi" || s == "cherry" || s == "lemon" || s == "grapes") { Console.WriteLine("fruit"); }
else if (s == "tomato" || s == "cucumber" || s == "pepper" || s == "carrot") { Console.WriteLine("vegetable"); }
else  { Console.WriteLine("unknown"); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#3

### Логическо отрицание
Логическо отрицание (оператор **!**) означава да **не е изпълнено** дадено условиe.

Пример: Дадено число е валидно, ако е в диапазона [100 ... 200] или е 0. Да се направи проверка за невалидно число.
```cs
var inRange = (num >= 100 && num <= 200) || num == 0;
if (!inRange) { Console.WriteLine("invalid"); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#4

### По-сложни логически условия
Точка лежи върху някоя от страните на правоъгълник, ако:
- x съвпада с x1 или x2 и същевременно y е между y1 и y2 или
- y съвпада с y1 или y2 и същевременно x е между x1 и x2
```cs
if (((x == x1 || x == x2) && (y >= y1) && (y <= y2)) || ((y == y1 || y == y2) && (x >= x1) && (x <= x2))) { Console.WriteLine("Border"); }
else { Console.WriteLine("Inside / Outside"); }
```

### Опростяване на логически условия
Предходното условие може да се опрости ето така:
```cs
var onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
var onUpSide = (y == y1) && (x >= x1) && (x <= x2);
var onDownSide = (y == y2) && (x >= x1) && (x <= x2);
if (onLeftSide || onRightSide || onUpSide || onDownSide) { Console.WriteLine("Border"); }
else { Console.WriteLine("Inside / Outside"); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#5

### Условна конструкция switch-case
**Switch-case** работи като поредица **if-else-if-else**

Пример: Принтирайте деня от седмицата (на английски) според въведеното число (1 ... 7)
```cs
int day = int.Parse(Console.ReadLine());
switch (day)
{
  case 1: Console.WriteLine("Monday"); break;
  case 2: Console.WriteLine("Tuesday"); break;
  ...
  case 7: Console.WriteLine("Sunday"); break;
  default: Console.WriteLine("Error"); break;
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#6

### Множество етикети в switch-case
Напишете програма, която принтира вида на животно според името му: dog -> mammal; crocodile, tortoise, snake -> reptile; others -> unknown
```cs
switch (animal)
{
  case "dog": Console.WriteLine("mammal"); break;
  case "crocodile":
  case "tortoise":
  case "snake": Console.WriteLine("reptile"); break;
  default: Console.WriteLine("unknown"); break;
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/615#7

## 4. Повторения (цикли)

### Повторения (цикли)
В програмирането често пъти се налага да изпълним блок с команди няколко пъти. За целта използваме **for** цикъл:
```cs
for (var i = 1; i <= 10; i++)
{
    Console.WriteLine("i = " + i);
}
```

### Пример: числа от 1 до 100
Да се напише програма, която печата числата от 1 до 100:
```cs
for (var i = 1; i <= 100; i++)
{
   Console.WriteLine(i);
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#0

### Пример: числа до 1000, завършващи на 7
Да се напише програма, която намира всички числа в интервала [1 ... 1000], които завършват на 7:
```cs
for (var i = 0; i <= 1000; i++)
{
   if (i % 10 == 7)
   {
      Console.Write(i + " ");
   }
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#1

### Пример: всички латински букви
Да се напише програма, която отпечатва буквите от латинската азбука: a ... z. For-циклите работят не само с числа, може и с букви:
```cs
Console.Write("Latin alphabet:");
for (var letter = 'a'; letter <= 'z'; letter++)
{
   Console.Write(" " + letter);
}
Console.WriteLine();
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#2

### Пример: сумиране на числа
Да се напише програма, която въвежда n числа и ги сумира.
От първия ред на входа се въвежда броят числа n.
От следващите n реда се въвежда по едно число.
Числата се сумират и накрая се отпечатва резултатът.
```cs
Console.Write("n = ");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the numbers:");
var sum = 0;
for (var i = 0; i < n; i++)
{
   var num = int.Parse(Console.ReadLine());
   sum = sum + num;
}
Console.WriteLine("sum = " + sum);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#3

### Пример: най-голямо число
Да се напише програма, която въвежда n числа и намира най-голямото измежду тях. 
От първия ред на входа въвежда броя числа n. 
От следващите n реда се въвежда по едно число.
```cs
Console.Write("n = ");
var n = int.Parse(Console.ReadLine());
var max = -10000000000000;
for (var i = 1; i <= n; i++)
{
   var num = int.Parse(Console.ReadLine());
   if (num > max)
      max = num;
}
Console.WriteLine("max = " + max);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#4

### Пример: най-малко число
Да се напише програма, която въвежда n числа и намира най-малкото измежду тях. Въвежда първо броя числа n, след тях още n числа.

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#5

### Задача: лява и дясна сума
Да се напише програма, която въвежда 2*n числа.
Проверява дали сумите на левите n и десните n числа са равни.
При равенство печата "Yes" + сумата; иначе печата "No" + разликата (изчислена като положително число).
```cs
var n = int.Parse(Console.ReadLine());
var leftSum = 0;
for (var i = 0; i < n; i++)
  { leftSum = leftSum + int.Parse(Console.ReadLine()); }
// TODO: read and calculate the rightSum
if (leftSum == rightSum)
  { Console.WriteLine("Yes, sum = " + leftSum); }
else
  { Console.WriteLine("No, diff = " + 
    			Math.Abs(rightSum - leftSum)); }
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#6

### Задача: четна / нечетна сума
Да се напише програма, която въвежда n числа.
Проверява дали сумата на числата на четни позиции е равна на сумата на числата на нечетни позиции.
При равенство печата "Yes" + сумата; иначе печата "No" + разликата (положително число). 
```cs
var n = int.Parse(Console.ReadLine());
var oddSum = 0;
var evenSum = 0;
for (var i = 0; i < n; i++)
{
  var element = int.Parse(Console.ReadLine());
  if (i % 2 == 0) oddSum += element;
  else evenSum += element;
}
// TODO: print the sum / difference
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/616#7

### Правоъгълник от 10 x 10 звездички
Да се начертае на конзолата правоъгълник от 10 x 10 звездички:
```cs
for (var i = 1; i <= 10; i++)
{
   Console.WriteLine(new string('*', 10));
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/617#0

### Правоъгълник от N x N звездички
Да се начертае на конзолата правоъгълник от N x N звездички:
```cs
int n = int.Parse(Console.ReadLine());
for (var i = 1; i <= n; i++)
{
   Console.WriteLine(new string('*', n));
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/617#1

### Вложени цикли
**Вложени цикли** = цикъл съдържа в себе си друг цикъл. Двата цикъла въртят различни променливи. Пример: външен цикъл (по row) и вътрешен цикъл (по col).
```cs
for (var row = 1; row <= n; row++)
{
   for (var col = 1; col <= n; col++)
      Console.Write("*");
   Console.WriteLine();
}
```

### Квадрат от звездички
Да се начертае на конзолата квадрат от N x N звездички:
```cs
var n = int.Parse(Console.ReadLine());
for (var r = 1; r <= n; r++)
{
   Console.Write("*");
   for (var c = 1; c < n; c++) Console.Write(" *");
   Console.WriteLine();
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/617#2

### Триъгълник от долари
Да се начертае триъгълник от долари с размер n:
```cs
var n = int.Parse(Console.ReadLine());
for (var row = 1; row <= n; row++)
{
   Console.Write("$");
   for (var col = 1; col < row; col++)
      Console.Write(" $");
   Console.WriteLine();
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/617#3

### Квадратна рамка
Да се начертае на конзолата квадратна рамка с размер n:
```cs
// Print the top row: + - - - +
Console.Write("+");
for (int i = 0; i < n-2; i++)
   Console.Write(" -");
Console.WriteLine(" +");
for (int row = 0; row < n - 2; row++)
   // TODO: print the mid rows: | - - - |
// TODO: print the bottom row: + - - - +

```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/617#4

### Ромбче от звездички
Да се начертае ромбче от звездички с размер n:
```cs
for (var row = 1; row <= n; row++)
{
    for (var col = 1; col <= n-row; col++)  Console.Write(" ");
    Console.Write("*");
    for (var col = 1; col < row; col++) Console.Write(" *");
    Console.WriteLine();
}
// TODO: print the down side of the rhomb
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/617#5

### Коледна елха
Напишете програма, която въвежда число n (1 ≤ n ≤ 100) и печата коледна елха с размер n:
```cs
var n = int.Parse(Console.ReadLine());
for (int i = 0; i <= n; i++)
{
   var stars = new string('*', i);
   var spaces = new string(' ', n - i);
   Console.Write(spaces);
   Console.Write(stars);
   Console.Write(" | ");
   Console.Write(stars);
   Console.WriteLine(spaces);
}
```
Пращане на решения: https://judge.softuni.bg/Contests/Practice/Index/617#6

### Слънчеви очила
Напишете програма, която въвежда цяло число n (3 ≤ n ≤ 100) и печата слънчеви очила с размер 5*n x n :
```cs
// Print the top part
Console.Write(new string('*', 2 * n));
Console.Write(new string(' ', n));
Console.WriteLine(new string('*', 2 * n));
for (int i = 0; i < n - 2; i++)
{
   // TODO: print the middle part
}
// Print the bottom part
Console.Write(new string('*', 2 * n));
Console.Write(new string(' ', n));
Console.WriteLine(new string('*', 2 * n));
// Print the middle part
for (int i = 0; i < n - 2; i++)
{
   // TODO: print *///////*
   if (i == (n-1) / 2 - 1) Console.Write(new string('|', n));
   else Console.Write(new string(' ', n));
   // TODO: print *///////*
   Console.WriteLine();
}
```
Пращане на решения: https://judge.softuni.bg/Contests/Practice/Index/617#7

### Къщичка
Напишете програма, която въвежда число n (2 ≤ n ≤ 100) и печата къщичка с размер n x n:
```cs
var stars = 1;
if (n % 2 == 0) stars++;
for (int i = 0; i < (n+1) / 2; i++)
{ // Draw the roof
  var padding = (n - stars) / 2);
  Console.Write(new string('-', padding);
  Console.Write(new string('*', stars));
  Console.WriteLine(new string('-', padding);
  stars = stars + 2;
}
for (int i = 0; i < n / 2; i++)
{ // Draw the house body: |*****| }
```
Пращане на решения: https://judge.softuni.bg/Contests/Practice/Index/617#8

### Диамант
Напишете програма, която въвежда цяло число n (1 ≤ n ≤ 100) и печата диамант с размер n:
```cs
var leftRight = (n - 1) / 2;
for (int i = 1; i <= (n-1) / 2; i++)
{ // Draw the top part
  Console.Write(new string('-', leftRight));
  Console.Write("*");
  var mid = n - 2 * leftRight - 2;
  if (mid >= 0)
  {
    Console.Write(new string('-', mid));
    Console.Write("*");
  }
  Console.WriteLine(new string('-', leftRight));
  leftRight--;
} // TODO: Draw the bottom part
```
Пращане на решения: https://judge.softuni.bg/Contests/Practice/Index/617#9

### Числата от 1 до N през 3
Да се отпечатат числата от 1 до n със стъпка 3
```cs
var n = int.Parse(Console.ReadLine());
for (var i = 1; i <= n; i+=3)
{
   Console.WriteLine(i);
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/619#0

### Числата от N до 1 в обратен ред
Да се отпечатат числата от n до 1 в обратен ред (стъпка -1)
```cs
var n = int.Parse(Console.ReadLine());
for (var i = n; i >= 1; i-=1)
{
  Console.WriteLine(i);
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/619#1

### Числата от 1 до 2^n с for-цикъл
Да се отпечатат числата от 1 до 2^n
```cs
var num = 1;
for (var i = 0; i <= n; i++)
{
   Console.WriteLine(num);
   num = num * 2;
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/619#2

### Четни степени на 2
Да се отпечатат четните степени на 2 до 2^n
```cs
var num = 1;
for (var i = 0; i <= n; i+=2)
{
   Console.WriteLine(num);
   num = num * 2 * 2;
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/619#3

### Редица числа 2k+1
Да се отпечатат всички числа ≤ n от редицата: 1, 3, 7, 15, 31, ...
```cs
var num = 1;
while (num <= n)
{
   Console.WriteLine(num);
   num = 2 * num + 1;
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/619#4

### Число в диапазона [1 ... 100]
Да се въведе число в диапазона [1 ... 100]
```cs
var num = int.Parse(Console.ReadLine());
while (num < 1 || num > 100)
{
   Console.WriteLine("Invalid number!");
   num = int.Parse(Console.ReadLine());
}
Console.WriteLine("The number is: {0}", num);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/619#5

### Най-голям общ делител (НОД)
Най-голям общ делител (НОД) на две естествени числа a и b е най-голямото число, което дели едновременно a и b без остатък.

Да се въведат цели числа a и b и да се намери НОД(a, b):

```cs
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());
while (b != 0)
{
   var oldB = b;
   b = a % b;
   a = oldB;
}
Console.WriteLine("GCD = {0}", a);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/619#6

### Изчисляване на факториел
За естествено число n да се изчисли n! = 1 * 2 * 3 * ... * n
```cs
var n = int.Parse(Console.ReadLine());
var fact = 1;
do
{
   fact = fact * n;
   n--;
} while (n > 1);
Console.WriteLine(fact);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/620#0

### Сумиране на цифрите на число
Да се сумират цифрите на цяло положително число n.
```cs
var n = int.Parse(Console.ReadLine());
var sum = 0;
do
{
   sum = sum + (n % 10);
   n = n / 10;
} while (n > 0);
Console.WriteLine("Sum of digits: {0}", sum);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/620#1

### Безкраен цикъл
Безкраен цикъл е когато повтаряме нещо до безкрайност:
```cs
while(true)
{
   Console.WriteLine("Infinite loop");
}
```
Пример:
```cs
for (;;)
{
   Console.WriteLine("Infinite loop");
}
```

### Прости числа
- Едно число n е просто, ако се дели единствено на 1 и n
- Едно число n е просто, ако се дели на число между 2 и n-1

Алгоритъм за проверка дали число е просто:
- Проверяваме дали n се дели на 2, 3, ..., n-1
- Ако се раздели, значи е композитно
- Ако не се раздели, значи е просто

### Проверка за просто число. Оператор break
```cs
var n = int.Parse(Console.ReadLine());
var prime = true;
for (var i = 2; i <= Math.Sqrt(n); i++)
{
   if (n % i == 0) 
   {
      prime = false;
      break;
   }
}
if (prime) Console.WriteLine("Prime");
else Console.WriteLine("Not prime");
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/620#2

### Оператор break в безкраен цикъл
Да се напише програма, която въвежда четно число. 
При невалидно число да връща към повторно въвеждане.
```cs
var n = 0;
while (true)
{
   Console.Write("Enter even number: ");
   n = int.Parse(Console.ReadLine());
   if (n % 2 == 0) break; // even number -> exit from the loop
   Console.WriteLine("The number is not even.");
}
Console.WriteLine("Even number entered: {0}", n);
```

### Справяне с грешни числа: try … catch
```cs
try
{
   Console.Write("Enter even number: ");
   n = int.Parse(Console.ReadLine());
   if (n % 2 == 0) break;
   Console.WriteLine("The number is not even.");
}
catch
{
   Console.WriteLine("Invalid number.");
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/620#3

### Числа на Фибоначи
Числата на Фибоначи са следните: 1, 1, 2, 3, 5, 8, 13, 21, 34, ... F(n) = F(n-2) + F(n-1). Да се въведе n и да се пресметна n-тото число на Фибоначи
```cs
var n = int.Parse(Console.ReadLine());
var f0 = 1;
var f1 = 1;
for (var i = 0; i < n-1; i++)
{
   var fNext = f0 + f1;
   f0 = f1;
   f1 = fNext;
}
Console.WriteLine(f1);
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/620#4

### Пирамида от числа
Да се отпечатат числата 1 ... n в пирамида:
```cs
var n = int.Parse(Console.ReadLine());
var num = 1;
for (var row = 1; row <= n; row++)
{
    for (var col = 1; col <= row; col++)
    {
        if (col > 1) Console.Write(" ");
        Console.Write(num);
        num++;
        if (num > n) break;
    }
    Console.WriteLine();
    if (num > n) break;
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/620#5

### Таблица с числа
Да се отпечатат числата 1 ... n в таблица:
```cs
var n = int.Parse(Console.ReadLine());
for (int row = 0; row < n; row++)
{
   for (int col = 0; col < n; col++)
   {
      var num = row + col + 1;
      if (num > n) num = 2 * n - num;
      Console.Write(num + " ");
   }
   Console.WriteLine();
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/620#6

## 5. Подпрограми (функции и методи)

### Прости Методи
**Методите** са **именувано парче код**, което може да се извика.
Деклариране на прост метод:
```cs
static void PrintHeader()
{
   Console.WriteLine("----------");
}
```
**Извикване** на метода няколко пъти:
```cs
PrintHeader();
PrintHeader();
```

### Защо да използваме методи?
Управляваме процеса на програмиране
- Разделяме големи програми на малки части
- По-добра организация на програмата ни
- Подобрява четимостта на кода
- Подобрява разбираемостта на кода

Избягваме повторението на програмен код
- Подобрява поддръжката на кода

Преизползваемост на кода
- Използване на съществуващи методи няколко пъти

### Деклариране на методи
- В C#, методите се декларират **вътре в клас**
- **Main()** също е метод
- Декларираните променливи са **локални**

### Извикване на метод
**Методите** могат да бъдат **извикани** чрез името им
```cs
static void PrintHeader()
{
   Console.WriteLine("----------");
}
```
**Извикване** на метод:
```cs
static void Main()
{
    PrintHeader();
}
```

Метод може да бъде извикан от:
- Главният метод – **Main()**
- Някой **друг метод**
- **Собственото си тяло** – Рекурсия

### Задача: Празна касова бележка
Да се напише метод, който печата празна касова бележка:
- Направете 3 метода които принтират всяка част
- Копирайте съдържанието от предишния слайд
- Използвайте знака "\u00A9" за символът ©
- Направете метод PrintReceipt(), който вика трита метода

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/621#0

### Използване на параметри
**Параметрите** могат да бъдат **всеки тип данни**
```cs
static void PrintNumbers(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write("{0} ", i);
    }
}
```
Извикване на метод с **конкретни стойности**
```cs
static void Main()
{
    PrintNumbers(5, 10);
}
```
- Можем да подаваме **нула** или **няколко** параметъра
- Параметрите могат да бъдат от **различни типове**
- Всеки параметър има **име** и **тип**
```cs
static void PrintStudent(string name, int age, double grade)
{
    Console.Write("Student: {0}; Age: {1}, Grade: {2}", name, age, grade);
}
```

### Задача: Знак на цяло число
Да се създаде метод, който печата знака на цяло число n:
```cs
static void PrintSign(int number)
{
    if (number > 0)  Console.WriteLine("The number {0} is positive", number);
    else if (number < 0) Console.WriteLine("The number {0} is negative.", number);
    else Console.WriteLine("The number {0} is zero.", number);
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/621#1

### Задача: Принтиране на триъгълник
Да се създаде метод, който принтира триъгълник.

Първо създайте метод, който принтира един ред, състоящ се от числа в диапазон от определено начало до определен край:
```cs
static void PrintLine(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}
```
После създайте метод, който принтира първата и после втората половина на триъгълника:
```cs
static void PrintTriangle(int n)
{
    for (int line = 1; line <= n; line++)
    {
        PrintLine(1, line);
    }
 
    for (int line = n - 1; line >= 1; line--)
    {
        PrintLine(1, line);
    }
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/621#2

### Задача: Рисуване на запълнен квадрат
Нарисувайте на конзолата запълнен квадрат със страна n
```cs
static void PrintHeaderRow(int n)
{  
   Console.WriteLine(  new string('-', 2 * n)); 
}
static void PrintMiddleRow(int n)
{
   Console.Write('-');
   for (int i = 1; i < n; i++) Console.Write("\\/");
  Console.WriteLine('-');
}
static void Main() 
{
  int n = // TODO: read n
  PrintHeaderRow(n);
  for (int i = 0; i < n - 2; i++) PrintMiddleRow(n);
  PrintHeaderRow(n);
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/621#3

### Типове на връщаната от метода стойност
Тип **void** – не връща никаква стойност (само изпълнява кода)
```cs
static void AddOne(int n) 
{
    n += 1;
    Console.WriteLine(n);
}
```
Други типове – връщат стойност от тип,съвместим с **типа** на метода
```cs
static int PlusOne(int n) 
{
    return n + 1;
}
```

### Оператор Return
- Веднага спира изпълнението на метода
- Връща определената стойност
```cs
static string ReadFullName() 
{
    string firstName = Console.ReadLine();
    string lastName = Console.ReadLine();
    return firstName + " " + lastName;
}
```
**void** методите могат да бъдат спрени с използване на **return**;

### Употреба на връщаната стойност
Стойностите могат да се:

**Присвояват** на променлива:
```cs
int max = GetMax(5, 10);
```
**Използват** в изрази:
```cs
decimal total = GetPrice() * quantity * 1.20m;
```
**Предават** директно на друг метод:
```cs
int age = int.Parse(Console.ReadLine());
```

### Пример: превръщане на температура
Превърнете температурата от Фаренхайт в Целзий
```cs
static double FahrenheitToCelsius(double degrees)
{
    double celsius = (degrees - 32) * 5 / 9;
    return celsius;
}
static void Main()
{
    Console.Write("Temperature in Fahrenheit: ");
    double t = Double.Parse(Console.ReadLine());
    t = FahrenheitToCelsius(t);
    Console.Write("Temperature in Celsius: {0}", t);
}
```

### Задача: Лице на триъгълник
Да се напише метод, който изчислява лицето на триъгълник по дадени основа и височина и връща стойността му.
```cs
static double GetTriangleArea(double width, double height)
{
    return width * height / 2;
}
static void Main()
{
    double width = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());
    Console.WriteLine(GetTriangleArea(width, height));
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/622#0

### Задача: Степен на число
Да се напише метод, който изчислява и връща резултата от повдигането на число на дадена степен:
```cs
static double RaiseToPower(double number, int power)
{
    double result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= number;
    }
    return result;
}
```
Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/622#1

### Сигнатура на метода
- Комбинацията от **име** и **параметри** се нарича **сигнатура на метод**.
- Сигнатурата се използва за **разграничаване** между методи с едно и също име.
- Методи с **едно и също име**, но **различна сигнатура** се наричат **варианти на метод**.

### Варианти на методи
Можем да използваме едно име на няколко метода с различни **сигнатури** (име и параметри на метод)
```cs
static void Print(string text);
static void Print(int number);
static void Print(string text, int number);
```

### Сигнатура и тип на връщаната стойност
Типът на връщаната стойност **не е част** от сигнатурата
```cs
static void Print(string text)
{
    Console.WriteLine(text);
}
static string Print(string text)
{
    return text;
}
```
Компилаторът не би могъл да прецени **кой от двата метода да изпълни**.

### Изпълнение на програма
Изпълнението се продължава след извикване на метод:
```cs
static void Main()
{
	Console.WriteLine("before method executes");
	PrintLogo();
	Console.WriteLine("after method executes")
}
static void PrintLogo()
{
    Console.WriteLine("Company Logo");
	Console.WriteLine("http://wwww.companywebsite.com")
}
```

### Задача: Умножение на четна и нечетна сума
Да се напише програма, която умножава сумата от всички четни цифри на число и сумата на всички нечетни цифри на същото число:
- Направете метод **GetMultipleOfEvensAndOdds**()
- Направете методи **GetSumOfEvenDigits**() и **GetSumOfOddDigits**()
- Използвайте **Math.Abs**() за негативните числа

Тестване на решението: https://judge.softuni.bg/Contests/Practice/Index/622#3
