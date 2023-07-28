//Напишите программу, в которой содержатся данные о студентах: ФИО и дата рождения (данные заполняются вами). Выведите всех студентов с их датами рождения, у которых фамилии начинаются на букву «В».


/*using System;
using System.Collections.Generic;

class Student
{
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { FullName = "Васильев Иван Петрович", DateOfBirth = new DateTime(2000, 3, 15) },
            new Student { FullName = "Петров Владимир Александрович", DateOfBirth = new DateTime(1999, 7, 21) },
            new Student { FullName = "Иванов Виктор Сергеевич", DateOfBirth = new DateTime(2001, 5, 8) },
            new Student { FullName = "Сидорова Вероника Андреевна", DateOfBirth = new DateTime(2002, 11, 3) }
        };

        List<Student> studentsWithVLastName = students.FindAll(s => s.FullName.StartsWith("В", StringComparison.OrdinalIgnoreCase));
        
        Console.WriteLine("Студенты с фамилиями, начинающимися на 'В':");
        
        foreach (var student in studentsWithVLastName)
        {
            Console.WriteLine($"{student.FullName}, Дата рождения: {student.DateOfBirth:dd.MM.yyyy}");
        }
        Console.ReadKey();
    }
}*/

//Напишите программу, в которой содержатся данные о спортсменах: ФИО и вид спорта (данные заполняются вами). Выведите всех спортсменов, которые занимаются плаванием.

/*using System;
using System.Collections.Generic;

class Athlete
{
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Sport { get; set; }
}
class Program
{
    static void Main()
    {
        List<Athlete> athletes = new List<Athlete>
        {
            new Athlete {FullName = "Васильев Иван Петрович", Sport = "Плавание" , DateOfBirth = new DateTime(2000,4,12)},
            new Athlete {FullName = "Петров Владимир Александрович", Sport = "Футбол", DateOfBirth = new DateTime(2000,5,10)},
            new Athlete {FullName = "Иванов Виктор Сергеевич", Sport = "Фехтование", DateOfBirth = new DateTime(2001,8,19)},
            new Athlete {FullName = "Сидорова Вероника Андреевна", Sport = "Плавание", DateOfBirth = new DateTime(1998, 3, 15)},
            new Athlete {FullName = "Петрова Анна Викторовна", Sport = "Плавание", DateOfBirth = new DateTime(2005, 1, 11)}
        };
        List<Athlete> swimmers = athletes.FindAll(a => a.Sport.Equals("Плавание", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Спорстмены,занимающиеся плаванием: ");
        foreach (var athlete in swimmers)
        {
            Console.WriteLine($"{athlete.FullName}, Вид спорта: {athlete.Sport}, Дата рождения: {athlete.DateOfBirth:dd.MM.yyyy}");
        }
        Console.ReadKey();
    }
}*/

//Напишите программу, в которой содержатся данные о рабочих бригады: ФИО и месячная зарплата (данные заполняются вами). Выведите всех рабочих, у которых зарплата больше 10000.

/*using System;
using System.Collections.Generic;

class Worker
{
    public string FullName { get; set; }
    public decimal MonthlySalary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Worker> workers = new List<Worker>
        {
            new Worker { FullName = "Баринов Виктор Петрович", MonthlySalary = 12000 },
            new Worker { FullName = "Дубов Александр Викторович", MonthlySalary = 15000},
            new Worker { FullName = "Иванов Иван Иванович", MonthlySalary = 8000},
            new Worker { FullName = "Баринов Сергей Викторович", MonthlySalary = 5000}
        };
        List<Worker> highPaidWorkers = workers.FindAll(a => a.MonthlySalary > 10000);
        Console.WriteLine("Рабочие с зарплатой больше 10000");

        foreach (var worker in highPaidWorkers)
        {
            Console.WriteLine($"{worker.FullName}, Зарплата: {worker.MonthlySalary}");
        }
        Console.ReadKey();
    }
}*/

//Напишите программу, в которой содержатся данные о учениках музыкальной школы: ФИО и инструмент (данные заполняются вами). Выведите всех учеников, которые играют на скрипке.

/*using System;
using System.Collections.Generic;

class Musican
{
    public string FullName { get; set; }
    public string Instruments { get; set; }
}

class Program
{
    static void Main()
    {
        List<Musican> musicans = new List<Musican>()
        {
            new Musican { FullName = "Васильев Иван Петрович", Instruments = "Скрипка"},
            new Musican { FullName = "Иванов Иван Иванович", Instruments = "Бас гитара"},
            new Musican { FullName = "Сидорова Анна Николаевна", Instruments = "Флейта"},
            new Musican { FullName = "Смирнов Никита Александрович", Instruments = "Скрипка"}
        };
        List<Musican> violin = musicans.FindAll(a => a.Instruments.Equals("Скрипка", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Ученики игращющие на скрипке: ");
        foreach (var musican in violin)
        {
            Console.WriteLine($"{musican.FullName}, Инструмент: {musican.Instruments}");
        }
        Console.ReadKey();
    }
}*/

