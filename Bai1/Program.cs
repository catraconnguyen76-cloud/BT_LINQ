using System;
using System.Collections.Generic;
using System.Linq; 

/* * THÔNG TIN SINH VIÊN:
 * Mã SV: 2415053122224
 * Họ và tên: Đặng Thái Nguyên
 * Lớp: 225LTC#01
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
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Cac so chan trong danh sach la:");
        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.ReadLine(); 
    }
}