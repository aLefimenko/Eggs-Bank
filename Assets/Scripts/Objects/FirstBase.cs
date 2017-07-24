using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class FirstBase : MonoBehaviour
{
    public float eggsCount;
    public int[] levels = new int[10];

    private Text score;

    public FirstBase(float _countOfEggs, int[] _levels)
    {
        eggsCount = _countOfEggs;
        levels = _levels;
    }

    void Start()
    {
        gameObject.AddComponent<Click>().SetData(levels[0]);
    }

    void Update()
    {

    }
}