//Напишите программу, в которой содержатся данные о ассортименте конфет выпускаемые фабрикой: название и начинка (данные заполняются вами). Выведите весь ассортимент конфет с трюфельной начинкой.

/*using System;
using System.Collections.Generic;

class Candy
{
    public string Name { get; set; }
    public string Filling { get; set; }
}

class Program
{
    static void Main()
    {
        List<Candy> candies = new List<Candy>
        {
            new Candy {Name = "Шоколадное ассорти", Filling = "Орехово-трюфельная"},
            new Candy {Name = "Трюфель в шоколаде", Filling = "Трюфельная"},
            new Candy {Name = "Конфета Фундуковая", Filling = "Фундуково-трюфельная"},
            new Candy {Name = "Карамель Клубничная", Filling = "Клубнично-трюфельная"}
        };
        List<Candy> truffle = candies.FindAll(a => a.Filling.Equals("Трюфельная", StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Конфеты с трюфельной начинкой");
        foreach (var  candy in truffle)
        {
            Console.WriteLine($"{candy.Name}, Начинка: {candy.Filling}");
        }
        Console.ReadKey();
    }
}*/

//Напишите программу, которая собирает данные о N-спортсменах: ФИО, вид спорта, рост. Данные вводятся с консоли. Выведите данные о самом высоком спортсмене.

/*using System;

class Athlete
{
    public string FullName { get; set; }
    public string Sport { get; set; }
    public double Height { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество спортсменов");
        int n = int.Parse(Console.ReadLine());
        Athlete[] athletes = new Athlete[n];
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите данные для спортсмена {i + 1}:");
            athletes[i] = new Athlete()
            {
                FullName = ReadString("ФИО "),
                Sport = ReadString("Спорт "),
                Height = ReadDouble("Рост (в метрах) ")
            };
            Athlete tallestAthlete = GetTallestAthlete(athletes);
            Console.WriteLine("\nДанные о самом высоком спортсмене");
            Console.WriteLine($"ФИО: {tallestAthlete.FullName}");
            Console.WriteLine($"Спорт: {tallestAthlete.Sport}");
            Console.WriteLine($"Рост: {tallestAthlete.Height}");
            Console.ReadKey();
        }
    }
    static string ReadString(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine();
    }
    static double ReadDouble(string prompt)
    {
        Console.Write($"{prompt}: ");
        double value;
        while(!double.TryParse( Console.ReadLine(), out value))
        {
            Console.WriteLine("Ошибка ввода! Введите число! ");
            Console.Write($"{prompt}: ");
        }
        return value;
    }
    static Athlete GetTallestAthlete(Athlete[] athletes)
    {
        Athlete tallest = athletes[0];
        for( int i = 0;i < athletes.Length;i++)
        {
            if (athletes[i].Height > tallest.Height)
            {
                tallest = athletes[i];
            }
        }
        return tallest;
    }
}*/

//Напишите программу, которая собирает данные о N-учениках: ФИО, оценка за год. Данные вводятся с консоли. Выведите данные о всех хорошистах и отличниках.

/*using System;

class Student
{
    public string FullName { get; set; }
    public double Grade{ get; set; }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество студентов: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите данные ученика {i + 1} ");
            students[i] = new Student()
            {
                FullName = ReadString("ФИО"),
                Grade = ReadDouble("Оценка за год")
            };
        }
        Console.WriteLine("\nДанные о хорошистах: ");
        foreach (var student in students)
        {
            Console.WriteLine($"ФИО: {student.FullName}, оценка: {student.Grade}");
        }
        Console.WriteLine("\nДанные об отличниках: ");
        foreach(var student in students)
        {
            Console.WriteLine($"ФИО: {student.FullName}, оценка: {student.Grade}");
        }
        Console.ReadKey();
    }
    static string ReadString(string promnt)
    {
        Console.Write($"{promnt}: ");
        return Console.ReadLine();
    }
    static double ReadDouble(string promnt)
    {
        Console.Write($"{promnt}: ");
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Ошибка ввода! Введите число ");
            Console.Write($"{promnt}: ");
        }
        return value;
    }
}*/

//Напишите программу, которая собирает данные о N-людях, которые участвуют в переписи населения: ФИО, год рождения. Данные вводятся с консоли. Выведите данные о всех родившихся после 2000 года, а также их общее количество.


/*using System;

class Person
{
    public string FullName { get; set; }
    public int YearOfBirth { get; set; }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество людей: ");
        int n = int.Parse(Console.ReadLine());
        Person[] people = new Person[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите данные человека {i + 1}: ");
            people[i] = new Person
            {
                FullName = ReadString("ФИО"),
                YearOfBirth = ReadInt("Год рождения")
            };
        }
        Console.WriteLine("\nДанные о людях родившиеся после 2000 года: ");
        int countBornAfter2000 = 0;
        foreach(var person in people)
        {
            if(person.YearOfBirth > 2000)
            {
                Console.WriteLine($"ФИО: {person.FullName}, Год рождения: {person.YearOfBirth}");
                countBornAfter2000++;
            }
        }
        Console.WriteLine($"Общее количество родившихся после 2000 года: {countBornAfter2000}");
        Console.ReadKey();
    }
    static string ReadString(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine();
    }
    static int ReadInt(string prompt)
    {
        Console.Write($"{prompt}: ");
        int value;
        while (!int.TryParse(Console.ReadLine(),out value))
        {
            Console.WriteLine("Ошибка ввода! Введите целове число! ");
            Console.Write($"{prompt}: ");
        }
        return value;
    }
}*/

