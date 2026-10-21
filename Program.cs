string[] inventory = { "Health Potion", "Sword", "Shield", "Bread", "Key" };

for (int i = 0; i < inventory.Length; i++)
{
    Console.WriteLine($"Slot {i + 1}: {inventory[i]}");
}

Console.WriteLine($"\nTotal items: {inventory.Length}");