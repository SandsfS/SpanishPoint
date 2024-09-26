using CsvHelper;
using System.Globalization;
using System.IO;

public class Helper
{
    public static void WriteListToCSV(string filePath, List<string> list)
    {
        using (var writer = new StreamWriter(filePath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            foreach (var item in list)
            {
                csv.WriteField(item);
                csv.NextRecord();
            }
        }
    }

    public static List<string> ReadListFromCSV(string filePath)
    {
        List<string> list = new List<string>();

        using (var reader = new StreamReader(filePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            while (csv.Read())
            {
                list.Add(csv.GetField<string>(0)); // Assuming each line has one field
            }
        }

        return list;
    }
}
