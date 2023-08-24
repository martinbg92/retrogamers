using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public static class fileManagment
{
    private static string filePath = Application.dataPath + @"/Data/";

    private static void CreateFile(string filename)
    {
        if (!Directory.Exists(filePath))
        {
            Directory.CreateDirectory(filePath);
        }
        if(File.Exists(filePath + filename))
        {
            var f = File.Create(filePath + filename);
            f.Close();
        }

    }

    public static void OpenFile<T>(T saveData, string fileName)
    {
        CreateFile(fileName);
        object result = null;
        try
        {
            using (var fs = File.Open(filePath + fileName, FileMode.OpenOrCreate))
            {
                var serializer = new XmlSerializer(typeof(T));
                result = serializer.Deserialize(fs);
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }
    }

    public static void SaveFile<T>(T saveData, string fileName)
    {
        try
        {
            using (var sw = new StreamWriter(filePath + fileName))
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sw, saveData);
                sw.Flush();
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }

    }
    
}
  