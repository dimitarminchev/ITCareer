# Модул 2. Програмиране
[Материали](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5.%20%D0%9C%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D0%B8.zip) | [Задачи](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5.%20%D0%97%D0%B0%D0%B4%D0%B0%D1%87%D0%B8.pdf) | [Решения](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5.%20%D0%A0%D0%B5%D1%88%D0%B5%D0%BD%D0%B8%D1%8F.zip)

## Съдържание
1. Системи за контрол на версиите
2. [Типове данни](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/02.%20%D0%A2%D0%B8%D0%BF%D0%BE%D0%B2%D0%B5%20%D0%B4%D0%B0%D0%BD%D0%BD%D0%B8)
3. [Масиви и Списъци](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/03.%20%D0%9C%D0%B0%D1%81%D0%B8%D0%B2%D0%B8%20%D0%B8%20%D0%A1%D0%BF%D0%B8%D1%81%D1%8A%D1%86%D0%B8)
4. [Методи и дебъгване](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/04.%20%D0%9C%D0%B5%D1%82%D0%BE%D0%B4%D0%B8%20%D0%B8%20%D0%B4%D0%B5%D0%B1%D1%8A%D0%B3%D0%B2%D0%B0%D0%BD%D0%B5)
5. [Символни низове](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/05.%20%D0%A1%D0%B8%D0%BC%D0%B2%D0%BE%D0%BB%D0%BD%D0%B8%20%D0%BD%D0%B8%D0%B7%D0%BE%D0%B2%D0%B5)
6. [Многомерни масиви](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/06.%20%D0%9C%D0%BD%D0%BE%D0%B3%D0%BE%D0%BC%D0%B5%D1%80%D0%BD%D0%B8%20%D0%BC%D0%B0%D1%81%D0%B8%D0%B2%D0%B8)
7. [Речници и хеш таблици](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/07.%20%D0%A0%D0%B5%D1%87%D0%BD%D0%B8%D1%86%D0%B8%20%D0%B8%20%D1%85%D0%B5%D1%88%20%D1%82%D0%B0%D0%B1%D0%BB%D0%B8%D1%86%D0%B8)
8. [Подготовка за изпит](../02.%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B8%D1%80%D0%B0%D0%BD%D0%B5/08.%20%D0%9F%D0%BE%D0%B4%D0%B3%D0%BE%D1%82%D0%BE%D0%B2%D0%BA%D0%B0%20%D0%B7%D0%B0%20%D0%B8%D0%B7%D0%BF%D0%B8%D1%82)

## 1. Системи за контрол на версиите
### Въведение

Използваме **системите за контрол на версиите** за улесняване на работата в екип. Кодът на проекта се съхранява в централно електронно **хранилище**. Води се опис на всички промени, които се съхраняват в **история на промените** и могат да бъдат извикани, прегледани и дори възстановени. Лесно се разрешават **конфликти**, възникнали при **сливане** на промени в проекта.

### Терминология
* **Хранилище** (Repository) = Съхраняване на активите на проекта на отдалечен сървър
* **Клониране** (Clone) = Изтегляне на локално копие на проекта
* **Предаване** (Commit) = Съхраняване на множеството от променени файлове в локалното хранилище
* **Синхронизиране** (Sync) = Уеднаквяване на локалното и отдалеченото хранилище
* **Изтегляне** (Pull) на промените от отдалеченото хранилище и сливането им с нашите промени
* **Изпращане** (Push) на локалните промени към отдалеченото хранилище
* **Разклонения** (Branches) = Различни версии на проекта
* **Сливане** (Merge) на разклонения

### Git & GitHub
1. Изтеглете и инсталирайте програмата: https://git-scm.com/download/win
2. Стартирайте командния ред.
3. Клонирайте отдалеченото в локално хранилище:
```
git clone https://github.com/dimitarminchev/ITCareer
```
4. Направете промени в локалното хранилище.
5. Проверка на промените в локалното хранилище:
```
git status
```
6. Изтегляне и сливане на промени от отдалеченото в локалното хранилище:

```
git pull
```
7. Подготовка на всички файлове за добавяне към отдалеченото хранилище:
```
git add .
```
8. Предаване от локалното хранилище:
```
git commit -m "Update"
```
9. Изпращане на промените към отдалеченото хранилище:
```
git push
```

## 2. Типове данни

### Представяне на бойни системи

**Двоична бройна система**

Двоичните числа се преставят като последователност от битове (нула или единица).

**Преобразуване от десетична в двоична бройна система**

Делим на две и прибавяме в обратен ред остатъците.

**Шестнадесетична бройна система**

Шестнадесетични числа се представят чрез 16 цифри: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E и F. В програмирането обикновено се ползва префикс 0x

**Преобразуване на числа от шестнадесетична към десетична бройна система**

Умножаваме всяка цифра по основата на съответния степенен показател.

**Преобразуване на числа от десетична към шестнадесетична бройна система**

Делим на 16 и прибавяме остатъците в обратен ред

**Преобразуване на числа от шестнадесетична в двоична бройна система**

Лесно преобразуване на двоично число в шестнадесетично. Всяка шестнадесетична цифра отговаря на 4 двоични цифри. Процедурата работи двупосочно.

### Аритметика на бойни системи

**Събиране в двоична бройна система**

| + | 0 | 1  |
| - | - | -- |
| 0 | 0 | 1  |
| 1 | 1 | 10 |

Ако събираме повече от две числа едновременно, може да се получи пренос, надвишаващ числото, тогава преносът се пише над толкова цифри, с колкото цифри се пише преноса.

**Умножение в двоична бройна система**

| \* | 0 | 1 |
| -- | - | - |
| 0  | 0 | 0 |
| 1  | 0 | 1 |

**Аритметика в други бройна система**

