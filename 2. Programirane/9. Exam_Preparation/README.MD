# Подготовка за изпит
## Task 01. Resurrection (Result: 100/100)
```
int n = int.Parse(Console.ReadLine());
while (n > 0)
{
   long totalLength = int.Parse(Console.ReadLine());
   decimal totalWidth = decimal.Parse(Console.ReadLine());
   long wingLength = int.Parse(Console.ReadLine());
   decimal totalYears = (totalLength * totalLength) * (totalWidth + 2 * wingLength);
   Console.WriteLine(totalYears);
   n--;
}
```
Test: https://judge.softuni.bg/Contests/760/Progr-Fund-Extended-Retake-Exam-04-Sept-2017-Part-I

## Task 02. Icarus (Result: 100/100)
```
var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
   int start = int.Parse(Console.ReadLine());
   int pos = start, minus = 1;
   string line = Console.ReadLine();
   do
   {
    var parts = line.Split(' ');
    String command = parts[0];
    int steps = int.Parse(parts[1]);    
    switch (command)
    {
     case "left":
     {
       while(steps>0)
       {
        pos--;
        if (pos < 0)
        {
         pos = nums.Length - 1;
         minus++;
        }
        nums[pos] -= minus;
        steps--;
       }
       break;
     }
     case "right":
     {
       while (steps > 0)
       {        
        pos++;
        if (pos > nums.Length - 1)
        {
         pos = 0;
         minus++;
        }
        nums[pos] -= minus;
        steps--;
       }
       break;
     }
    }
    line = Console.ReadLine();
   }
   while(line != "Supernova");
   Console.WriteLine(String.Join(" ", nums));
```
Test: https://judge.softuni.bg/Contests/760/Progr-Fund-Extended-Retake-Exam-04-Sept-2017-Part-I

## Task 03. Phoenix Grid (Result: 100/100)
```
string message = Console.ReadLine();
while (message != "ReadMe")
  {
  bool IsAPalindrome = true;
  for (int i = 3; i <= message.Length - 1; i += 4)
   if (message[i] != '.') IsAPalindrome = false;

  if (message.Contains(' ') || message.Contains('_') || message.Contains('\t')) IsAPalindrome = false;

  for (int i = 0; i <= message.Length / 2; i++)
   if (message[i] != message[message.Length - 1 - i])
    IsAPalindrome = false;

  if (IsAPalindrome == true) Console.WriteLine("YES");
  else Console.WriteLine("NO");
  message = Console.ReadLine();
}
```
Test: https://judge.softuni.bg/Contests/761/Progr-Fund-Extended-Retake-Exam-04-Sept-2017-Part-II

## Task 04. CODE: Phoenix Oscar Romeo November (Result: 100/100)
```
var dict = new Dictionary<String, List<String>>();
string line = Console.ReadLine();
while (line != "Blaze it!")
{
  var Parts = line.Split('>');
  var Creature = Parts[0].Trim('-').Trim(' '); 
  var SquadMate = Parts[1].Trim(' ');
  if (Creature != SquadMate)
  {
   if (!dict.ContainsKey(Creature)) dict.Add(Creature, new List<String>() { SquadMate });
   else if(!dict[Creature].Contains(SquadMate)) dict[Creature].Add(SquadMate);
  }
  line = Console.ReadLine();
}
var nope = new Dictionary<String, List<String>>(); 
foreach (var creature in dict)
{
  var list = new List<String>();
  foreach (var mate in creature.Value)
  {
   if (dict.ContainsKey(mate))
   if (dict[mate].Contains(creature.Key)) continue;
   list.Add(mate);
  }
  nope.Add(creature.Key, list);
}
var sorted = nope.OrderByDescending(x => x.Value.Count);
foreach (var item in sorted) Console.WriteLine("{0} : {1}", item.Key, item.Value.Count);
```
Test: https://judge.softuni.bg/Contests/761/Progr-Fund-Extended-Retake-Exam-04-Sept-2017-Part-II

