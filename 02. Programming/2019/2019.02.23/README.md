# Символни низове

## String and Char Array
```
string str = new String(new char[] {'s', 't', 'r'});
char[] array = str.ToCharArray(); // ['s', 't', 'r']
```

## Compare
```
int result = string.Compare(str1, str2);
// result == 0 if str1 equals str2
// result < 0 if str1 is before str2
// result > 0 if str1 is after str2
```

## Concat
```
string str = string.Concat(str1, str2); 
```

## IndexOf
```
string email = "vasko@gmail.org";
int index = email.IndexOf("@"); // 5
```

## LastIndexOf
```
string verse = "To be or not to be...";
int index = verse.LastIndexOf("be"); // 16
```

## Substring
```
string filename = @"C:\Pics\Rila2017.jpg";
string name = filename.Substring(8, 8); // "Rila2017"
```

## Split
```
string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
string[] beers = listOfBeers.Split(' ', ',', '.');
```

## Replace
```
string cocktail = "Vodka + Martini + Cherry";
string replaced = cocktail.Replace("+", "and"); // Vodka and Martini and Cherry
```

## Remove
```
string price = "$ 1234567";
string lowPrice = price.Remove(2, 3); // $ 4567
```

## ToLower and ToUpper
```
string alpha = "aBcDeFg";
string lowerAlpha = alpha.ToLower(); // abcdefg
string upperAlpha = alpha.ToUpper(); // ABCDEFG
```

## Trim, TrimStart and TrimEnd
```
string s = "    example of white space    ";
string clean = s.Trim(); // "example of white space"
string left = s.TrimStart(); // "example of white space    "  
string right = s.TrimEnd(); // "    example of white space" 
```

## StringBuilder
```
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