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
        // Khoi tao danh sach so nguyen
        List<int> numbers = new List<int> { 1, 5, 8, 2, 3, 7, 4, 6 };
        Console.WriteLine("Danh sach goc: " + string.Join(", ", numbers));
        var sortedDesc = numbers.OrderByDescending(n => n);

        Console.WriteLine("Danh sach sau khi sap xep giam dan:");
        foreach (var num in sortedDesc)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine();
    }
}