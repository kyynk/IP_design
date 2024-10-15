using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class FileIO_01 : MonoBehaviour
{
    async private void Start()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "test.txt");
        string content = await ReadFileAsync(path);
        print(content);
    }

    public async Task<string> ReadFileAsync(string filePath)
    {
        string content = "";
        try
        {
            content = await File.ReadAllTextAsync(filePath);
        }
        catch (Exception e)
        {
            print("Error reading file: " + e.Message);
        }
        return content;
    }
}
