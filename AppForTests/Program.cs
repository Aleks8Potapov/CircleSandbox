namespace AppForTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Source String:");

            var sourceString = @"ä'á`č-ď_ěéíľľňôóřŕšťúůýž ÄÁČĎĚÉÍĽĽŇÔÓŘŔŠŤÚŮÝŽ ÖÜË łŁđĐ ţŢşŞçÇ øı";
            Console.WriteLine(sourceString);

            var R1 = Helper.RemoveDiacritics(sourceString);

            Console.WriteLine(R1);

            var r2 = Helper.RemoveDiacriticsRegExp(sourceString);
            Console.WriteLine(r2);

            Console.ReadKey();
        }
    }
}