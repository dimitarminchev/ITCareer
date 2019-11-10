# FightingArena

## Преглед на задачата
Напишете програма, симулираща система за записване на герои в състезание. Системата ще поддържа създаване на герои, въоръжаване, и битки. Ще следим опита и нивото, на което ще бъдат героите след завършване на състезанието.

За ваше улеснение по-долу в раздел "Приложение: Интерфейсни класове" ще намерите необходимите за разработваното приложение интерфейсни класове.  

# Problem 1. Структура

## Weapon
Всяко оръжие има име, сила, ловкост и интелигентност:

- **Constructor**: name, strength, agility, intelligence.
- **Name** = символен низ
- **Strength** = цяло число
- **Agility** = цяло число
- **Intelligence** = цяло число

Имената на оръжията не трябва да бъдат null, празен стринг или whitespace.
Съобщение: **Weapon name cannot be null, empty or whitespace**.

Силата не може да е отрицателна.
Съобщение: **Strength cannot be less than 0!**

Ловкостта не може да е отрицателна.
Съобщение: **Agility cannot be less than 0!**

Интелигентността не може да е отрицателна.
Съобщение: **Intelligence cannot be less than 0!**

При подаване на невалидна стойност хвърлете изключение **ArgumentException** с конкретното съобщение.
 
### Sword
- Strength се увеличава с 300%

### Bow
- Strength се увеличава с 100%
- Agility се увеличава с 200%

### MagicWand
- Intelligence се увеличава с 400%

## Hero
Всеки герой има име, ниво, опит, оръжие и сила.

- **Constructor**: name.
- **Name** = символине низ
- **Level** = цяло число
- **Experience** = цяло число
- **Weapon** = параметър от тип Weapon
- **Power** = реално число

Имената на героите не трябва да бъдат null, празен стринг или whitespace. Съобщение: **Hero name cannot be null, empty or whitespace**.

При подаване на невалидна стойност хвърлете изключение – **ArgumentException** с конкретното съобщение.

