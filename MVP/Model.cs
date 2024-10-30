using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;
using System;

[System.Serializable]
public class ListGameObject
{
    public List<GameObject> list = new List<GameObject>();
}
public class Model : MonoBehaviour
{
    public SerializebleDict<List<GameObject>> serializebleDict;
    public Dictionary<string, List<GameObject>> data;
    private void Start()
    {
        data = serializebleDict.getDict();
    }
}

[Serializable]
public class SerializebleDict<T>
{
    public List<SerializeData<T>> data;
    public Dictionary<string, T> dict = new Dictionary<string, T>();
    public Dictionary<string, T> getDict()
    {
        for(int i = 0; i < data.Count; i++)
        {
            dict.Add(data[i].key, data[i].value);
        }
        return dict;
    }
}

[Serializable]
public class SerializeData<T>
{
    public string key;
    public T value;
}