Тези действия може да се извършват по същия начин и във всяка друга позицинна бройна система. Само числата, които се получават във сметките от алгоритмите се записват в съответната бройна система.

### Типове данни

Променливите имат **име**, **тип** и **стойност**. Типa на данните oписва вида на информацията, който се пази в компютърната памет.

### Целочислени типове

Целите числа си имат **диапазон** (минимална и максимална стойност). Целочислените типове могат да се **препълнят** и това води до некоректни стойности.

| Тип    | Бита | Обхват                                                   |
| ------ | ---- | -------------------------------------------------------- |
| sbyte  | 8    | -128 ... 127                                             |
| byte   | 8    | 0 ... 255                                                |
| short  | 16   | -32 768 ... 32 767                                       |
| ushort | 16   | 0 ... 65 535                                             |
| int    | 32   | -2 147 483 648 ... 2 147 483 647                         |
| uint   | 32   | 0... 4 294 967 295                                       |
| long   | 64   | -9 223 372 036 854 775 808 ... 9 223 372 036 854 775 807 |
| ulong  | 64   | 0 ... 18 446 744 073 709 551 615                         |

### Задача: Векове към минути

Напишете програма, в която въвеждаме цяло число – брой векове и го преобразуваме към години, дни, часове и минути.

```cs
Console.Write("Centuries = ");
int centuries = int.Parse(Console.ReadLine());
int years = centuries * 100;
int days = (int) (years * 365.2422); 
int hours = 24 * days;
int minutes = 60 * hours;
Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
```

### Реални числени типове

Имат **диапазон** и **точност** според използваната памет. Понякога се наблюдават аномалии при изчисления.

| Тип     | Бита | Обхват                         |
| ------- | ---- | ------------------------------ |
| float   | 32   | 1.5 × 10^−45 ... 3.4 × 10^38   |
| double  | 64   | 5.0 × 10^−324 ... 1.7 × 10^308 |
| decimal | 128  | 1,0 × 10^-28 ... 7,9 × 10^28   |

Реалните числа по подразбираме се възприемат за **double**. Ако желаем дадена стойност да се запише като float, трябва изрично да я преобразуваме.

**Закръгляне на числа с плаваща запетая**

* Math.Round(3.45) = закръгля към цяло число(матетматическ)
* Math.Round(2.3455, 3) = закръгляне с точност
* Math.Ceiling() = закръгля нагоре към най-близкото цяло число
* Math.Floor() = закръгля надолу към най-близкото цяло число

```cs
double a = 2.3455;
Console.WriteLine(Math.Round(a));    // result: 2
Console.WriteLine(Math.Round(a, 3)); // result: 2.346
Console.WriteLine(Math.Ceiling(a));  // result: 3
Console.WriteLine(Math.Floor(a));    // result: 2
```

### Задача: Лице на кръг (с точност 12 знака)
Напишете програма, в която да въведете радиус r (реално число) и изведете лицето на кръга с точност 12 знака след запетаята.
```cs
double r = double.Parse(Console.ReadLine());
Console.WriteLine("{0:f12}", Math.PI * r * r);
```

### Експоненциален запис
Числата с плаващата запетая могат да ползват **експоненциален запис**
```cs
double d = 10000000000000000000000000000000000.0;
Console.WriteLine(d); // 1E+34
double d2 = 20e-3;
Console.WriteLine(d2); // 0.02
double d3 = double.MaxValue;
Console.WriteLine(d3); // 1.79769313486232E+308
```

### Делене с плаваща запетая
Целочисленото деление и делението на числа с плаваща запетая са **две различни неща**
```cs
Console.WriteLine(10 / 4);    // 2 (целочислено)
Console.WriteLine(10 / 4.0);  // 2.5 (реално)
Console.WriteLine(10 / 0.0);  // Infinity
Console.WriteLine(-10 / 0.0); // -Infinity
Console.WriteLine(0 / 0.0);   // NaN (не е число)
Console.WriteLine(8 % 2.5);   // 0.5 (3 * 2.5 + 0.5 = 8)
int d = 0;             // Целочисленото деление работи по друг начин!
Console.WriteLine(10 / d); // DivideByZeroException
```

### Аномалии при изчисления с плаваща запетая

Понякога изчисленията работят **неправилно**!

```cs
Console.WriteLine(100000000000000.0 + 0.3);
// Result: 100000000000000 (загуба на точност)
double a = 1.0f, b = 0.33f, sum = 1.33;
Console.WriteLine("a+b={0} sum={1} equal={2}",
  a+b, sum, (a+b == sum));
// a+b=1.33000001311302 sum=1.33 equal=False
double one = 0;
for (int i = 0; i < 10000; i++) one += 0.0001;
Console.WriteLine(one); // 0.999999999999906
```

### Задача: Точна сума на реални числа

Напишете програма, която да въвежда n числа и да изведете тяхната точна сума.

```cs
int n = int.Parse(Console.ReadLine());
decimal sum = 0;
for (int i = 0; i < n; i++)  sum += decimal.Parse(Console.ReadLine());
Console.WriteLine(sum);
```

### Преобразуване на типове

**Скрито** преобразуване на тип без загуби: променлива от по-голям тип (double) взема по-малка стойност (float)

```cs
float heightInMeters = 1.74f;
double maxHeight = heightInMeters; 
```

**Явно** преобразуване със загуба: може да загубим точност.

```cs
double size = 3.14;
int intSize = (int) size; 
```

### Задача: Асансьор
Изчислете колко курса са нужни, за да се качат n човека с асансьор с капацитет от p човека

```cs
int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int courses = (int) Math.Ceiling((double)n / p);
Console.WriteLine(courses);
```

