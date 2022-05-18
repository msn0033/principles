namespace EncapsulateWhatVaries.Containerclass
{
    public class Vegetable:Pizza
    {
        public override string Title => base.Title + $"{nameof(Vegetable)}";
        public override decimal Price => base.Price + 7m;
    
        
    }
}