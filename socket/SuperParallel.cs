using System.Collections;

public static class SuperParallel
{
    public static void Invoke(params Action[] actions)
    {
        List<Task> tasks = new List<Task>();

        foreach (Action action in actions)
        {
            Task task = new Task(action);
            tasks.Add(task);
            task.Start();
        }

        Task.WaitAll(tasks);
    }

    public static void For(int from, int to, Action<int> action)
    {
        List<Task> tasks = new List<Task>();

        for (int i = from; i < to; i++)
        {
            int index = i;

            Task task = new Task(() =>
            {
                action(index);
            });

            tasks.Add(task);
            task.Start();
        }

        Task.WaitAll(tasks);
    }

    public static void ForEach<T>(IEnumerable<T> collection, Action<T> action)
    {
        List<Task> tasks = new List<Task>();

        foreach (T item in collection)
        {
            T currentItem = item;

            Task task = new Task(() =>
            {
                action(currentItem);
            });

            tasks.Add(task);
            task.Start();
        }

        Task.WaitAll(tasks);
    }
}
