using avorCompositionOverInheritance.Interface;

namespace FavorCompositionOverInheritance.Containerclass
{
    public class Cheese : ITopping
    {
        public string Title => $"{nameof(Cheese)}";

        public decimal Price => 3m;
    }
}