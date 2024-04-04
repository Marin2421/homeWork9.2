long number1 = 264895468854;
long number2 = 256;
long invertedNumber1 = ~number1;
long invertedNumber2 = ~number2;
Console.WriteLine($"Инверсия числа {number1}: {invertedNumber1 + 1}");
Console.WriteLine($"Инверсия числа {number2}: {invertedNumber2 + 1}");

// Операция сдвига вправо и влево
int number3 = 256;
int number4 = 32856;
Console.WriteLine($"Сдвиг числа {number3} вправо: {number3 >> 1}");
Console.WriteLine($"Сдвиг числа {number3} влево: {number3 << 1}");
Console.WriteLine($"Сдвиг числа {number4} вправо: {number4 >> 1}");
Console.WriteLine($"Сдвиг числа {number4} влево: {number4 << 1}");

// Операция присваивания с изменением на 2487
int number5 = 289;
int number6 = 144;
int number7 = 36274;
number5 = 2487;
number6 = 2487;
number7 = 2487;
Console.WriteLine($"Число 1: {number5}");
Console.WriteLine($"Число 2: {number6}");
Console.WriteLine($"Число 3: {number7}");