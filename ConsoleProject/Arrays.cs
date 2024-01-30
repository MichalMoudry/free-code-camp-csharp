namespace ConsoleProject.Arrays;

internal sealed class Arrays
{
    public static void RunAssignment()
    {
        string[] frodulentIds = [
            "A123",
            "B456",
            "C789",
            "D000"
        ];
        foreach (var item in frodulentIds) Console.WriteLine(item);
        frodulentIds[1] = "F000";
        foreach (var item in frodulentIds) Console.WriteLine(item);
        Console.WriteLine($"Number of IDs: {frodulentIds.Length}\n");

        int[] inventory = [200, 450, 700, 175, 250];
        var sum = 0;
        var bin = 0;
        foreach (var items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"Inventory sum: {sum} | {inventory.Sum()}");
        Console.WriteLine("===============================\n");

        string[] orderIds = [
            "B123",
            "C234",
            "A345",
            "C15",
            "B177",
            "G3003",
            "C235",
            "B179"
        ];
        foreach (var id in orderIds)
        {
            if (id.StartsWith('B'))
            {
                Console.WriteLine($"ID '{id}' starts with a B");
            }
        }
    }
}