using ContosoPizza.Models;
namespace ContosoPizza.Services;
public static class PizzaService{
    static List<Pizza> Pizzas{get;}
    static int nextId = 3;
    static PizzaService(){
        Pizzas = new List<Pizza>{
            new Pizza{Id = 1, name = "Clasic italian", isGlutenFree = true},
            new Pizza{Id = 2, name = "Veggie", isGlutenFree = true},
        };
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static void Add(Pizza pizza){
        Pizzas.Add(pizza);
    }
    public static void Delete(int id) => Pizzas.RemoveAll(p => p.Id == id);

    public static void Update(Pizza pizza){
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if(index == -1) return;
        Pizzas[index] = pizza;
    }
}