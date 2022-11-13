# 3. Рекурсия
В Haskell няма цикли.
Циклите се реализират чрез рекурсия.
Итерациите се реализират с рекурсивни извиквания.
Итераторите се реализират като параметри и се променят при всяко рекурсивно извикване.

## Рекурсивна реализация на цикли
```
repeatString str n = 
    if n == 0
    then ""
    else str ++ (repeatString str (n-1))
```
За функциите, които зависят от външно състояние се използва помощна функция:
```
pow2loop n x i = 
    if i < n
    then pow2loop n (x*2) (i+1)
    else x
pow2 n = pow2loop n 1 0
```

### Задача
Дефинирайте функция, която намира сбора на първите 10 естествени числа.
```
sumNumbers = sumNumbersLoop 0 1

sumNumbersLoop sum index = 
    if index > 10
    then sum
    else (sum + index) + (sumNumbersLoop sum (index + 1))
```

## Опашкова рекурсия
Опашковата рекурсия е рекурсия, при която последното извършвано действие е рекурсивно извикване.
- Оптимизация на опашката = [Tail Call Optimization](https://www.youtube.com/watch?v=-PX0BV9hGZY)
- Вместо с последващо връщане рекурсивното обръщение се реализира със преход без връщане
- При тази рекурсия заделената в стека памет се преизползва вместо да се заделя нова
- Намалява разхода на памет и обикновено подобрява бързината на алгоритъма, но по-трудно се откриват грешки
```
repeatStringLoop string result n = 
    if n == 0
    then result
    else repeatStringLoop string (result ++ string) (n - 1)

repeatString string n = repeatStringLoop string string n
```
