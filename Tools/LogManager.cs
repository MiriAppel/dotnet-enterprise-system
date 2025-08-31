using System.IO;

namespace Tools;

public static class LogManager
{
    private static string logFolderPath = "Log";

    /// <summary>
    /// יצירת תיקייה לכל חודש
    /// </summary>
    /// <returns>ניתוב התיקייה הנוכחית</returns>
    public static string GetCurrentFolderPath()
    {
        string folderPath = @$"{logFolderPath}\{DateTime.Now.Year}_{DateTime.Now.Month}";
        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);
        return folderPath;
    }

    /// <summary>
    /// יצירת קובץ לכל יום
    /// </summary>
    /// <returns>ניתוב הקובץ הנוכחית</returns>
    public static string GetCurrentFilePath()
    {
        string filePath = @$"{GetCurrentFolderPath()}\{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt";
        if (!File.Exists(filePath))
            File.Create(filePath).Close();
        return filePath;
    }

    /// <summary>
    /// כתיבת תיעוד ללוג
    /// </summary>
    /// <param name="nameProject">שם הפרויקט</param>
    /// <param name="nameFunc">שם הפונקציה</param>
    /// <param name="message">תיאור</param>
    public static void WriteToLog(string nameProject, string nameFunc, string message)
    {
        using (StreamWriter sw = new StreamWriter(LogManager.GetCurrentFilePath(), true))
        {
            sw.WriteLine($"{DateTime.Now}\t{nameProject}.{nameFunc}:\t{message}");
        }
    }

    /// <summary>
    /// ניקוי תיקיות לוג ישנות - מלפני חודשיים ומעלה
    /// </summary>
    public static void CleanOldFolder()
    {
        DateTime date = DateTime.Now.AddMonths(-2);
        string [] folders = Directory.GetDirectories(logFolderPath);
        bool flag = false;
        foreach (string folder in folders)
        {
            DateTime creationTime = Directory.GetCreationTime(folder);
            if (creationTime < date)
            {
                flag = true;
                Directory.Delete(folder, true);
            }
        }
        if (flag)
        {
            Console.WriteLine("cleaning old log folder successfully");
        }
        else
        {
            Console.WriteLine("not have old log folder to clean");
        }
    }
}