using System;

class Cat
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(Name));

            var trimmedName = value.Trim();
            if (trimmedName.Length == 0)
                throw new ArgumentOutOfRangeException(nameof(Name));

            name = trimmedName;
        }
    }

    public Cat(string name)
    {
        Name = name;
    }

    public override string ToString() => $"{GetType().Name} has name {Name}";
}