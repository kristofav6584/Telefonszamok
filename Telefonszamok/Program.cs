using System.Threading.Tasks.Dataflow;

namespace Telefonszamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> telefonszamok = new List<string>();
            
                telefonszamok.Add("+36202275895");
                telefonszamok.Add("06203568987");
                telefonszamok.Add("(06)20/2558222");
                telefonszamok.Add("203568978+");
                telefonszamok.Add("nullahat202289578548");
while (true)
            {
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. Mindent megjelenít");
                Console.WriteLine("2. Csak a számjegyeket tartalmazók");
                Console.WriteLine("3. Csak a 12 hosszóak");
                Console.WriteLine("4. Csak a számjegyeket és + jelet tartalmazhat");
                Console.WriteLine("5. Csak azok jelenjenek meg amiben 6-os szám van");
                Console.WriteLine("6. Csak számok és + jel, de csak elől lehet a +jel");
                Console.WriteLine("7. 06-tal kezdődik");
                Console.WriteLine("8. ( és vagy ) jel van benne");

                string valaszt = Console.ReadLine();
                if (valaszt == "0")
                {
                    return;
                }
                else if (valaszt == "1")
                {
                    Console.Clear();
                    foreach (String szamok in telefonszamok)
                    {
                        Console.WriteLine(szamok);
                    }
                }
                else if (valaszt == "2")
                {
                    Console.Clear();
                    foreach (var szamok in telefonszamok)
                    {
                        bool jo = true;
                        foreach (char szam in szamok)
                        {
                            if (char.IsLetter(szam))
                                jo = false;
                        }
                        if (jo)
                            Console.WriteLine(szamok);
                    }
                }
                else if (valaszt == "3")
                {
                    Console.Clear();
                    foreach (var telefonszam in telefonszamok)
                    {
                        if (telefonszam.Length == 12)
                        {
                            Console.WriteLine(telefonszam);
                        }
                    }
                }
                else if (valaszt == "4")
                {
                    Console.Clear();
                    foreach (var telefonszam in telefonszamok)
                    {
                        bool megfelelo = true;
                        foreach (var szamjegyek in telefonszam)
                        {
                            if (!char.IsNumber(szamjegyek) && szamjegyek != '+')
                            {
                                megfelelo = false;
                            }
                        }
                        if (megfelelo)
                            Console.WriteLine(telefonszam);
                    }
                }
                else if (valaszt == "5")
                {
                    Console.Clear();

                    foreach (var telefonszam in telefonszamok)
                    {
                        if (telefonszam.Contains('6'))
                            Console.WriteLine(telefonszam);
                    }
                }
                else if (valaszt == "6")
                {
                    Console.Clear();
                    foreach (String telefonszam in telefonszamok)
                    {
                        bool megfelelo = true;
                        for (int i = 0; i < telefonszam.Length; i++)
                        {
                            if (i == 0)
                            {
                                if (!char.IsNumber(telefonszam[i]) && telefonszam[i] != '+')
                                    megfelelo = false;


                            }
                            else
                            {
                                if (!char.IsNumber(telefonszam[i]))
                                    megfelelo = false;
                            }
                        }
                        if (megfelelo)
                            Console.WriteLine(telefonszam);
                    }
                }
                else if (valaszt == "7")
                {
                    Console.Clear();
                    foreach (var telefonszam in telefonszamok)
                    {
                        if (telefonszam[0] == '0' && telefonszam[1] == '6')
                            Console.WriteLine(telefonszam);
                    }
                }
                else if (valaszt == "8")
                {
                    Console.Clear();
                    foreach (String telefonszam in telefonszamok)
                    {
                        if (telefonszam.Contains('(') || telefonszam.Contains(')'))
                            Console.WriteLine(telefonszam);
                    }
                }
                else
                {
                    Console.WriteLine("Nincs ilyen parancs");
                }
                Console.ReadKey();
            }
        }
    }
}
