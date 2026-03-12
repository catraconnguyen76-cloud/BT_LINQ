using System;
using System.Collections.Generic;
using System.Linq;

/* * THONG TIN SINH VIEN:
 * Ma SV: 2415053122224
 * Ho va ten: Dang Thai Nguyen
 * Lop: 225LTC#01
 */

public class BaiTapLINQ
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ma SV: 2415053122224");
        Console.WriteLine("Ten SV: Dang Thai Nguyen");
        Console.WriteLine("Lop  : 225LTC#01");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        Console.WriteLine("Danh sach goc: " + string.Join(", ", numbers));
        var filteredNumbers = numbers.Where(n => n > 5);
        Console.WriteLine("Cac so lon hon 5 trong danh sach la:");
        foreach (var num in filteredNumbers)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }
}