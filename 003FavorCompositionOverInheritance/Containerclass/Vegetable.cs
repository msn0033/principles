using avorCompositionOverInheritance.Interface;

namespace FavorCompositionOverInheritance.Containerclass
{
    public class Vegetable : ITopping
    {
         public string Title => $"{nameof(Vegetable)}";

        public decimal Price => 7m;
    }
}