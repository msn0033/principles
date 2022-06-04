using avorCompositionOverInheritance.Interface;

namespace FavorCompositionOverInheritance.Containerclass
{
    public class Chicken : ITopping
    {
         public string Title => $"{nameof(Chicken)}";

        public decimal Price => 4m;
    }
}