### Булев тип
Булевия тип (**bool**) съдържа истина (**true**) или лъжа (**false**)
```cs
int a = 1;
int b = 2;
bool greaterAB = (a > b);
Console.WriteLine(greaterAB);  // False
bool equalA1 = (a == 1);
Console.WriteLine(equalA1);    // True
```

### Задача: Булева променлива
Въведете низ, преобразувайте го към променлива от булев тип и изведете **Yes** ако в променливата има true и **No** в противен случай.
```cs
string input = Console.ReadLine();
bool variable = Convert.ToBoolean(input);
if (variable == true) Console.WriteLine("Yes");
else Console.WriteLine("No");
```

### Задача: Специални числа
Число наричаме **специално**, когато сумата от цифрите му е 5, 7 или 11. За всички числа от 1 до n изведете дали числото е специално.
```cs
int n = int.Parse(Console.ReadLine());
for (int num = 1; num <= n; num++)
{
  int sumOfDigits = 0;
  int digits = num;
  while (digits > 0)
  {
    sumOfDigits += digits % 10;
    digits = digits / 10;
  }
  bool special = (sumOfDigits == 5) || …; // TODO: довърши
  Console.WriteLine("{0} -> {1}", num, special);
}
```

### Преобразуване с Convert

**Convert.ToInt32**(данни, основа) – позволява ни да преобразуваме текстов низ със записано число в бройна система към цяло число от тип int

```cs
int nums = Convert.ToInt32(Console.ReadLine(), 16);
```

**Convert.ToString**(данни) = позволява ни да преобразуваме данни от променлива към низ

```cs
string output = "Value: " + Convert.ToString(nums);
```

**Convert.ToString**(данни, основа) = позволява ни да преобразуваме данни от променлива към число в бройна система със зададена основа. Числото се записва като низ

```cs
string output = "Binary Value: " + Convert.ToString(nums, 2);
```

### Знак
Типът данни **знак** в C#
* Представя символната информация
* Декларира се с **char** ключовата дума
* Всеки символ съответства на числов код
* Стойността по подразбиране е '\0‚
* Заема 16 бита в паметта (от U+0000 до U+FFFF)
* Сдъръжа един Уникод знак (или част от знак)

### Знаци и кодове
Всеки знак има уникална цяла Уникод стойност (int):
```cs
char ch = 'a';
Console.WriteLine("The code of '{0}' is: {1}", ch, (int) ch);
ch = 'b';
Console.WriteLine("The code of '{0}' is: {1}", ch, (int) ch);
ch = 'A';
Console.WriteLine("The code of '{0}' is: {1}", ch, (int) ch);
ch = 'щ';  // кирилската буква „щ“
Console.WriteLine("The code of '{0}' is: {1}", ch, (int) ch);
```

### Задача: Тройки латински знаци
Напишете програма, която въвежда цяло число n и извежда висчки тройки от първите n малки латински знаци, подредени по азбучен ред.
```cs
int n = int.Parse(Console.ReadLine());
  for (int i1 = 0; i1 < n; i1++)
    for (int i2 = 0; i2 < n; i2++)
      for (int i3 = 0; i3 < n; i3++)
      {
        char letter1 = (char)('a' + i1);
        char letter2 = // TODO: довърши
        char letter3 = // TODO: довърши и това
        Console.WriteLine("{0}{1}{2}",
          letter1, letter2, letter3);
      }
```

### Екраниращи знаци
Екраниращите последователности ссъдържат специален знак като ', " или \n (нов ред) или съдържат системни знаци (като \[TAB] знакът \t). Често срещани екраниращи последователности:

* ' = апостроф
* " = двойна кавичка
* \ = наклонена черта
* \n = нов ред
* \uXXXX = Уникод символ

### Низове
Низовете в C# представят поредица от знаци. Задават се чрез **string** ключова дума. Имат празна стойност по подразбиране (**null**). Низовете се обграждат с кавички:
```cs
string s = "Hello, C#";
```

Низовете могат да се слепят чрез оператор **+**.

### Дословни (verbatim) и съставни (interpolated) низове
Низовете са обградени от кавички "":
```cs
string file = "C:\\Windows\\win.ini";
```

Низовете могат да са **дословни** (без екраниране):
```cs
string file = @"C:\Windows\win.ini";
```

**Съставните** низове съдържатстойности на променливи по шаблон:
```cs
string firstName = "Svetlin";
string lastName = "Nakov";
string fullName = $"{firstName} {lastName}";
```

### Задача: Поздрав по име и възраст
Напишете програма, която въвежда малкото име, фамилията и възрастта и извежда "Hello, . You are years old."
```cs
string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
string ageStr = Console.ReadLine();
int age = int.Parse(ageStr); // Преобразуване от string към int
Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");
```

### Обектен тип
* Специален тип – родител на всички други типове в .NET
* Задава се чрез **object** ключова дума
* Може да приема стойности от който и да е тип
* Референтен тип – съдържа указател към област в паметта, на която се съхранява неговата стойност

### Задача: Низове и обекти
Декларирайте две променливи от тип string и им присвоете стойност, в променлива от тип object присвоете резултата от слепянето на двете променливи, а от там прехвърлете на друга променлива от тип string.
```cs
string a = "Hello";
string b = "World";
object c = a + " " + b;
string d = (string) c;
Console.WriteLine(d);
```

### Именуване на променливи
* Винаги използвайте **конвенциите за именуване** на даден програмен език, за C# ползвайте **camelCase**
* Предпочитан формат: \[съществително] или \[прилагателно] + \[съществително]
* Трябва да описва предназначението на променливата (Винаги се питайте „Какво съдържа тази променлива?“)

