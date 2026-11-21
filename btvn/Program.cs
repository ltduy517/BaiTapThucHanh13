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
            new Sach{ MaSach="S01", TieuDe="CSDL", TacGia="Nguyen Chi Sy", NamXB=2019, GiaBan=150000 },
            new Sach{ MaSach="S02", TieuDe="LTHDT", TacGia="Nguyen Chi Sy", NamXB=2021, GiaBan=220000 },
            new Sach{ MaSach="S03", TieuDe="Doraemon", TacGia="Fujiko Fujio", NamXB=2022, GiaBan=180000 },
        };
        var sachMoi = from s in dsSach
                      where s.NamXB > 2020
                      select s;
        var sapXepGia = dsSach.OrderBy(s => s.GiaBan);
        double tongGiaTri = dsSach.Sum(s => s.GiaBan);
        Console.WriteLine("Sach xuat ban sau nam 2000:");
        foreach (var s in sachMoi)
        {
            Console.WriteLine($"{s.MaSach} - {s.TieuDe} - {s.TacGia} - {s.NamXB} - {s.GiaBan}");
        }
        Console.WriteLine("\nXap sep theo gia tang dan:");
        foreach (var s in sapXepGia)
        {
            Console.WriteLine($"{s.MaSach} - {s.TieuDe} - {s.GiaBan}");
        }
        Console.WriteLine($"\nTong gia toan bo sach: {tongGiaTri}");
        
    }
}