namespace Telefonszamok
{
    internal class Program
    {
        static void Main(string[] args)
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
                //1
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
            Console.ReadKey();
        }
    }
}
