using System;
using System.Linq;
class Sach
{
    public string? MaSach { get; set; }
    public string? TieuDe { get; set; }
    public string? TacGia { get; set; }
    public int NamXB { get; set; }
    public double GiaBan { get; set; }
}
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var dsSach = new List<Sach>
        {
            new Sach{ MaSach="S01", TieuDe="Lập trình C# cơ bản", TacGia="Nguyễn Văn A", NamXB=2019, GiaBan=150000 },
            new Sach{ MaSach="S02", TieuDe="LINQ nâng cao", TacGia="Trần Thị B", NamXB=2021, GiaBan=220000 },
            new Sach{ MaSach="S03", TieuDe="Cấu trúc dữ liệu", TacGia="Nguyễn Văn A", NamXB=2022, GiaBan=180000 },
            new Sach{ MaSach="S04", TieuDe="Cơ sở dữ liệu", TacGia="Lê Văn C", NamXB=2020, GiaBan=200000 },
            new Sach{ MaSach="S05", TieuDe="Lập trình web ASP.NET", TacGia="Trần Thị B", NamXB=2023, GiaBan=250000 },
            new Sach{ MaSach="S06", TieuDe="Trí tuệ nhân tạo", TacGia="Phạm Thị D", NamXB=2024, GiaBan=300000 }
        };
        var sachMoi = from s in dsSach
                      where s.NamXB > 2020
                      select s;
        var sapXepGia = dsSach.OrderBy(s => s.GiaBan);
        double tongGiaTri = dsSach.Sum(s => s.GiaBan);
        Console.WriteLine("Sách xuất bản sau năm 2020:");
        foreach (var s in sachMoi)
        {
            Console.WriteLine($"{s.MaSach} - {s.TieuDe} - {s.TacGia} - {s.NamXB} - {s.GiaBan}");
        }
        Console.WriteLine("\nSách sắp xếp theo giá bán tăng dần:");
        foreach (var s in sapXepGia)
        {
            Console.WriteLine($"{s.MaSach} - {s.TieuDe} - {s.GiaBan}");
        }
        Console.WriteLine($"\nTổng giá trị toàn bộ sách: {tongGiaTri}");
        
    }
}