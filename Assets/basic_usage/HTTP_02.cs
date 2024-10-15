using System;
using System.Net.Http;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor.Search;

public class HTTP_02 : MonoBehaviour
{
    private static readonly HttpClient client = new HttpClient();

    async void Start()
    {
        string url = "https://example.com";
        await FetchAndProcessDataAsync(url);
    }

    private async Task FetchAndProcessDataAsync(string url)
    {
        try
        {
            using (HttpResponseMessage response =
                await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                using (StreamReader reader = new StreamReader(stream))
                {
                    {
                        string content = await reader.ReadToEndAsync();
                        Debug.Log("Recieve content: " + content);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Debug.LogError("Error fetching data: " + ex.Message);
        }
    }
}
