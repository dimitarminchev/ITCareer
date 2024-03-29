# Упражнения: Затваряне на състояние във функция

## Зад. 1 Умножение на числа
Дефинирайте функция, която да приема 2 числа и да връща резултат умножението им. Използвайте функция с вътрешно състояние, като единият аргумент трябва да идва извън рамките на анонимна функция

### Пример
| Вход | Изход |
|------|-------|
| 5 10 | 50    |

## Зад. 2 Най-голямо от три числа
Дефинирайте функция, която приема като параметри 3 числа и връща най-голямото от тях. Използвайте функция с вътрешно състояние. Нека 2 от аргументите функцията да приема отвън.

### Пример
| Вход       | Изход |
|------------|-------|
| 5 10 20    | 20    |
| 5 10 (-20) | 10    |

## Зад. 3 Подаване на функция като аргумент на функция
Дефинирайте функция с вътрешно състояние, която да приема друга функция и параметър и да подава параметъра на функцията. Нека параметъра да е свободната променлива.

### Пример
| Вход      | Изход |
|-----------|-------|
| 5 add1    | 6     |
| 5 remove1 | 4     |

## Зад. 4 Генериране на математически израз
Дефинирайте функция, която приема списък от числа и генерира математически израз в следния формат: 
```
(((a + b) + c) + d)
```
където a,b,c,d са елементите на подадения списък ([a,b,c,d]). Използвайте функция с вътрешно състояние за помощната функция, която форматира числата в символен низ.

### Пример
| Вход        | Изход               |
|-------------|---------------------|
| [1,2,3,4,5] | "((((1+2)+3)+4)+5)" |
| [1]         | "1"                 |
| [1,10]      | "(1+10)"            |
| []          | ""                  |