namespace Open_Closed_Principle.After
{
    public class QuestionsBank
    {

        public List<Question> QuestionsGenerator()
        {
            return new List<Question> {
                new WHQuestion{
                    Title="What are the four pillars of OOP?",
                    Mark=8
                },
                new MultipleChoiceQuestion{
                    Title="Which of the fllowing are value types?",
                    Mark=6,
                    choices=new List<string>{
                        "A : Integer",
                        "B : Array",
                        "C : Single",
                        "D : string",
                        "E : long",
                        "F : decimal"
                    }
                },
                  new TrueFalseQuestion{
                        Title="Earth is Bigger than Sun?",
                        Mark=4
                    }


            };
        }
    }
}