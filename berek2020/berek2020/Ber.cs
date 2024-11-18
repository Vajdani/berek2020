namespace berek2020
{
    internal class Ber
    {
        public string Nev { get; set; }
        public bool Nem { get; set; }
        public string Reszleg { get; set; }
        public string Belepes { get; set; }
        public int Fizetes { get; set; }

        public Ber(string line)
        {
            string[] spli = line.Split(';');
            Nev = spli[0];
            Nem = spli[1] == "férfi";
            Reszleg = spli[2];
            Belepes = spli[3];
            Fizetes = int.Parse(spli[4]);
        }
    }
}
