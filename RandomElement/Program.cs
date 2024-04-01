string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "Asian nudels" };

Random rnd = new Random();

int randomindex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomindex]}.");