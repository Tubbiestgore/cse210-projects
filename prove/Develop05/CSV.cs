using System.Text;

class CSV
{
    public static void SaveToCSV(List<String> _dataToSave, string _filePath) // Saves file to CSV
    {
        File.WriteAllLines(_filePath, _dataToSave);
    }

    public static List<String> LoadFromCSV(string _filePath) // Loads from CSV
    {
        List<string> fromCSV = new List<string>();
        StreamReader streamReader = new StreamReader(_filePath);
        
        while (!streamReader.EndOfStream)
        {
            string line = streamReader.ReadLine();
            fromCSV.Add(line.ToString());
        }
           
        streamReader.Close();

        return fromCSV;
    }   
}