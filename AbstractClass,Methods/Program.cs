using AbstractClass_Methods;

Car car = new("Dodge", "Challenger", "Black", 3, 460, "Benzin", 2, false);

Car car2 = new("Dodge", "Charger", "Red", 5, 685, "Dizel", 4, false);
Car car3 = new("Tesla", "3", "White", 1, 95, "none", 4, true);


Bicycle bicycle = new("Stels", "Navigator", "Green", 2, 60, "Country");
Bicycle bicycle2 = new("Salute", "Desna", "Blue", 2, 25, "Mountain");


Vehicle[] vehicles = { bicycle, bicycle2, car, car2, car3 };

foreach (var item in vehicles)
{
    Console.WriteLine(item.ToString());
}