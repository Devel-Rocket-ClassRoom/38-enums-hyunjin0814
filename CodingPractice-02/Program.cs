using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Animal animal = Animal.Dragon;
int num = (int)animal;

Console.WriteLine($"Animal.Dragon: {num}, {animal}");

Array values = Enum.GetValues(typeof(Priority));

Console.WriteLine("Priority 열거형의 값들:");
foreach (Priority p in values)
{
    Console.WriteLine($"{p} = {(int)p}");
}

enum Animal
{
    Rabbit,
    Dragon,
    Snake
}

enum Priority
{
    High = 1,
    Normal = 5,
    Low = 10
}