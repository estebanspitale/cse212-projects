/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly Queue<Person> _queue = new Queue<Person>();

    public int Length => _queue.Count;

    /// <summary>
    /// Add a person to the queue
    /// </summary>
    /// <param name="person">The person to add</param>
    public void Enqueue(Person person)
    {
        _queue.Enqueue(person); // agrega al final
    }

    public Person Dequeue()
    {
        return _queue.Dequeue(); // saca del frente
    }

    public bool IsEmpty()
    {
        return _queue.Count == 0;
    }

    public override string ToString()
    {
        return $"[{string.Join(", ", _queue.Select(p => p.Name))}]";
    }
}