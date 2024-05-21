namespace HomeWorkCollecthion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Remove("3");
            list.Add("6");
            list.Remove("1");
            list.Add("7");
            list.IEnumerable();
            list.LenghtMassive();
        }
    }
}