## Task 05. Anonymous Downsite (Result: 100/100)
```
double n = double.Parse(Console.ReadLine());
double security = double.Parse(Console.ReadLine());
decimal SiteLossSum = 0;
for (int i = 1; i <= n; i++)
{
   string[] site = Console.ReadLine().Split(' ').ToArray();
   decimal Loss = uint.Parse(site[1]) * decimal.Parse(site[2]);
   SiteLossSum += Loss;
   Console.WriteLine(site[0]);
}
Console.WriteLine($"Total Loss: {SiteLossSum:f20}");
BigInteger SecurityToken=1;
for(int i=1;i<=n;i++) SecurityToken=SecurityToken*(BigInteger) security;
Console.WriteLine($"Security Token: {SecurityToken} ");n);
```
Test: https://judge.softuni.bg/Contests/834/Programming-Fundamentals-Exam-05-November-2017-Part-I

## Task 06. Anonymous Threat  (Result: 100/100)
```
// Сливане
private static void Merge(List<string> strings, int startIndex, int endIndex)
{
    var denyStart = startIndex < 0;
    var denyEnd = endIndex >= strings.Count;
    if (denyStart) startIndex = 0;
    if (denyEnd) endIndex = strings.Count - 1;
    for (int i = startIndex; i < endIndex; endIndex--)
    {
      strings[i] = strings[i] + strings[i + 1];
      strings.RemoveAt(i + 1);
    }
}
// Разделяне
private static void Divide(List<string> strings, int index, int partitions)
{
    string currentString = strings[index];
    var lenghtOfPartitions = currentString.Length / partitions;
    var additions = new List<string>(partitions);
    for (int i = 0; i < partitions - 1; i++)
    {
      string currentAdition = currentString.Substring(0, lenghtOfPartitions);
      additions.Add(currentAdition);
      currentString = currentString.Substring(lenghtOfPartitions);
    }
    additions.Add(currentString);
    strings.RemoveAt(index);
    strings.InsertRange(index, additions);
}
// Главен метод
static void Main(string[] args)
{
    var strings = Console.ReadLine().Split(' ').ToList();
    var input = new string[4];
    while ((input = Console.ReadLine().Split(' ')).First() != "3:1")
    {
      if (input.First() == "merge") Merge(strings, int.Parse(input[1]), int.Parse(input[2]));
      else if (input.First() == "divide") Divide(strings, int.Parse(input[1]), int.Parse(input[2]));
    }
    Console.WriteLine(String.Join(" ", strings));
}
```
Test: https://judge.softuni.bg/Contests/834/Programming-Fundamentals-Exam-05-November-2017-Part-I

## Task 07. Anonymous Vox 
Test: https://judge.softuni.bg/Contests/835/Programming-Fundamentals-Exam-05-November-2017-Part-II

## Task 08. Anonymous Cache (Result: 80/100)
```
var data = new Dictionary<String, Dictionary<String, long>>();
var cache = new Dictionary<String, Dictionary<String, long>>();
string line = Console.ReadLine();
while (line != "thetinggoesskrra")
{
    var parts = line.Replace(" -> ", ";").Replace(" | ", ";").Split(';');
    if (parts.Count() > 1)
    {
        String dataKey = parts[0], dataSet = parts[2];
        long dataSize = long.Parse(parts[1]);
        if (data.ContainsKey(dataSet)) data[dataSet].Add(dataKey, dataSize);
        else if (!cache.ContainsKey(dataSet)) cache.Add(dataSet, new Dictionary<string, long>() { { dataKey, dataSize } });
        else cache[dataSet].Add(dataKey, dataSize);
    }
    else if(parts[0] != "thetinggoesskrra")
    {
        String dataSet = parts[0];
        if (cache.ContainsKey(dataSet))
        {
           data.Add(dataSet, cache[dataSet]);
           cache.Remove(dataSet);
        }
        else data.Add(dataSet, new Dictionary<string, long>());
    }
    line = Console.ReadLine();
}
foreach(var dataSet in data)
if (dataSet.Value.Sum(x => x.Value) == data.Values.Max(x => x.Values.Sum()))
{
   Console.WriteLine("Data Set: {0}, Total Size: {1}", dataSet.Key, dataSet.Value.Sum(x => x.Value));
   foreach (var dataKey in dataSet.Value) Console.WriteLine("$.{0}", dataKey.Key);
}
```
Test: https://judge.softuni.bg/Contests/835/Programming-Fundamentals-Exam-05-November-2017-Part-II

