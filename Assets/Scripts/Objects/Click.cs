using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

class Click : Example, IUpgrade
{

    void Start()
    {
        type = "click";
        level = 0;
        RedData();
    }
    
    public void BuyObject()
    {
        level++;
        RedData();
    }

    public void RedData()
    {
        value = Mathf.Exp(level);
        score -= value;
        eggsPerSecond = UpgradeObject(value);
    }

    public void SetData(int _level)
    {
        level = _level;
        RedData();
    }
}
