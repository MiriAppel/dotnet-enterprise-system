namespace BO;

/// <summary>
/// לא קיים id שגיאה
/// </summary>
[Serializable]
public class BlIdNotExistException : Exception
{
    public BlIdNotExistException(string? message) : base(message) { }
    public BlIdNotExistException(string message, Exception innerException)
                : base(message, innerException) { }
}

/// <summary>
/// כבר קיים id שגיאה
/// </summary>
[Serializable]
public class BlIdExistException : Exception
{
    public BlIdExistException(string? message) : base(message) { }
    public BlIdExistException(string message, Exception innerException)
                : base(message, innerException) { }
}

/// <summary>
/// קלט לא תקין
/// </summary>
[Serializable]
public class BlNotValidInputException : Exception
{
    public BlNotValidInputException(string? message) : base(message) { }
    public BlNotValidInputException(string message, Exception innerException)
                : base(message, innerException) { }
}

/// <summary>
/// אין מספיק במלאי
/// </summary>
[Serializable]
public class BlNotEnoughInStockException : Exception
{
    public BlNotEnoughInStockException(string? message) : base(message) { }
    public BlNotEnoughInStockException(string message, Exception innerException)
                : base(message, innerException) { }
}
