using System.IO;
using UnityEngine;

public class LogToFile : MonoBehaviour
{
    private static StreamWriter fileWriter;

  

    // private void OnDestroy()
    // {
    //     Application.logMessageReceived -= LogMessageHandler;
    //     if (fileWriter != null)
    //     {
    //         fileWriter.Close();
    //         fileWriter.Dispose();
    //     }
    // }

 
}