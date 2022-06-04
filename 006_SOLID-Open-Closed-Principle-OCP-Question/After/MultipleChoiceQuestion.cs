namespace Open_Closed_Principle.After
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> choices { set; get; }

        public override void Print()
        {
           System.Console.WriteLine($"{Title} {Mark}");
           foreach (var item in choices)
           {
               System.Console.WriteLine($"{  item}");
           }
        }
    }
}