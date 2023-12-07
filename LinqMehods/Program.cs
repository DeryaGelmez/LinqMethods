//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        List<int> numbers2 = new List<int> { 11, 12, 13, 14, 15 };
//        double average = numbers.Average(); //listenin ortalamasını alır.
//        Console.WriteLine("ortalama:" + numbers.Average());
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        List<int> numbers2 = new List<int> { 11, 12, 13, 14, 15 };
//        var concatenatedList = numbers.Concat(numbers2); //iki listeyi birleştirir.
//        Console.WriteLine("Concatenated List:");
//        foreach (var num in concatenatedList)
//{
//        Console.Write(num + " ");
//    }
//        Console.ReadLine();
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 10, 10 };


//        var distinctNumbers = numbers.Distinct(); //tekrarlayan elemanları listeden kaldırır.


//        Console.WriteLine("Distinct Elements:");
//        foreach (var num in distinctNumbers)
//        {
//            Console.Write(num + " ");
//        }

//        Console.ReadLine();
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        var skippedNumbers = numbers.Skip(5);  // listeden belirli sayıda elemanı atlatır.

//        Console.WriteLine("Skipped Elements:");
//        foreach (var num in skippedNumbers)
//        {
//            Console.Write(num + " ");
//        }

//        Console.ReadLine();
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        var takenNumbers = numbers.Take(5); //listeden belirli sayıda elemanı alır.

//        Console.WriteLine("Taken Elements:");
//        foreach (var num in takenNumbers)
//        {
//            Console.Write(num + " ");
//        }

//        Console.ReadLine();
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        bool allGreaterThanZero = numbers.All(num => num > 0);  //listenin elemanlarının bir koşulu sağlayıp sağlamadığını kontrol eder.

//        Console.WriteLine("Are all elements greater than 0? " + allGreaterThanZero);

//        Console.ReadLine();
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        bool anyGreaterThanFive = numbers.Any(num => num > 5);  //listedeki elemanlardan en az birinin belirli bir koşulu sağlayıp sağlamadığını kontrol eder.

//        Console.WriteLine("Is there any element greater than 5? " + anyGreaterThanFive);

//        Console.ReadLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        int firstGreaterThanFive = numbers.First(num => num > 5);  //listeden belirli bir koşulu sağlayan ilk ögeyi getirir. Eğer belirtilen koşulu sağlayan öğe bulunamazsa bir hata fırlatır.

//        Console.WriteLine("First element greater than 5: " + firstGreaterThanFive);

//        Console.ReadLine();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        int firstOrDefaultGreaterThanTen = numbers.FirstOrDefault(num => num > 10); //listeden belirli bir koşulu sağlayan ilk ögeyi getirir. Belirtilen koşulu sağlayan öğe bulunamazsa varsayılan bir değeri (null veya belirtilen varsayılan değer) döndürür ve hata fırlatmaz.

//        Console.WriteLine("First element greater than 10 (or default to 0): " + firstOrDefaultGreaterThanTen);

//        Console.ReadLine();
//    }
//}







