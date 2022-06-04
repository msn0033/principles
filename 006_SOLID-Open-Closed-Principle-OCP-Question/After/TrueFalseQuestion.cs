namespace Open_Closed_Principle.After
{
    public class TrueFalseQuestion : Question
    {
        public override void Print()
        {
            System.Console.WriteLine( $"{Title} {Mark}");
            System.Console.WriteLine("1. T");
            System.Console.WriteLine("2. F");
        }
    }
}