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
            new Student{Id=1, Name="An", Score=8.5},
            new Student{Id=2, Name="Binh", Score=5.5},
            new Student{Id=3, Name="Chi", Score=9},
            new Student{Id=4, Name="Dung", Score=7}
        };
        var groups = students.GroupBy(s => {
            if (s.Score >= 8) return "Gioi";
            if (s.Score >= 6) return "Kha";
            return "Trung binh";
        });

        Console.WriteLine("Bai 18: Danh sach theo nhom xep loai:");
        foreach (var g in groups)
        {
            Console.WriteLine("Nhom {0}:", g.Key);
            foreach (var s in g) Console.WriteLine(" - {0} ({1} diem)", s.Name, s.Score);
        }
        Console.ReadLine();
    }
}