# Полиморфизъм

## Презареждане (overloading) 
Методи с едно и също име, но различни сигнатури.
```
public int Add(int a, int b)
public double Add(double a, double b, double c)
public decimal Add(decimal a, decimal b, decimal c)
```

## Презаписване (overriding) 
Създаване на метод със същото име и сигнатура в подклас.
```
public class Person
{
  public virtual string IntroduceYourself() { ... }
}
public class Student : Person
{
  public override string IntroduceYourself() { ... }
}
```
# Примери:
- [521](521) = MathOperations
- [522](522) = Animals
- [531](531) = Shapes
- [541](541) = Animals 2
- [551](551) = Vehicle
- [561](561) = Превозни средства II
- [571](571) = Ферма за животни