//Напишите программу, которая собирает данные о N-товарах: название, цена, количество. Данные вводятся с консоли. Выведите данные о самом дорогом товаре. Выведите общее количество всех товаров.

/*using System;


class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quanity { get; set; }
    public int Quantity { get; internal set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество товаров: ");
        int n = int.Parse(Console.ReadLine());
        Product[] products = new Product[n];
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Введите данные товара {i + 1}: ");
            products[i] = new Product
            {
                Name = ReadString("Название"),
                Price = ReadDecimal("Цена"),
                Quanity = ReadInt("Количество")
            };
        }
        Product mostExpensiveProduct = GetMostExpensiveProduct(products);
        Console.WriteLine("\nДанные о самом дорогом товаре: ");
        Console.WriteLine($"Название: {mostExpensiveProduct.Name}");
        Console.WriteLine($"Цена: {mostExpensiveProduct.Price}");
        Console.WriteLine($"Количество: {mostExpensiveProduct.Quanity}");

        int totalQuanity = GetTotalQuantity(products);
        Console.WriteLine($"\nОбщее количество всех товаров: {totalQuanity}");
        Console.ReadKey();
    }
    static string ReadString(string promnt)
    {
        Console.Write($"{promnt}: ");
        return Console.ReadLine();
    }
    static decimal ReadDecimal(string promnt)
    {
        Console.Write($"{promnt}: ");
        decimal value;
        while(!decimal.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Ошибка ввода! Введите число ");
            Console.Write($"{promnt}: ");
        }
        return value;
    }
    static int ReadInt(string promnt)
    {
        Console.Write($"{promnt}: ");
        int value;
        while(!int.TryParse(Console.ReadLine(),out value))
        {
            Console.WriteLine("Ошибка ввода! Введите целое число ");
            Console.Write($"{promnt}: ");
        }
        return value;
    }
    static Product GetMostExpensiveProduct(Product[] products)
    {
        Product mostExpensive = products[0];
        for (int i = 1; i < products.Length; i++)
        {
            if (products[i].Price > mostExpensive.Price)
            {
                mostExpensive = products[i];
            }
        }
        return mostExpensive;
    }
    static int GetTotalQuantity(Product[] products)
    {
        int totalQuantity = 0;
        foreach (var product in products)
        {
            totalQuantity += product.Quantity;
        }
        return totalQuantity;
    }
}*/

//Напишите программу, которая собирает данные о N-людях, которые проходят медицинский осмотр: ФИО, рост, вес. Данные вводятся с консоли. Выведите данные о среднем росте и среднем весе. Выведите всех людей, у которых вес выше среднего.

using System;
using System.Collections.ObjectModel;

class Person
{
    public string FullName { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите количество людей: ");
        int n = int.Parse(Console.ReadLine());
        Person[] people = new Person[n];
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nВведите данные человека{i + 1}: ");
            people[i] = new Person()
            {
                FullName = ReadString("ФИО"),
                Height = ReadDouble("Рост (в метрах)"),
                Weight = ReadDouble("Вес (в килограммах)")
            };
        }
        double avverageHeight = GetAvverageHeight(people);
        double avverageWeight = GetAvverageWeight(people);
        Console.WriteLine("\nСредний рост: " + avverageHeight.ToString("0.00") + " м");
        Console.WriteLine("\nСредний вес: " + avverageWeight.ToString("0.00") + " кг");
        Console.WriteLine("\nЛюди,у которых вес выше среднего: ");
        foreach (var person in people)
        {
            if (person.Weight > avverageWeight)
            {
                Console.WriteLine($"{person.FullName}, Рост: {person.Height} м, Вес: {person.Weight}кг");
            }
        }
        Console.ReadKey();
    }
    static string ReadString(string promnt)
    {
        Console.Write($"{promnt}: ");
        return Console.ReadLine();
    }
    static double ReadDouble(string promnt)
    {
        Console.Write($"{promnt}: ");
        double value;
        while(!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Ошибка ввода! Введите число");
            Console.Write($"{promnt}");
        }
        return value;
    }
    static double GetAvverageHeight(Person[] people)
    {
        double totalHeight = 0;
        foreach (var person in people)
        {
            totalHeight += person.Height;
        }
        return totalHeight / people.Length;
    }
    static double GetAvverageWeight(Person[] people)
    {
        double totalWeight = 0;
        foreach(var person in people)
        {
            totalWeight += person.Weight;
        }
        return totalWeight / people.Length;
    }
}