### Живот и област на видимост на променливите
* Област на видимост (**variable scope**) = мястото където можем да достъпим променлива (глобално, локално)
* Живот (**sariable lifetime**) = колко дълго остава в паметтa
```cs
static void Main()
{
  var outer = "I'm inside the Main()";
  for (int i = 0; i < 10; i++) 
  {
    var inner = "I'm inside the loop";
  }
  Console.WriteLine(outer);
  // Console.WriteLine(inner); // Грешка
}
```

### Промеждутък на променлива
Промеждутък (**variable span**) определя колко време съществува една променлива преди да я използваме. Винаги създавайте променливата колкото се може по-късно.

```cs
static void Main()
{
    var outer = "I'm inside the Main()";
    for (int i = 0; i < 10; i++) 
    {
        var inner = "I'm inside the loop";
    }
    Console.WriteLine(outer);
    // Console.WriteLine(inner); // Грешка
}
```

**По-краткия промеждутък** опростява кода. Подобрява неговата четимост и улеснява бъдещи промени.

### Задача: Обем на пирамида
Имате работещ код за намиране на обема на пирамида. Оправете именуването, промеждутъка и използването на променливите.
```cs
double dul, sh, V = 0;
Console.Write("Length: ");
dul = double.Parse(Console.ReadLine());
Console.Write("Width: ");
sh = double.Parse(Console.ReadLine());
Console.Write("Height: ");
V = double.Parse(Console.ReadLine());
V = (dul * sh * V) / 3;
Console.WriteLine("Pyramid Volume: {0:F2}", V);
```

### Задача: Специални числа
Рефакторирайте кода на задачата Специални числа.
```cs
int kolkko = int.Parse(Console.ReadLine());
int obshto = 0; int takova = 0; bool toe = false;
for (int ch = 1; ch <= kolkko; ch++)
{
    takova = ch;
    while (ch > 0)
    {
        obshto += ch % 10;
        ch = ch / 10;
    }
    toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
    Console.WriteLine($"{takova} -> {toe}");
    obshto = 0; ch = takova;
}
```

## 3. Масиви и Списъци

### Какво представляват масивите?
В програмирането, масивът представлява множество от елементи. Елементите са номерирани от 0 до N-1 са от еднакъв тип. Масивите имат фиксиран размер, който не може да бъде променян.

### Работа с масиви
**Създаване** на масив от десет цели числа:
```cs
int[] numbers = new int[10];
```

**Задаване на стойности** на елементите на масива:
```cs
for (int i = 0; i < numbers.Length; i++) numbers[i] = 1;
```

**Достъп** до елементите на масива по индекс
```cs
numbers[5] = numbers[2] + numbers[7];
numbers[10] = 1; // IndexOutOfRangeException
```

### Пример: Дни от седмицата
Дните от седмицата могат да бъдат запазени в **масив от низове**:
```cs
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
```

### Задача: Ден от седмицата
Въведете ден от седмицата като число \[1…7] и изведете името на деня (in English) или "Invalid day!"
```cs
string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int day = int.Parse(Console.ReadLine());
if (day >= 1 && day <= 7) Console.WriteLine(days[day - 1]);
else Console.WriteLine("Invalid day!");
```

### Стойностен и референтен тип

**Стойностен тип = Value Type**

променливите държат в себе си собствената стойност. В стека може да получим стойността на променливата като я извикаме по име.
```cs
int, float, double, bool, char, DateTime, BigInteger, …
```
https://msdn.microsoft.com/library/bfft1t3c.aspx
```cs
int i = 42;
char ch = 'A';
bool result = true;
```
Всяка променлива пази копие на данните.

Пример за стойностен тип:
```cs
public static void Main()
{
  int num = 5;
  Increment(num, 15);
  Console.WriteLine(num);
}
private static void Increment(int num, int value)
{
  num += value;
}
```

**Референтни типове = Reference Types**

Променливите от референтен тип съдържат (указател/адрес от паметта), на който се пазят стойностите на данните.
```cs
string, int[], char[], string[], Random, инстанции на classes, interfaces, delegates
```
В стека може да получим адреса в динамичната памет (**heap**), на който стои стойността като я извикаме по име. В този тип пазим не стойността, а адреса на стойността. Две променливи от референтен тип могат да указват/сочат (**reference**) един и същи обект. Операциите за достъп/промяна чрез двата обекта въздействат върху едни и същи данни.

```cs
var arr = new int[] { 1, 2, 3, 4, 5, 6 };
```
Пример за референтен тип:
```cs
public static void Main()
{
  int[] nums = { 5 };
  Increment(nums, 15);
  Console.WriteLine(nums[0]);
}
private static void Increment(int[] nums, int value)
{
  nums[0] += value;
}
```

### Масиви
**Въвеждане на масиви от конзолата**

Първо, въвеждаме броя на елементите length на масива:
```cs
int n = int.Parse(Console.ReadLine());
```
После създаваме масив с n на брой елементи и ги въвеждаме :
```cs
int[] arr = new int[n];
for (int i = 0; i < n; i++) arr[i] = int.Parse(Console.ReadLine());
```

**Въвеждане стойностите на масива на един ред**

Стойностите на масив могат да бъдат въведени на един ред, разделени с интервал:
```
2 8 30 25 40 72 -2 44 56
```
Използвайки следния програмен фрагмент:
```cs
string values = Console.ReadLine();
string[] items = values.Split(' ');
int[] arr = new int[items.Length];
for (int i = 0; i < items.Length; i++) arr[i] = int.Parse(items[i]);
```
Въвеждане на масив от цели числа, чрез функционално програмиране:
```cs
using System.Linq;
...
var inputLine = Console.ReadLine();
string[] items = inputLine.Split(' ');
int[] arr = items.Select(int.Parse).ToArray();
```
или още по-късо:
```cs
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
```

**Извеждане на масив на конзолата**

