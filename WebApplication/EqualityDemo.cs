namespace WebApplication;

public sealed class EqualityDemo(string firstName, string lastName) : IEquatable<EqualityDemo>
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;

    public bool Equals(EqualityDemo? other) =>
        other is not null
        && string.Equals(FirstName, other.FirstName, StringComparison.OrdinalIgnoreCase)
        && string.Equals(LastName, other.LastName, StringComparison.OrdinalIgnoreCase);

    public override bool Equals(object? obj) => obj is EqualityDemo other && Equals(other);

    public override int GetHashCode() =>
        HashCode.Combine(
            StringComparer.OrdinalIgnoreCase.GetHashCode(FirstName),
            StringComparer.OrdinalIgnoreCase.GetHashCode(LastName));

    public static bool operator ==(EqualityDemo? left, EqualityDemo? right) => Equals(left, right);

    public static bool operator !=(EqualityDemo? left, EqualityDemo? right) => !(left == right);

    public static void Run()
    {
        var first = new EqualityDemo("Ada", "Lovelace");
        var second = new EqualityDemo("ADA", "LOVELACE");
        var third = new EqualityDemo("Grace", "Hopper");

        Console.WriteLine("Equality demo output:");
        Console.WriteLine($"first == second: {first == second}");
        Console.WriteLine($"first.Equals(second): {first.Equals(second)}");
        Console.WriteLine($"first == third: {first == third}");

        var set = new HashSet<EqualityDemo> { first, second, third };
        Console.WriteLine($"Distinct items in HashSet: {set.Count}");
    }
}
