using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> breakfastFood = new List<string>();

            breakfastFood.Add("Waffles");
            breakfastFood.Add("German Pancake");
            breakfastFood.Add("Biscuits and Gravy");
            breakfastFood.Add("Aloo Dosa");
            breakfastFood.Add("Farina");
            breakfastFood.Add("Poori");
            breakfastFood.Add("Steak and Eggs");

            var plate = breakfastFood.OrderBy(x => x.Length).ToList();

            foreach (var food in plate)
            {
                Console.WriteLine(food);
            }
        }
    }
}
