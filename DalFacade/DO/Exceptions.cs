namespace DO;

/// <summary>
/// לא קיים id שגיאה
/// </summary>
[Serializable]
public class DalIdNotExistException : Exception
{
    public DalIdNotExistException(string error)
    {
        throw new Exception(error);
    }
}

/// <summary>
/// כבר קיים id שגיאה
/// </summary>
[Serializable]
public class DalIdExistException : Exception
{
    public DalIdExistException(string error)
    {
        throw new Exception(error);
    }
}
