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
        List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
        var result = numbers.GroupBy(n => n)
                            .OrderByDescending(g => g.Count())
                            .First().Key;
        Console.WriteLine("Bai 19: So xuat hien nhieu nhat la: " + result);
        Console.ReadLine();
    }
}