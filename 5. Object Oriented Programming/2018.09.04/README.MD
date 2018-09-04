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
**Примери 3.1**: 
- [Problem 1. Кутия с T](31_1)
- [Problem 2. Кутия за всичко](31_2)
- [Problem 3. Универсална кутия за низове](31_3)
- [Problem 4. Универсална кутия за цели числа](31_4)

## Интерфейси и методи
```
interface IBox<T> 
{
    void Add (T element);
    ...
}
class MyList<T> : IBox<T> { ... }
```
**Примери 3.2**:
- [Problem 1. Създател на шаблонен масив](32_1)
- [Problem 2. Шаблонен метод за размяна на низове](32_2)
- [Problem 3. Шаблонен метод за размяна на цели числа](32_3)
- [Problem 4. Шаблонен метод за броене на низове](32_4)
- [Problem 5. Шаблонен метод за броене на дробни числа](32_5)

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
**Примери 3.3**: 
- [Problem 1. Универсална везна](33_1)
- [Problem 2. Подобрен списък](33_2)
- [Problem 3. Сортиране на подобрения списък](33_3)
- [Problem 4. *Обхождане на подобрения списък](33_4)
- [Problem 11. Tuple](33_11)
- [Problem 12. Threeuple](33_12)
