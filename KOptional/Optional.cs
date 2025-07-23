namespace KOptional;

public struct Optional<TObject>
{
    private TObject? _value;

    /// <summary>
    /// Represents an optional value that may or may not be present.
    /// </summary>
    public Optional() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Optional{TObject}"/> struct with a value.
    /// </summary>
    public Optional(TObject value)
    {
        Value = value;
    }

    /// <summary>
    /// Indicates whether the optional contains a value.
    /// </summary>
    public bool HasValue { get; private set; } = false;

    /// <summary>
    /// Gets or sets the value of the optional.
    /// </summary>
    public TObject? Value
    {
        get => _value ?? default;
        set
        {
            _value = value;
            HasValue = true;
        }
    }

    public static implicit operator Optional<TObject>(TObject value)
    {
        return new Optional<TObject>(value);
    }

    /// <summary>
    /// Tries to get the value of the optional.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool TryGetValue(out TObject? value)
    {
        value = HasValue ? Value : default;
        return HasValue;
    }

    /// <summary>
    /// Returns the value if present, otherwise returns the specified default value.
    /// </summary>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public TObject? Coalesce(TObject defaultValue)
    {
        return HasValue ? Value : defaultValue;
    }

    /// <summary>
    /// Returns a string representation of the optional value.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        if(HasValue)
        {
            return Value?.ToString() ?? "null";
        }

        return "No Value";
    }

    /// <summary>
    /// Checks if the current instance is equal to another instance of <see cref="Optional{TObject}"/>.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is Optional<TObject> other &&
               HasValue == other.HasValue &&
               EqualityComparer<TObject?>.Default.Equals(Value, other.Value);
    }

    /// <summary>
    /// Returns a hash code for the current instance of <see cref="Optional{TObject}"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return HashCode.Combine(HasValue, Value);
    }

}
