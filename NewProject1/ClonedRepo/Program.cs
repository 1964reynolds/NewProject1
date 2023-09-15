
public class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Child>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var child = new Child();

            Console.WriteLine("Enter the value for ");
            child.myProperty = Console.ReadLine();

            recordList.Add(child);
        }
    }
}

// Print out the list of records using Console.WriteLine()