За извеждане на елементите на масив може да се ползва цикъл for. Разделяне на елементите с интервал или нов ред.
```cs
string[] arr = {"one", "two", "three", "four", "five"};
// Process all array elements
for (int index = 0; index < arr.Length; index++)
{
  // Print each element on a separate line
  Console.WriteLine("arr[{0}] = {1}", index, arr[index]);
}
```

**Извеждане на масив с foreach и String.Join**
* С цикъл foreach
```cs
int[] arr = { 10, 20, 30, 40, 50};
foreach (var element in arr) Console.WriteLine(element);
```
* Със string.Join(separator, array)
```cs
int[] arr = { 1, 2, 3 };
Console.WriteLine(string.Join(", ", arr)); // 1, 2, 3
string[] strings = { "one", "two", "three", "four" };
Console.WriteLine(string.Join(" - ", strings)); // one - two - three - four
```

#### Методи
**Reverse**
```cs
int[] arr = new int[] {  2, 4, -5, 1, 10  };
Array.Reverse(arr);
Console.WriteLine(string.Join(" ", arr));
```
**Sort**
```cs
int[] arr = new int[] {  2, 4, -5, 1, 10  };
Array.Sort(arr);
Console.WriteLine(string.Join(" ", arr));
```
**Clear**
```cs
int pos=1;
int countOfZero=2
int[] arr = new int[] {  2, 4, -5, 1, 10  };
Array.Clear(arr,pos,countOfZero);
Console.WriteLine(string.Join(" ", arr));
```
**CopyTo**

```cs
int[] source = new int[] {1,2,3};
int[]  destination =new int[] { 2, 4, -5, 1, 10 };	 
source.CopyTo( destination, 1 );
Console.WriteLine( string.Join(" ", destination ) );
```
**Copy**
```cs
int[] source = new int[] {2,4,6,8,10,12,14,16};
int[] destination = new int[] {1,3,5,7,9,11,13,15,17};
Array.Copy(source,4,destination,2,3);  	
Console.WriteLine(string.Join(" ", destination));
```

#### Сортиране

**Сортирането** на множество представлява **подреждане** на елементите му по даден признак. Най-често в сортираното множество елементите са подредени във **възходящ** или **низходящ** ред. Възможно е подреждането да бъде направено по няколко критерия. Това означава, че ако два елемента имат една и съща стойност по даден признак, т.е. са равни, то може да бъдат подредени според следващ признак. Тогава говорим за подредба по повече от един критерий, като има значение кой критерий е първи и кой втори.

**Характеристики на сортирането на множества** Сортираме (подреждаме) множества за по-бързо търсене на елементи в него. Основните особености на едно сортиране са:
* Сложността (брой сравнения и размени на елементи)
* Използвани ресурси (памет)
* Стабилност (дали елементите се разместват по друг критерий, ако по критерия по който подреждаме са равни )
* Реализацията на метода зависи от структурата на паметта, в която са записани данните.

**Метод на мехурчето**
```cs
int[] arr = new int[] { 2, 4, -5, 1, 10 };
for (int i = 0; i < arr.Length - 1; i++)
{
	for (int j = 0; j < arr.Length - 1; j++)
	{
		if (arr[j] > arr[j + 1]) 
		{
			int swapVar = arr[j];
			arr[j] = arr[j + 1];
			arr[j + 1] = swapVar;
		}
	}
}
for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
```
**Метод на прекия избор (пряка селекция)**
```cs
int[] arr = new int[] {  2, 4, -5, 1, 10  };          
for (int i = 1; i < arr.Length; i++) 
{
	int k = i;
	for (int j = i + 1; j < arr.Length; j++) 
	{
		if (arr[j] < arr[k])
		k = j;
	}
	int swapVar = arr[i];
	arr[i]=arr[k];
	arr[k]=swapVar;
}
Console.WriteLine(string.Join(" ", arr));
```
**Сортиране чрез вмъкване**
```cs
int [] arr = { 2, 4, -5, 1, 10 };	
for (int i = 0; i < arr.Length; i++)
{
	int swapVar = arr[i];
	int index = i;
	while (index > 0 && arr[index-1]>=swapVar)
	{
	    arr[index] = arr[index-1];
	    index --; 
	}
	arr[index]=swapVar;	
}	
Console.WriteLine(string.Join(" ",arr));
```
### Списъци

**Създаване на списък**
```cs
List<string> list = new List<string>() { "one", "two", "three", "four", "five", "six"};
```
**Въвеждане на списък от конзолата**
```cs
List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
```
**Отпечатване на списък на конзолата**
```cs
Console.WriteLine(string.Join(", ", list));   
```

**Операции със списъци**

| Операция               | Информация                                               |
| ---------------------- | -------------------------------------------------------- |
| Add(element)           | добавя елемент към List                                  |
| Count                  | връща броя на елементите в List                          |
| Remove(element)        | премахва първото срещане на елемент (връща true / false) |
| RemoveAt(index)        | премахва елемент по неговия индекс                       |
| Insert(index, element) | вмъква елемент на зададената позиция                     |
| Contains(element)      | определя дали елемента се съдържа в списъка              |
| Sort()                 | сортира във възходящ ред                                 |
| Reverse()              | обръща списъка наобратно                                 |

## 4. Методи и дебъгване
### Методи
Метод е именована част от кода, която може да бъде извикана.

#### Дефиниране и извикване на методи
**Дефиниране** на метод:
```cs
static void PrintHeader()
{
  Console.WriteLine("----------");
}
```
**Извикване** на метод:
```cs
PrintHeader();
```

#### Методи с параметри
**Параметрите** могат да са от всеки тип данни:
```cs
static void PrintNumbers(int start, int end)
{
  for (int i = start; i <= end; i++)
  {
    Console.Write("{0} ", i);
  }
}
```

