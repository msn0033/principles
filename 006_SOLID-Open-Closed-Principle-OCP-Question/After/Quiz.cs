namespace Open_Closed_Principle.After
{
    public class Quiz
    {
        public List<Question> questions{get;}
        public Quiz(List<Question> questions)
        {
            this.questions=questions;
        }
        public void Print(){
            foreach (var q in questions)
            {
                q.Print();
                System.Console.WriteLine("\n\n");
            }
        }
        
    }
}