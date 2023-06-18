using System.IO;
using Microsoft.VisualBasic.FileIO;

public class Journal
{
    public List<Entry> _entryList = new List<Entry>();

    public void AddEntry(Entry newEntry){
        _entryList.Add(newEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine();
        foreach(Entry Entry in _entryList)
        {
            Entry.DisplayEntry();
        }
    }

    public void SaveToFile(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("Date,Prompt,Entry");
            foreach(Entry entry in _entryList)
        {
           string newEntry= entry._userEntry.Replace("\"", "\"\""); 
           outputFile.WriteLine($"\"{entry._date}\",\"{entry._prompt}\",\"{newEntry}\"");
        }

        }
        Console.WriteLine($"File saved as {fileName}");
    }

    public List<Entry> LoadFromFile(string fileName)
    {
        List<Entry> _entryList=new List<Entry>();
        TextFieldParser parser = new TextFieldParser(fileName);
        parser.HasFieldsEnclosedInQuotes = true;
        parser.SetDelimiters(",");
        string[] fields;
        while (!parser.EndOfData)
        {
            fields = parser.ReadFields();
            if(fields[0] != "Date")
            {
                Entry entry= new Entry();
                entry._date=fields[0].ToString();
                entry._prompt=fields[1].ToString();
                entry._userEntry=fields[2].ToString();
                _entryList.Add(entry);
            }
        } 
        parser.Close();
        return _entryList;
    }
}