**Извикването** на метода е с конкретни стойности (аргументи):
```cs
static void Main()
{
  PrintNumbers(5, 10);
}
```
* Може да подадете **нула** или **повече** параматъра.
* Може да подавате параметри от **различен тип**.
* Всеки параметър има **име** и **тип**.
```cs
static void PrintStudent(string name, int age, double grade)
{
    Console.Write("Student: {0}; Age: {1}, Grade: {2}", name, age, grade);
}
```
Параметрите могат да имат **стойности по подразбиране**:
```cs
static void PrintNumbers(int start = 0, int end = 100)
{
  for (int i = start; i <= end; i++)
  {
    Console.Write("{0} ", i);
  }
}
```
Методът по-горе може да бъде извикан по множество начини:
```cs
PrintNumbers(5, 10);
PrintNumbers(15);
PrintNumbers();
PrintNumbers(end: 40, start: 35);
```

#### Връщана стойност от метод
Тип _void_\* – не връща стойност (само изпълнява код)
```cs
static void AddOne(int n) 
{
  n += 1;
  Console.WriteLine(n);
}
```
Други типове – връща стойности, от **типа, връщан от метода**
```cs
static int PlusOne(int n) 
{
  return n + 1;
}
```
Ключовата дума **return** прекъсва изпълнението на метода и връща указаната стойност:
```cs
static string ReadFullName() 
{
  string firstName = Console.ReadLine();
  string lastName = Console.ReadLine();
  return firstName + " " + lastName;
}
```
void методите могат да бъдат завършени чрез команда **return**.

**Използването на връщана стойност**

Връщаната стойност може да бъде:

* **Присвоена** на променлива:
```
int max = GetMax(5, 10);
```

* **Използвана** в израз:
```cs
decimal total = GetPrice() * quantity * 1.20m;
```
* **Подадена** на друг метод:
```cs
int age = int.Parse(Console.ReadLine());
```

#### Предефиниране на методи
Комбинацията от името и параметрите на метод се нарича негова **сигнатура**:
```cs
static void Print(string text)
{
  Console.WriteLine(text);
}
```

Сигнатурата ни помага да различим методи с еднакви имена. Когато два метода с едно и също име имат различна сигнатура, това се нарича **предефиниране** на метод.
```cs
static void Print(string text)
{
    Console.WriteLine(text);
}
static void Print(int number)
{
    Console.WriteLine(number);
}
static void Print(string text, int number)
{
    Console.WriteLine(text + ' ' + number);
}
```
Типът данни, връщани от метода **не е част** от сигнатурата му:

### Дебъгване и оправяне на кода

#### Ред на изпълнение

"Стекът" съдържа информация за активните подпрограми (методи) на текущо изпълняваната компютърна програма. Пази информация за **точките**, към които всяка активна подпрограма трябва да **върне контрола**, когато тя завърши **изпълнението си**.

#### Дебъгване на кода

Процесът на **дебъгване на програма** включва:

* Откриване на грешка
* Откриване на редовете в кода, които я предизвикват
* Коригиране на грешката в кода
* Проверка дали грешката е отстранена и дали междувременно не са добавени нови грешки

Това е многократен и продължителен процес в който **дебъгерът** помага много.

Visual Studio има вграден дебъгер, който ни предлага:
* **Стопери** (breakpoints)
* Възможност да **следим** изпълнението на кода
* Средство за **наблюдение** на променливите по време на изпълнението на програмата

**Използване на дебъгера във Visual Studio**
* Стартиране без дебъгер: **\[Ctrl+F5]**
* Активиране на стопер: **\[F9]**
* Стартиране с дебъгер: **\[F5]**
* Проследяване на кода: **\[F10] / \[F11]**
* Използване на **Locals / Watches**
* Условни стопери
* Дебъг режим след изключение

#### Методи
**Препоръки при именуването на методи:**

* Използвайте описателни имена на методи
* Името трябва да отговаря на въпроса: Какво прави този метод?
* Ако не намирате добро име за вашия метод, помислете дали той е с ясно дефинирано предназначение

**Имена на параметрите на метод:**
* Препоръка: \[Съществително] или \[Прилагателно] + \[Съществ.]
* Трябва да е в camelCase
* Трябва да е говорящо
* Мерните единици трябва да са очевидни

**Добри практики при писане на методи**
* Методът трябва да изпълнява една добре дефинирана задача.
* Името му трябва ясно и недвусмислено да описва тази задача.
* Избягвайте методи, по-дълги от един екран.
* Разделете ги на няколко по-кратки метода.

**Структура и форматиране на кода**
* Подсигурете се, че коректно вмъквате кода
* Оставяйте празен ред между методите, след цикли и след if-команди
* Тялото на цикли и if-команди ограждайте с къдрави скоби
* Избягвайте дълги редове и сложни изрази

## 5. Символни низове
Символните низове са **immutable** поредица от символи.

