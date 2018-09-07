# Наследяване
## Допълнителни упражнения
- [451](Inheritance/451) = Дефиниране на интерфейс IPerson
- [452](Inheritance/452) = Множествена имплементация
- [453](Inheritance/453) = Телефония
- [461](Inheritance/461) = Работници
- [471](Inheritance/471) = Животинско царство
- [481](Inheritance/481) = Граничен контрол
- [482](Inheritance/482) = Рожден ден
- [483](Inheritance/483) = Недостиг на храна

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
## Примери:
- [521](Polymorphism/521) = MathOperations
- [522](Polymorphism/522) = Animals
- [531](Polymorphism/531) = Shapes
- [541](Polymorphism/541) = Animals 2
- [551](Polymorphism/551) = Vehicle
- [561](Polymorphism/561) = Превозни средства II
- [571](Polymorphism/571) = Ферма за животни