## Task 09. Raindrops (Result: 100/100)
```
int amountOfRegions = int.Parse(Console.ReadLine());
decimal density = decimal.Parse(Console.ReadLine());
uint[] regionInformation = new uint[1];
decimal sumregionalcoefficient = 0;
for (int i = 0; i < amountOfRegions; i++)
{
   regionInformation = Console.ReadLine().Split(' ').Select(uint.Parse).ToArray();
   uint raindropsCount = regionInformation[0];
   uint squareMeters = regionInformation[1];
   decimal regionalCoefficient = (decimal)raindropsCount / squareMeters;
   sumregionalcoefficient = sumregionalcoefficient + regionalCoefficient;
}
if (density > sumregionalcoefficient)  Console.WriteLine("{0:f3}", sumregionalcoefficient);
else if (density == 0) Console.WriteLine("{0:f3}", sumregionalcoefficient);
else
{
   decimal output = sumregionalcoefficient / density;
   Console.WriteLine("{0:f3}", output);
}
```
Test: https://judge.softuni.bg/Contests/869/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-I

## Task 10. Rainer (Result: 100/100)
```
var input = Console.ReadLine().Split().Select(int.Parse).ToList();
input.RemoveAt(input.Count - 1);
IList<int> original = new List<int>();
var steps = 0;
foreach (var re in input) original.Add(re);
int indexnow = input.Last();
for (int i = 0; i < input.Count; i++) input[i]--;
while (true)
{
    int a = int.Parse(Console.ReadLine());
    steps++;
    for (int i = 0; i < input.Count; i++) input[i]--;
    if (input[a] == 0)
    {
        Console.WriteLine(string.Join(" ", input));
        Console.WriteLine(steps);
        break;
    }
    for (int i = 0; i < input.Count; i++) if (input[i] == 0) input[i] = original[i];
}
```
Test: https://judge.softuni.bg/Contests/869/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-I

## Task 11. Raincast (Result: 50/100)
```
String line = Console.ReadLine();
String[] ValidForecast = new String[3];
while (line != "Davai Emo")
{
    var parts = line.Split(':');
    switch (parts[0])
    {
        case "Type":
        {
           var type = parts[1].Trim(' ');
           if (type == "Normal" || type == "Warning" || type == "Danger" && String.IsNullOrEmpty(ValidForecast[0])) ValidForecast[0] = type;
           break;
        }
        case "Source":
        {
           var src = parts[1].Trim(' ');
           if (!String.IsNullOrEmpty(ValidForecast[0])) ValidForecast[1] = src;
           break;
        }
        case "Forecast":
        {
           var frc = parts[1].Trim(' ');
           if (!String.IsNullOrEmpty(ValidForecast[0]) && !String.IsNullOrEmpty(ValidForecast[1]))
           {
             ValidForecast[2] = frc;
             Console.WriteLine("({0}) {1} ~ {2}", ValidForecast[0], ValidForecast[2], ValidForecast[1]);
             ValidForecast = new String[3];
           }
           break;
        }
    }
    line = Console.ReadLine();
}
```
Test: https://judge.softuni.bg/Contests/881/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-II

## Task 12. RainAir (Result: 20/100)
```
var RainAir = new SortedDictionary<String, List<int>>();
var line = Console.ReadLine();
while (line != "I believe I can fly!")
{
    if (line.IndexOf('=') == -1)
    {
        var parts = line.Split(' ');
        String customerName = parts[0].ToString();
        List<int> customerFlights;
        if (RainAir.ContainsKey(customerName)) customerFlights = RainAir[customerName];
        else customerFlights = new List<int>();
        for (int i = 1; i < parts.Count(); i++) customerFlights.Add(int.Parse(parts[i]));
        customerFlights.Sort();
        if (RainAir.ContainsKey(customerName)) RainAir[customerName] = customerFlights;
        else RainAir.Add(customerName, customerFlights);
    }
    else
    {
        var parts = line.Replace(" = ", "=").Split('=');
        if (RainAir.ContainsKey(parts[0])) RainAir[parts[0]] = RainAir[parts[1]];
    }
    line = Console.ReadLine();
}
foreach (var customer in RainAir)
{
    Console.Write("#{0} ::: ", customer.Key);
    Console.WriteLine(String.Join(", ", customer.Value));
}
```
Test: https://judge.softuni.bg/Contests/881/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-II