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
                //2
            }
            else if (valaszt == "3")
            {
                //3
            }
            else if (valaszt == "4")
            {
                //4
            }
            else if (valaszt == "5")
            {
                //5
            }
            else if (valaszt == "6")
            {
                //6
            }
            else if (valaszt == "7")
            {
                //7
            }
            else if (valaszt == "8")
            {
                //8
            }
            else
            {
                Console.WriteLine("Nincs ilyen parancs");
            }
                Console.ReadKey();
        }
    }
}
