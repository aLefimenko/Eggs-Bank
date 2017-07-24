using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;

public abstract class Object : MonoBehaviour
{
    protected string type;
    protected int level;
    protected float value;
    protected float eggsPerSecond;
    protected int upgrade;
    protected float score;
    public FirstBase dataBase;

    void Awake()
    {
        dataBase = LoadDataFromFile();
    }

    void Start()
    {
        score = float.Parse(GameObject.FindGameObjectWithTag("score").GetComponent<Text>().text);
    } 

    public FirstBase LoadDataFromFile()
    {
        FirstBase baseOfData = null;
        XmlSerializer serializer = new XmlSerializer(typeof(FirstBase));
        using (FileStream streamForRead = new FileStream("baseData.xml", FileMode.Open, FileAccess.Read))
        {
            baseOfData = (FirstBase)serializer.Deserialize(streamForRead);
        }
        return baseOfData;
    }

    public void SaveDateToFile(FirstBase _base)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(FirstBase));
        using (FileStream streamForWrite = new FileStream("baseData.xml", FileMode.Create, FileAccess.Write))
        {
            serializer.Serialize(streamForWrite, _base);
        }
    }

}