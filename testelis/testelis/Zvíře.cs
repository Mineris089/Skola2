using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testelis;

namespace testelis
{
    public class Zvíře
    {
        public string Typ { get; set; }
        public string Jméno { get; set; }
        public int PočetNohou { get; set; }
        public bool Létá { get; set; }
        public string Barva { get; set; }

        public string DisplayText
        {
            get
            {
                return $"Jméno: {Jméno}, Počet nohou: {PočetNohou}, Umí létat: {(Létá ? "Ano" : "Ne")}, Barva: {Barva}, Zvuk: {VydejZvuk()}";
            }
        }

        public Zvíře(string typ, string jméno, int početNohou, bool Létá, string barva)
        {
            Typ = typ;
            Jméno = jméno;
            PočetNohou = početNohou;
            Létá = Létá;
            Barva = barva;
        }

        public virtual string VydejZvuk()
        {
            return "Neznámý zvuk";
        }
    }
}
public class Pes : Zvíře
{
    public Pes(string jméno, int početNohou, bool Létá, string barva)
        : base("Pes", jméno, početNohou, Létá, barva)
    {
    }

    public override string VydejZvuk()
    {
        return "Hafo Haf";
    }
}

public class Kočka : Zvíře
{
    public Kočka(string jméno, int početNohou, bool Létá, string barva)
        : base("Kočka", jméno, početNohou, Létá, barva)
    {
    }

    public override string VydejZvuk()
    {
        return "Meow";
    }
}

public class Pták : Zvíře
{
    public int RozpětíKřídel { get; set; }

    public Pták(string jméno, int početNohou, bool Létá, string barva, int rozpětíKřídel)
        : base("Pták", jméno, početNohou, Létá, barva)
    {
        RozpětíKřídel = rozpětíKřídel;
    }

    public override string VydejZvuk()
    {
        return "Kykyrykí";
    }
}

public class Had : Zvíře
{
    public bool Jedovatý { get; set; }

    public Had(string jméno, int početNohou, bool Létá, string barva, bool jedovatý)
        : base("Had", jméno, početNohou, Létá, barva)
    {
        Jedovatý = jedovatý;
    }

    public override string VydejZvuk()
    {
        return "SsSsSs";
    }
}
