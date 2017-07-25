using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using System.Xml.Serialization;
using System.IO;

[Serializable]
public class FirstBase : MonoBehaviour
{
    public float eggsCount;
    public int[] levels = new int[10];

    private Text score;
    private FirstBase gameObj;
    public FirstBase(float _countOfEggs, int[] _levels)
    {
        eggsCount = _countOfEggs;
        levels = _levels;
    }

    public FirstBase()
    {

    }

    void Start()
    {
        gameObj = LoadDataFromFile();
        gameObject.AddComponent<Click>().SetData(levels[0]);
        GameObject.FindGameObjectWithTag("score").GetComponent<Text>().text = "Eggs : " + eggsCount.ToString();
    }

    void Update()
    {
        score.text = eggsCount.ToString();
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
