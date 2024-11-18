using berek2020;

List<Ber> berek = [];
using StreamReader r = new("../../../src/berek2020.txt");
r.ReadLine();
while (!r.EndOfStream)
{
    berek.Add(new Ber(r.ReadLine()!));
}

Console.WriteLine($"3. feladat: {berek.Count} dolgozó van az állományban.");
Console.WriteLine($"4. feladat: {Math.Round(berek.Average(b => b.Fizetes) / 1000, 1)} eFt");

Console.Write("5. feladat: Adja meg a részleg nevét: ");
string reszleg = Console.ReadLine()!;
var reszlegBerek = berek.Where(b => b.Reszleg == reszleg);
if (!reszlegBerek.Any())
{
    Console.WriteLine("6. feladat: A megadott részleg nem létezik a cégnél!");
}
else
{
    Ber legnagyobb = reszlegBerek.MaxBy(b => b.Fizetes)!;
    Console.WriteLine($"6. feladat: A legtöbbet kereső dolgozó a megadott részlegen");
    Console.WriteLine($"\tNév: {legnagyobb.Nev}");
    Console.WriteLine($"\tNem: {(legnagyobb.Nem ? "férfi" : "nő")}");
    Console.WriteLine($"\tBelépés: {legnagyobb.Belepes}");
    Console.WriteLine($"\tBér: {legnagyobb.Fizetes} Ft");
}

Console.WriteLine("7. feladat: Statisztika");
var stat = berek.GroupBy(b => b.Reszleg).OrderBy(g => g.Key);
int spacing = stat.Max(g => g.Key.Length);
foreach (var item in stat)
{
    Console.WriteLine($"\t{item.Key.PadRight(spacing)} - {item.Count()} fő");
}