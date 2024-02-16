namespace OmopTransformer.Transformation;

internal class KeyWithName(string key, string? name)
{
    public string Key { get; } = key ?? throw new ArgumentNullException(nameof(key));
    public string? Name { get; } = name;

    public override int GetHashCode()
    {
        return Key.GetHashCode();
    }

    protected bool Equals(KeyWithName other)
    {
        return Key == other.Key;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((KeyWithName)obj);
    }

    public KeyWithName(string key) : this(key, null)
    {
    }

    public override string ToString() => key;
}