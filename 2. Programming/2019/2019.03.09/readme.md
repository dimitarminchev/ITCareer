# Речници, сортирани речници, ламбда изрази и LINQ  

## Речници и сортирани речници
Dictionary
```
var dict = new Dictionary<string, int>();
foreach (var pair in dict) 
Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
```
SortedDictionary
```
var sortedDict = new SortedDictionary<string,int>();
Console.WriteLine(String.Join(", ", sortedDict.Keys));
Console.WriteLine(String.Join(", ", sortedDict.Values));
```
Функции
- Count = пази броя на двойките от ключ-стойност
- Keys = съдържа уникалните ключове 
- Values = съдържа всички стойности
- Основни операции: [], Add(), Remove(), Clear()
- ContainsKey() = проверява дали даден ключ съществува в речника (бърза операция)
- ContainsValue() = проверява дали дадена стойност съществува в речника (бавна операция)
- TryGetValue() = проверява дали даден ключ съществува в речника и отпечатва стойността му

## LINQ 
- Min() = намира най-малкия елемент в колекция
- Max() = намира най-големия елемент в колекция
- Sum() = намира сумата на всички елементи в колекция
- Average() = намира средноаритметичното на всички елементи
- Select() = въвежда колекция на един ред
- ToArray() и ToList() = преобразуване на колекции
- OrderBy(), OrderByDescending() и ThenBy() = сортиране на колекции
- Take() = взимане на определени елементи
- Skip() = пропускане на елементи

## Ламбда изрази
Филтриране на колекции чрез Where() и Count()
```
int[] nums = { 1, 2, 3, 4, 5, 6};
nums = nums.Where(num => num % 2 == 0).ToArray(); // nums = [2, 4, 6]
int count = nums.Count(num => num % 2 == 0); // count = 3
```
Филтриране и сортиране с Ламбда функции
```
int[] nums = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };
nums.OrderBy(x => x).Take(3);    // 11 22 33
nums.Where(x => x < 50);         // 11 33 44 22
nums.Count(x => x % 2 == 1);     // 5
nums.Select(x => x * 2).Take(5); // 22 198 66 110 154
```
Извличане на уникални елементи от колекция
```
int[] nums = { 1, 2, 2, 3, 4, 5, 6, -2, 2, 0, 15, 3, 1, 0, 6 };
nums = nums.Distinct().ToArray(); // nums = [1, 2, 3, 4, 5, 6, -2, 0, 15]
```
Извличане на един елемент от колекция
```
int[] nums = { 1, 2, 3, 4, 5, 6 };
int firstNum = nums.First(x => x % 2 == 0); // 1
int lastNum = nums.Last(x => x % 2 == 1); // 6
int singleNum = nums.Single(x => x == 4); // 4
```
Обръщане и слепяне на колекции
```
int[] nums = { 1, 2, 3, 4, 5, 6};
nums = nums.Reverse(); // nums = 6, 5, 4, 3, 2, 1
int[] otherNums = { 7, 8, 9, 0 };
nums = nums.Concat(otherNums); // nums = 1, 2, 3, 4, 5, 6, 7, 8, 9, 0
```