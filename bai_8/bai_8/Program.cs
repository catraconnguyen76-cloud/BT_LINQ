using System;
using System.Collections.Generic;
using System.Linq;

/* * THONG TIN SINH VIEN:
 * Ma SV: 2415053122224
 * Ho va ten: Dang Thai Nguyen
 * Lop: 225LTC#01
 */
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Score { get; set; }
}

public class BaiTapLINQ
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ma SV: 2415053122224");
        Console.WriteLine("Ten SV: Dang Thai Nguyen");
        Console.WriteLine("Lop  : 225LTC#01");
        List<Student> students = new List<Student>() {
            new Student{Id=1, Name="An", Score=8},
            new Student{Id=2, Name="Binh", Score=6},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };
        var result = students.Where(s => s.Score >= 8);
        Console.WriteLine("Bai 8: Danh sach sinh vien gioi (Diem >= 8):");
        foreach (var s in result)
        {
            Console.WriteLine("SV: {0} - Diem: {1}", s.Name, s.Score);
        }
        Console.ReadLine();
    }
}