Power се изчислява по следната формула, ако има оръжие, в противен случай връща 0:
Formula:({weapon's strength} + {weapon's agility} + {weapon's intelligence}) / 3

Когато опита стане равен на 100, героят вдига своето ниво с 1.

Пример: опита на героя става 110, следователно вдига ниво с 1 и опита остава равен на 10.

### Assassin
Power се увеличава с 500%

### Warrior
Power се увеличава с 300%

### Priest
Power се увеличава с 700%

# Problem 2. Бизнес логика

## The Controller Class
Бизнес логиката на програмата трябва да бъде концентрирана около няколко команди. Внедрете клас, наречен **ArenaController**, който ще притежава главната функционалност, представена от тези публични методи:

## ArenaController.cs
```
public string CreateHero(List<string> args)
{
    //TODO: Add some logic here …
}

public string CreateWeapon(List<string> args)
{
    //TODO: Add some logic here …
}

public string Fight(List<string> args)
{
    //TODO: Add some logic here …
}
 
public string HeroInfo(List<string> args)
{

    //TODO: Add some logic here …
}
 
public string CloseArena()
{
    //TODO: Add some logic here …
}
```

ЗАБЕЛЕЖКА: Не трябва да променяте нищо по методите. Трябва да имплементирате логиката на самите методи. Не прихвайщайте никакви изключения!

## Команди
Има няколко команди, които контролират бизнес логиката на приложението и трябва да ги имплементирате. Те са посочени по-долу.

### CreateHero Команда
Създава герой и го регистрира в системата. В случай, че герой с това име вече съществува, просто го пропуснете.

Параметри:
- **heroType** = символен низ
- **heroName** = символен низ

### CreateWeapon** = Команда
Създава оръжие на даден герой.  В случай, че герой с това име вече съществува, просто го пропуснете. Не всички данни ще бъдат валидни!!!

Параметри:
- **heroName** = символен низ
- **weaponType** = символен низ
- **weaponName** = символен низ
- **strength** = цяло число
- **agility** = цяло число
- **intelligence** = цяло число

### Fight Команда
При тази команда два героя ще премерят силите си на арената. При излъчване на победител, победителят получава 30 опит. При отсъждане на равен резултат, героите получават по 15 опит. В случай, че един от двата героя не съществуват в състезанието, просто го пропуснете.

### HeroInfo Команда
Тази команда изкарва информация за един потребител.

Параметри:
- **heroName** = символен низ

Ако потребител с това име не съществува, нищо не се случва.

### CloseArena Команда
Тази команда прекратява изпълнението на програмата и връща всички герои, подредени по тяхното ниво в намаляващ ред, след това по тяхната сила в намаляващ ред и след това по име в нарастващ ред.

# Problem 3. Вход / Изход

## Вход
Четете редове с различни команди, докато не получите команда за приключване на програмата. По-долу можете да видите формата, в който всяка команда ще бъде дадена във входа:
```
CreateHero:{heroType}:{heroName}
CreateWeapon:{heroName}:{weaponType}:{weaponName}:{strength}:{agility} {intelligence}
Fight:{firstHeroName}:{secondHeroName}
HeroInfo:{heroName}
CloseArena
```

## Изход
По – долу може да видите кой изход трябва да бъде предоставен от командите.

### CreateHero Команда
При успешно регистриране на герой:
**{heroType}: {heroName} joined the Arena!**

В случай на невалидни данни:
- Съществуващо име на герой: **Hero with name: {heroName} already exists!**
- Невалиден тип герой: **Invalid type hero: {heroType}!**

### CreateWeapon Команда
При успешно създаване на оръжие:
**Successfully armed hero {heroName} with weapon {weaponType}!**

В случай на невалидни данни:
- Невалидно име на герой: **Hero with name: {heroName} does not exist!**
- Невалиден тип оръжие: **Invalid type weapon: {weaponType}.**

### Fight Команда
След завършване на командата, трябва да върнете резултата от битката:
- При отсъждане на победител: **Winner in the battle between {firstHeroName} and {secondHeroName} is {winnerName} with {difference in power}.**
- При отсъждане на равен резултат: **No winner in battle between {firstHeroName} and {secondHeroName}!**

В случай на невалидни данни:
- Не регистрирано име на герой: **Hero with name: {heroName} does not exist!**

ЗАБЕЛЕЖКА: Форматирайте разликата в силите на героите до втория знак след десетичната запетая!

### UserInfo Команда
След завършването на командата, трябва да върнете информация за потребителя, ако той съществува, в следния формат:
```
{heroType}: {heroName} - Level: {heroLevel}
Experience: {heroExperience}
```

В случай, че героя има оръжие:
```
{weaponType}: {weaponName}")
  *Strength: {weaponStrength}
  *Agility: {weaponAgility}
  *Intelligence: {weaponIntelligence}
```

Накрая добавете и силата на героя.
```
Power: {heroPower}
```
ЗАБЕЛЕЖКА: Форматирайте силата на героя до втория знак след десетичната запетая!

### Shutdown Команда
След завършване на командата трябва да върнете информация за всички герои във формата, описан в HeroInfo командата, започвайки с:
```
Heroes: {heroesCount}
```

Ограничения:
- Името на героя ще бъде символен низ, който може да съдържа всеки ASCII символ, с изключение на две точки.
- Имената на героите винаги ще бъдат уникални.
- Винаги ще получавате команда за приключване на програмата.
- Входните данни ще бъдат валидни от страна на типове данни.

# Примери

| Input                                                | Output                                                                                      |
|------------------------------------------------------|---------------------------------------------------------------------------------------------|
| CreateHero:Assassin:Master Assassin                  | Assassin: Master Assassin joined the Arena!                                                 |
| HeroInfo:Master Assassin                             | Assassin: Master Assassin - Level: 0                                                        |
| CreateWeapon:Master Assassin:Sword:Excalibur:15:10:5 | Experience: 0                                                                               |
| CreateHero:Priest:The Priest                         | Power: 0                                                                                    |
| Fight:Master Assassin:The Priest                     | Successfully armed hero Master Assassin with weapon Sword!                                  |
| HeroInfo:Master Assassin                             | Priest: The Priest joined the Arena!                                                        |
| CloseArena                                           | Winner in the battle between Master Assassin and The Priest is Master Assassin with 150.00. |
|                                                      | Assassin: Master Assassin - Level: 0                                                        |
|                                                      | Experience: 30                                                                              |
|                                                      | Sword: Excalibur                                                                            |
|                                                      | *Strength: 60                                                                               |
|                                                      | *Agility: 10                                                                                |
|                                                      | *Intelligence: 5                                                                            |
|                                                      | Power: 150                                                                                  |
|                                                      | Heroes: 2                                                                                   |
|                                                      | Assassin: Master Assassin - Level: 0                                                        |
|                                                      | Experience: 30                                                                              |
|                                                      | Sword: Excalibur                                                                            |
|                                                      | *Strength: 60                                                                               |
|                                                      | *Agility: 10                                                                                |
|                                                      | *Intelligence: 5                                                                            |
|                                                      | Power: 150                                                                                  |
|                                                      | Priest: The Priest - Level: 0                                                               |
|                                                      | Experience: 0                                                                               |
|                                                      | Power: 0                                                                                    |

| Input                                                | Output                                                                                      |
|------------------------------------------------------|---------------------------------------------------------------------------------------------|
| CreateHero:Assassin:Master Assassin                  | Assassin: Master Assassin joined the Arena!                                                 |
| HeroInfo:The Priest                                  | Hero with name: The Priest does not exist!                                                  |
| CreateWeapon:Master Assassin:Sword:Excalibur:15:10:5 | Successfully armed hero Master Assassin with weapon Sword!                                  |
| CreateWeapon:The Priest:MagicWand:Star Touch:5:15:25 | Hero with name: The Priest does not exist!                                                  |
| CreateHero:Assassin:Master Assassin                  | Hero with name: Master Assassin already exists!                                             |
| Fight:Master Assassin:Atila                          | Hero with name: Atila does not exist!                                                       |
| CreateHero:Priest:The Priest                         | Priest: The Priest joined the Arena!                                                        |
| CreateWeapon:The Priest:MagicWand:Star Touch:5:15:25 | Successfully armed hero The Priest with weapon MagicWand!                                   |
| Fight:The Priest:Atila                               | Hero with name: Atila does not exist!                                                       |
| Fight:Master Assassin:The Priest                     | Winner in the battle between Master Assassin and The Priest is The Priest with 236.67.      |
| HeroInfo:The Priest                                  | Priest: The Priest - Level: 0                                                               |
| CloseArena                                           | Experience: 30                                                                              |
|                                                      | MagicWand: Star Touch                                                                       |
|                                                      | *Strength: 5                                                                                |
|                                                      | *Agility: 15                                                                                |
|                                                      | *Intelligence: 125                                                                          |
|                                                      | Power: 386.67                                                                               |
|                                                      | Heroes: 2                                                                                   |
|                                                      | Priest: The Priest - Level: 0                                                               |
|                                                      | Experience: 30                                                                              |
|                                                      | MagicWand: Star Touch                                                                       |
|                                                      | *Strength: 5                                                                                |
|                                                      | *Agility: 15                                                                                |
|                                                      | *Intelligence: 125                                                                          |
|                                                      | Power: 386.67                                                                               |
|                                                      | Assassin: Master Assassin - Level: 0                                                        |
|                                                      | Experience: 0                                                                               |
|                                                      | Sword: Excalibur                                                                            |
|                                                      | *Strength: 60                                                                               |
|                                                      | *Agility: 10                                                                                |
|                                                      | *Intelligence: 5                                                                            |
|                                                      | Power: 150.00                                                                               |

# Problem 4.       Точкуване
Всяка различна задача Ви дава точки:
- Структура = 30 точки
- Бизнес логика = 50 точки
- Вход/Изход = 20 точки 

# Приложение: Интерфейсни класове

**IArenaController.cs**
```
namespace HeroFight.Core.Contracts
{
    using System.Collections.Generic;

    public interface IArenaController
    {
        string CreateHero(List<string> args);

        string CreateWeapon(List<string> args);

        string Fight(List<string> args);

        string HeroInfo(List<string> args);

        string CloseArena();
    }
}
```

**IHero.cs**
```
namespace HeroFight.Entities.Heroes.Contracts
{
    using HeroFight.Entities.Weapons;

    public interface IHero
    {
        string Name { get; }

        int Level { get; }

        int Experience { get; }

        Weapon Weapon { get; }

        double Power { get; }
    }
}
```

**IWeapon.cs**
```
namespace HeroFight.Entities.Weapons.Contracts
{
    public interface IWeapon
    {
        string Name { get; }

        int Strength { get; }

        int Agility { get; }

        int Intelligence { get; }
    }
}
```

**IEngine.cs**
```
namespace HeroFight.Core.Contracts
{
    public interface IEngine
    {
        void Run();
    }
}
```