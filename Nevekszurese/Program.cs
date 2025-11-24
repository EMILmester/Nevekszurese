namespace Nevekszurese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Koleszár Emil");
            list.Add("Kiss István József");
            list.Add("rácrz László");
            list.Add("Farkas1 Aladár");
            list.Add("Pető@Ilona.hu");
            list.Add("Pisti");
            list.Add("12Elemér");
            list.Add("SzekeresKata");
            while (true)
            {
                Console.Clear();
                Console.Write("0 - Kilépés");
                Console.Write("1 - Összes név listázása");
                Console.Write("2 - Csak betűket tartalmazó nevek listázása");
                Console.Write("3 - Nagybetűvel kezdődő nevek listázása");
                Console.Write("4 - Rövid nevek listázása");
                Console.Write("5 - Nagybetűvel kezdődő nevek ahol a többi kicsi" + "és nem tartalmaz számot és speciális jelet");
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0": return; //Kilépés
                    case "1": Console.WriteLine("1"); break;
                    case "2": Console.WriteLine("2"); break;
                    case "3": Console.WriteLine("3"); break;
                    case "4": Console.WriteLine("4"); break;
                    case "5": Console.WriteLine("5"); break;
                    default:Console.WriteLine("Érvénytelen parancs!"); break;
                }
                Console.ReadKey();

            }
        }
    }
}
