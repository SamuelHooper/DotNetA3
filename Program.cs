namespace DotNetA3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;

            Console.WriteLine($"1. {today,40:MMMM dd, yyyy} \n" +
                              $"2. {today:yyyy.MM.dd} \n" +
                              $"3. {today:'Day' dd 'of' MMMM, yyyy} \n" +
                              $"4. {today:'Year:' yyyy, 'Month:' MM, 'Day:' dd} \n" +
                              $"5. {today,10:dddd} \n" +
                              $"6. {today,10:hh:mm tt}{today,10:dddd} \n" +
                              $"7. {today:'h:'hh, 'm:'mm, 's:'ss} \n" +
                              $"8. {today:yyyy.MM.dd.hh.mm.ss} \n");

            var pi = Math.PI;
            Console.WriteLine($"1. {pi:c} \n" +
                              $"2. {pi,10:f3}");
        }
    }
}