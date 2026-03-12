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
        // In thong tin ca nhan de cham diem
        Console.WriteLine("Ma SV: 2415053122224");
        Console.WriteLine("Ten SV: Dang Thai Nguyen");
        Console.WriteLine("Lop  : 225LTC#01");
        List<int> numbers = new List<int> { 1, 5, 8, 2, 12, 7, 4 };
        Console.WriteLine("Danh sach goc: " + string.Join(", ", numbers));
        bool hasLargeNumber = numbers.Any(n => n > 10);

        if (hasLargeNumber)
        {
            Console.WriteLine("Ket qua: Co it nhat mot so lon hon 10 trong danh sach.");
        }
        else
        {
            Console.WriteLine("Ket qua: Khong co so nao lon hon 10 trong danh sach.");
        }
        Console.ReadLine();
    }
}