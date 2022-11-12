# 2. Функции и стойности

Деклариране на функция
```
square x = x * x
```

Функция с повече параметри
```
multMax a b x = (max a b) * x
```

Използване на скоби
```
(5 + 2) * (3 - 4) -- Rezult = -7 
max (5 + 2) (sqrt 17) -- Result = 7
max 5 (-5) -- Result = 5
```

Функции като стойности на функция 
```
pass3 f = f 3
add1 x = x + 1 
pass3 add1
-- Result = 4
```

Композиция
```
compose f g x = f (g x)
add1 x = x + 1
mult2 x = 2 * x

compose add1 mult2 4
```

Рекурсия
```
pow2 n =
	if n == 0
	then 1
	else 2 * (pow2 (n - 1))
```

## Демонстрации
1. [square.hs](square.hs)
2. [multMax.hs](multMax.hs)
3. [brackets.hs](brackets.hs)
4. [plusFive.hs](plusFive.hs)
5. [pow2.hs](pow2.hs)
6. [repeatString.hs](repeatString.hs)