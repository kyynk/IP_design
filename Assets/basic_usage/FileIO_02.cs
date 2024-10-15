using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;

public class FileIO_02 : MonoBehaviour
{
    async private void Start()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "test.txt");
        string content = await WriteFileAsync(path);
        print(content);
    }

    public async Task<string> WriteFileAsync(string filePath)
    {
        string content = "Hello, Wat shall I do for you?";
        try
        {
            await File.WriteAllTextAsync(filePath, content);
        }
        catch (Exception e)
        {
            print("Error writing file: " + e.Message);
        }
        return content;
    }
}
