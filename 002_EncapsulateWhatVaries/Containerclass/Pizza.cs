namespace EncapsulateWhatVaries.Containerclass
{
    public class Pizza
    {
        public virtual string Title => $"{nameof(Pizza)}";
        public virtual decimal Price => 2m;
        public static Pizza Order(string type){
            Pizza pizza=CreatePizza(type);
            Prepare();
            Cook();
            Cut();
            return pizza;

        }

        private static Pizza CreatePizza(string type)
        {
            Pizza pizza=null;
           if(type.Equals(PizzaConstants.CheesePizza))
           pizza=new Cheese(); 
           else if(type.Equals(PizzaConstants.ChickenPizza))
           pizza=new Chicken();
           else if(type.Equals(PizzaConstants.VegetablePizza))
           pizza=new Vegetable();
           return pizza;
        }

        private static void Prepare()
        {
            System.Console.Write("Prepare.....");
            Thread.Sleep(1000);
            System.Console.WriteLine("Complated");
        }
        private static void Cook()
        {
            System.Console.Write("Cooking.....");
            Thread.Sleep(1000);
            System.Console.WriteLine("Complated");
        }
        private static void Cut()
        {
            System.Console.Write("Cuting and Boxing.....");
            Thread.Sleep(1000);
            System.Console.WriteLine("Complated");
        }

        public override string ToString()
        {
            return $"\n{this.Title}"+
            $"\n\t Price : {this.Price}";
        }
    }
}