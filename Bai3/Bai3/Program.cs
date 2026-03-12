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
        List<int> numbers = new List<int> { 5, 1, 8, 3, 2, 7, 4, 6 };
        Console.WriteLine("Danh sach goc: " + string.Join(", ", numbers));
        var sortedNumbers = numbers.OrderBy(n => n);
        Console.WriteLine("Danh sach sau khi sap xep tang dan:");
        foreach (var num in sortedNumbers)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }
}