# Шаблони 

## Класове 
Позволяват повторна употреба 
```
class List<T> 
{
    public Add (T element) { ... }
    public T Remove () { ... }
    public T { get; }
}
```
Примери 3.1: 
- Problem 1. Кутия с T
- Problem 2. Кутия за всичко
- Problem 3. Универсална кутия за низове
- Problem 4. Универсална кутия за цели числа

## Интерфейси и методи
```
interface IBox<T> 
{
    void Add (T element);
    ...
}
class MyList<T> : IBox<T> { ... }
```
Примери 3.2:
- Problem 1. Създател на шаблонен масив
- Problem 2. Шаблонен метод за размяна на низове
- Problem 3. Шаблонен метод за размяна на цели числа
- Problem 4. Шаблонен метод за броене на низове
- Problem 5. Шаблонен метод за броене на дробни числа

## Ограничители 
Ограничаване до референтен тип
```
public void MyMethod<T>() where T : class
```
Ограничаване до примитивен тип
```
public void MyMethod<T>() where T : struct
```
Ограничаване до конструктор
```
public void MyMethod<T>() where T : new ()
```
Ограничаване до статичен базов клас
```
public void MyMethod<T>() where T : BaseClass
```
Ограничаване до шаблонен базов клас
```
public void MyMethod<T,U>() where T : U
```
Примери 3.3: 
Problem 1. Универсална везна
Problem 2. Подобрен списък
Problem 3. Сортиране на подобрения списък
Problem 4. *Обхождане на подобрения списък
Problem 11. Tuple
Problem 12. Threeuple
