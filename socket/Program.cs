SuperParallel.Invoke(
    () =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Task 1");
    },

    () =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Task 2");
    },

    () =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Task 3");
    }
);

Console.WriteLine("All finished");

Console.ReadLine();

Console.WriteLine("\n================\n");


SuperParallel.For(0, 10, i =>
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
});

Console.WriteLine("For finished");

Console.WriteLine("\n================\n");



List<int> numbers = new List<int>()
{
    1, 2, 3, 4, 5
};

SuperParallel.ForEach(numbers, n =>
{
    Console.WriteLine(n);
    Thread.Sleep(1000);
});

Console.WriteLine("ForEach finished");
