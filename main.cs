using System;
using System.IO;
using System.Linq;

class Program {
  public static void Main (string[] args) {
    string path = @"Horizontal.txt";
    // Open the file to read from.
    using (StreamReader sr = File.OpenText(path))
    {
      string s;
      // Загрузить последовательность целых чисел из строки в файле Horizontal.txt.
      while ((s = sr.ReadLine()) != null)
      {
        int[] numbers = s.Split(',').Select(Int32.Parse).ToArray();

        // Используя запрос на основе методов, вывести третье чётное отрицательное число.
        var query = numbers.Where(c => c < 0 && c % 2 == 0).ElementAt(2);
        Console.WriteLine(query);
      }
    }
  }
}