**String and Char Array**
```cs
string str = new String(new char[] {'s', 't', 'r'});
char[] array = str.ToCharArray(); // ['s', 't', 'r']
```
**Compare**
```cs
int result = string.Compare(str1, str2);
// result == 0 if str1 equals str2
// result < 0 if str1 is before str2
// result > 0 if str1 is after str2
```
**Concat**
```cs
string str = string.Concat(str1, str2); 
```
**IndexOf**
```cs
string email = "vasko@gmail.org";
int index = email.IndexOf("@"); // 5
```
**LastIndexOf**
```cs
string verse = "To be or not to be...";
int index = verse.LastIndexOf("be"); // 16
```
**Substring**
```cs
string filename = @"C:\Pics\Rila2017.jpg";
string name = filename.Substring(8, 8); // "Rila2017"
```
**Split**
```cs
string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
string[] beers = listOfBeers.Split(' ', ',', '.');
```
**Replace**
```cs
string cocktail = "Vodka + Martini + Cherry";
string replaced = cocktail.Replace("+", "and"); // Vodka and Martini and Cherry
```
**Remove**
```cs
string price = "$ 1234567";
string lowPrice = price.Remove(2, 3); // $ 4567
```
**ToLower and ToUpper**
```cs
string alpha = "aBcDeFg";
string lowerAlpha = alpha.ToLower(); // abcdefg
string upperAlpha = alpha.ToUpper(); // ABCDEFG
```
**Trim, TrimStart and TrimEnd**
```cs
string s = "    example of white space    ";
string clean = s.Trim(); // "example of white space"
string left = s.TrimStart(); // "example of white space    "  
string right = s.TrimEnd(); // "    example of white space" 
```
**StringBuilder**
```cs
var builder = new StringBuilder(100);
builder.Append("Hello Maria, how are you?");
Console.WriteLine(builder); // Hello Maria, how are you?
builder[6] = 'D';
Console.WriteLine(builder); // Hello Daria, how are you?
builder.Remove(5, 6);
Console.WriteLine(builder); // Hello, how are you?
builder.Insert(5, " Peter");
Console.WriteLine(builder); // Hello Peter, how are you?
builder.Replace("Peter", "George");
Console.WriteLine(builder); // Hello George, how are you?
string text = builder.ToString();
```

## 6. Многомерни масиви
**Какво е многомерен масив?**
* Двумерен масив = таблица; Всеки елемент се идентифицира чрез две измерения – номер на реда и номер на колоната в таблицата
* Многомерен масив = Аналогично можем да имаме допълнителни измерения в масива. В този случай е удобно да си представяме масив, в който всеки елемент е масив с по-ниско измерение.
* Основните правила, които важат за едномерни масиви важат и за многомерени

**Двумерен масив (матрица)**

Има (rows x columns) на брой елементи, където rows е брой на редовете, а columns – на колоните. Размера на масива е постоянен по всяко негово измерение – не се променя. Елементите са от един и същ тип. Елементите във всяко измерение са номерирани с два индекса: ред и колона.

**Деклариране на многомерен масив**

Досега едномерен масив от цели числа декларирахме чрез int\[], двумерен масив бихме декларирали по следния начин:
```cs
int[,] twoDiаmentionalArray;
```
Аналогично тримерен масив бихме декларирали така:
```cs
int[,,] threeDimentionalArray;
```
Няма теоретично ограничение за броя на размерностите на масив, но в практиката масиви с повече от 2 размерности са рядко срещани.

**Деклариране и заделяне**

Отбелязването на променливата като многомерен масив само по себе си не заделя памет за неговите елементи. За целта използваме **new**:
```
int[,] intMatrix = new int[3, 4];
float[,,] floatCube = new float[5, 5, 5];
```

**Инициализация на двумерен масив**
Както при едномерените масиви можем да зададем стойности на многомерния масив веднага след деклариране:
```cs
int[,] intMatrix = 
{
  {2, 8, 3, 5},
  {7, 9, 0, 3},
};
```

**Достъп до елементите на многомерен масив**

Както при едномерните масиви, така и при многомерните всички индекси започват от 0. Разликата е, че тук индексите са повече от 1. Ето как да достъпим елементите на примера от предния слайд:
```cs
intMatrix[0, 0]
```
Индексите се отделят със запетаи!

**Дължина на многомерен масив**

Всяка размерност на многомерен масив може да има различна дължина спрямо останалите. Поради тази причина всяка размерност се номерира по сходен начин на индексите. За да разберем колко реда има двумерния масив от примера:
```cs
intMatrix.GetLength(0);
```
А за да разберем колко колони има:
```cs
intMatrix.GetLength(1);
```

### Примери
**Отпечатване на матрица**
```cs
int[,] intMatrix = 
{
  {2, 8, 3, 5},
  {7, 9, 0, 3},
};
for(int row = 0; row < intMatrix.GetLength(0); row++)
{
  for(int col = 0; col < intMatrix.GetLength(1); col++)
  {
    Console.Write(intMatrix[row, col]+" ");
  }
  Console.WriteLine();
}
```

**Вход/Изход на матрица**
```cs
int rows = int.Parse(Console.ReadLine()); //въвеждаме брой редове
int cols = int.Parse(Console.ReadLine()); //въвеждаме брой колони
int[,] matrix = new int[rows, cols]; //заделяме съответния брой елементи

for(int row = 0; row < rows; row++)
{
  for(int col = 0; col < cols; col++)
  {
    Console.Write("matrix[{0},{1}] = ", row, col);
    matrix[row, col] = int.Parse(Console.ReadLine());
  }
}
// TODO: отпечатваме елементите на масива като в предния пример
```

### Назъбени масиви
Назъбен масив (**jagged array**) = масив от масиви, всеки с различна дължина. Назъбените масиви се създават чрез 1 двойка от скоби за всяко измерение:
```cs
int[][] jaggedArray;
```
Заделяне:
```cs
jaggedArray = new int[2][];
jaggedArray[0] = new int[5];
jaggedArray[1] = new int[3];
```
Инициализиране:
```cs
int[][] jaggedArray = {
  new int[] { 2, 8, 4, 6},
  new int[] { 3, 6},
  new int[] { 10, 20, 40}
};
```
Достъп до елементите:
```cs
jaggedArray[0][3] = 18;
```
Назъбен масив от двумерни масиви:
```cs
int[][,] jaggedOfTwo = new int[2][,];
jaggedOfTwo[0] = new int[,] { {5, 3}, {2, 9} };
jaggedOfTwo[1] = new int[,] { {3, 5, 2}, {8, 2, 9} };
```

