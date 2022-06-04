// See https://aka.ms/new-console-template for more information
using avorCompositionOverInheritance.Interface;
using FavorCompositionOverInheritance.Containerclass;

int choice = 0;
Pizza pizza = new Pizza();

do
{
    Console.Clear();
    choice = ReadChoice(choice);
    ITopping topping = null;
    if (choice > 0 && choice < 4)
    {
        topping = SelectItemFromMenu(choice, topping);
        pizza.add(topping);
    }
} while (choice != 0);

System.Console.WriteLine(pizza);
Console.ReadKey();



ITopping SelectItemFromMenu(int choice, ITopping topping)
{
    switch (choice)
    {
        case 1:
            topping = new Chicken();
            break;
        case 2:
            topping = new Cheese();
            break;
        case 3:
            topping = new Vegetable();
            break;
        default: break;
    }
    return topping;
}
int ReadChoice(int choice)
{
    System.Console.WriteLine("Today's Menu");
    System.Console.WriteLine("----------");
    System.Console.WriteLine("1. Chicken");
    System.Console.WriteLine("2. Cheese");
    System.Console.WriteLine("3. Vegetable");
    System.Console.WriteLine("-------ReadKey 0 to Exit------\n");
    System.Console.WriteLine("What is your Order");
    choice = int.Parse(Console.ReadLine());
    return choice;
}