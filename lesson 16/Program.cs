using lesson_16;

Console.WriteLine("*****Basic Inheritance*****");
//Создать обьект Car и установить максимальную и текщую скорость
Car myCar = new Car(80) { Speed = 50 };

//Вывести значение текщей скорости
Console.WriteLine("My car is going {0} MPH", myCar.Speed);

//создать обьект MiniVan
MiniVan myVan = new MiniVan { Speed = 10 };
Console.WriteLine("My van is going {0} MPH", myVan.Speed);
Console.ReadLine();