using avorCompositionOverInheritance.Interface;

namespace FavorCompositionOverInheritance.Containerclass
{
    public class Pizza
    {
        public virtual decimal Price => 2m;
        public IList<ITopping> toppings { get; private set; } = new List<ITopping>();
        public void add(ITopping topping) => toppings.Add(topping);
        private decimal Calculate()
        {
            var total = Price;
            foreach (var item in toppings)
            {
                total += item.Price;
            }
            return total;

        }




        public override string ToString()
        {
            var output = $"\n{nameof(Pizza)}";
            output += $"\n\t Base Price : {Price.ToString("C")}";
            foreach (var item in toppings)
            {
                output += $"\n\t{item.Title} ({item.Price.ToString("C")})";
            }
            output+="\n--------------";
            output+=$"\nTotal: {this.Calculate().ToString("C")}";

            return output;
        }
    }
}