### Задача: Триъгълник на Паскал
Генерирайте и изпечатайте Триъгълника на Паскал по зададена височина h. Триъгълника на паскал съдържа:
* Числото 1 на 1 ред
* Всяко число на всеки следващ ред се получава от сбора на двете числа над него
```cs
int h = int.Parse(Console.ReadLine());
long[][] triangle = new long[h+1][];
for(int row = 0; row < h; row++) {
  triangle[row] = new long[row + 1];
}
triangle[0][0] = 1;
for(int row = 0; row < h-1; row++) {
  for(int col = 0; col <= row; col++) {
    triangle[row + 1][col] += triangle[row][col];
    triangle[row + 1][col + 1] += triangle[row][col];
  }
}
// TODO: Изпечатване с подходящо форматиране
```

## 7. Речници и хеш таблици

**Асоциативните масиви** са масиви, чиито индекси са **ключове**. Ключовете мога да бъдат думи или пък реални числа, за разлика от индексите на обикновения масив. Съдържат информация в **двойки** {**ключ** -> **стойност**}

### Речници и сортирани речници
**Dictionary**
```cs
var dict = new Dictionary<string, int>();
foreach (var pair in dict) 
Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
```
**SortedDictionary**
```cs
var sortedDict = new SortedDictionary<string,int>();
Console.WriteLine(String.Join(", ", sortedDict.Keys));
Console.WriteLine(String.Join(", ", sortedDict.Values));
```
Функции:
* Count = пази броя на двойките от ключ-стойност
* Keys = съдържа уникалните ключове
* Values = съдържа всички стойности
* Основни операции: \[], Add(), Remove(), Clear()
* ContainsKey() = проверява дали даден ключ съществува в речника (бърза операция)
* ContainsValue() = проверява дали дадена стойност съществува в речника (бавна операция)
* TryGetValue() = проверява дали даден ключ съществува в речника и отпечатва стойността му

### LINQ
**Min()** = намира най-малкия елемент в колекция
```cs
new List<int>() { 1, 2, 3, 4, -1, -5, 0, 50 }.Min() = -5
```
**Max()** = намира най-големия елемент в колекция
```cs
new int[] { 1, 2, 3, 40, -1, -5, 0, 5 }.Max() = 40
```
**Sum()** = намира сумата на всички елементи в колекция
```cs
new long[] {1, 2, 3, 4, -1, -5, 0, 50}.Sum() = 54
```
**Average()** = намира средноаритметичното на всички елементи
```cs
new int[] {1, 2, 3, 4, -1, -5, 0, 50}.Average() = 6.75
```
**Select()** = въвежда колекция на един ред
```cs
var nums = Console.ReadLine().Split().Select(int.Parse); 
```
**ToArray()** и **ToList()** = преобразуване на колекции
```cs
int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
```
**OrderBy()**, **OrderByDescending()** и **ThenBy()** = сортиране на колекции
```cs
Dictionary<int, string> products = new Dictionary<int, string>();
Dictionary<int, string> sortedDict = products.OrderBy(pair => pair.Value).ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
```
**Take()** = взимане на определени елементи
```cs
var nums = new List<int>() { 10, 20, 30, 40, 50, 60}
nums = nums.Take(3).ToArray(); // nums = [10, 20, 30]
```
**Skip()** = пропускане на елементи
```cs
var nums = new List<int>() { 10, 20, 30, 40, 50, 60}
nums = nums..Skip(3).Take(2).ToArray(); // nums = [40, 30]
```

### Ламбда изрази
Ламбда изразите са **анонимна функция** съдържаща изрази и твърдения.
```cs
var lambda = (a => a > 5);
```

Лявата страна описва **входните** параметри. Дясната страна описва **израза** или **твърдението**.

#### Филтриране на колекции
Филтриране на колекции чрез Where() и Count()
```cs
int[] nums = { 1, 2, 3, 4, 5, 6};
nums = nums.Where(num => num % 2 == 0).ToArray(); // nums = [2, 4, 6]
int count = nums.Count(num => num % 2 == 0); // count = 3
```
Филтриране и сортиране с Ламбда функции
```cs
int[] nums = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };
nums.OrderBy(x => x).Take(3);    // 11 22 33
nums.Where(x => x < 50);         // 11 33 44 22
nums.Count(x => x % 2 == 1);     // 5
nums.Select(x => x * 2).Take(5); // 22 198 66 110 154
```
Извличане на уникални елементи от колекция
```cs
int[] nums = { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };
nums = nums.Distinct().ToArray(); // nums = [1, 2, 3, 4, 5, 6, -2, 0, 15]
```
Извличане на един елемент от колекция
```cs
int[] nums = { 1, 2, 3, 4, 5, 6 };
int firstNum = nums.First(x => x % 2 == 0); // 1
int lastNum = nums.Last(x => x % 2 == 1); // 6
int singleNum = nums.Single(x => x == 4); // 4
```
Обръщане и слепяне на колекции
```cs
int[] nums = { 1, 2, 3, 4, 5, 6};
nums = nums.Reverse(); // nums = 6, 5, 4, 3, 2, 1
int[] otherNums = { 7, 8, 9, 0 };
nums = nums.Concat(otherNums); // nums = 1, 2, 3, 4, 5, 6, 7, 8, 9, 0
```

#### Задача: Сгъни и сумирай
Въведете масив от 4_k цели числа, сгънете го и изведете сумата от горните и долните редове (2_k цели числа):
```cs
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int k = arr.Length / 4;
int[] row1left = arr.Take(k).Reverse().ToArray();
int[] row1right = arr.Reverse().Take(k).ToArray();
int[] row1 = row1left.Concat(row1right).ToArray();
int[] row2 = arr.Skip(k).Take(2 * k).ToArray();
var sumArr = row1.Select((x, index) => x + row2[index]);
Console.WriteLine(string.Join(" ", sumArr));
```
