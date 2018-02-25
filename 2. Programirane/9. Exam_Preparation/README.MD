# Пподготовка за изпит
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

## Task 05. Anonymous Downsite (Result: 90/100)
```
int n = int.Parse(Console.ReadLine());
int key = int.Parse(Console.ReadLine());
decimal totalLoss = 0;
double securityToken = Math.Pow(key, n);
for (int i=0;i<n;i++)
{
    var parts = Console.ReadLine().Split(' ');
    String siteName = parts[0];
    decimal siteVisits = decimal.Parse(parts[1]);
    decimal siteCommercialPricePerVisit = decimal.Parse(parts[2]);
    decimal loss = siteVisits * siteCommercialPricePerVisit;
    totalLoss += loss;
    Console.WriteLine("{0}", siteName);
}
Console.WriteLine("Total Loss: {0:f20}", totalLoss);
Console.WriteLine("Security Token: {0}", securityToken);
```
Test: https://judge.softuni.bg/Contests/834/Programming-Fundamentals-Exam-05-November-2017-Part-I

## Task 06. Anonymous Threat  (Result: 20/100)
```
String[] command, dummy = Console.ReadLine().Split(' ');
while(true)
{
  command = Console.ReadLine().Split(' ');
  switch (command[0])
  {
    case "merge": // сливане
    {
      int startIndex = int.Parse(command[1]) < 0 ? 0 : int.Parse(command[1]);
      int endIndex = int.Parse(command[2]) > dummy.Length - 1 ? dummy.Length - 1 : int.Parse(command[2]);
      String[] left = dummy.Take(startIndex).ToArray();
      String[] middle = new String[1] { String.Join("", dummy.Skip(startIndex).Take(endIndex - startIndex).ToArray()) };
      String[] right = dummy.Skip(endIndex).Take(dummy.Length - endIndex).ToArray();
      dummy = left.Union(middle).Union(right).ToArray();
      break;
    }
    case "divide": // разделяне
    {
      int index = int.Parse(command[1]);
      float partitions = float.Parse(command[2]);
      int parts = (int)Math.Ceiling(dummy[index].Length / partitions);
      String[] left = dummy.Take(index).ToArray();
      String[] middle = Enumerable.Range(0, dummy[index].Length / parts).Select(i => dummy[index].Substring(i * parts, parts)).ToArray();
      String[] right = dummy.Skip(index+1).Take(dummy.Length - index).ToArray();
      dummy = left.Union(middle).Union(right).ToArray();
      break;
    }
    case "3:1": // край
    {
      Console.WriteLine(String.Join(" ", dummy));
      return;    
    }
  }
}
```
Test: https://judge.softuni.bg/Contests/834/Programming-Fundamentals-Exam-05-November-2017-Part-I

## Task 07. Anonymous Vox 
Test: https://judge.softuni.bg/Contests/835/Programming-Fundamentals-Exam-05-November-2017-Part-II

## Task 08. Anonymous Cache 
Test: https://judge.softuni.bg/Contests/835/Programming-Fundamentals-Exam-05-November-2017-Part-II

## Task 09. Raindrops  
Test: https://judge.softuni.bg/Contests/869/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-I

## Task 10. Rainer 
Test: https://judge.softuni.bg/Contests/869/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-I

## Task 11. Raincast
Test: https://judge.softuni.bg/Contests/881/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-II

## Task 12. RainAir 
Test: https://judge.softuni.bg/Contests/881/Programming-Fundamentals-Extended-Exam-10-December-2017-Part-II