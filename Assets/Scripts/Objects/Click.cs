using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

class Click : Object, IUpgrade
{
    public float SellObject(float _value)
    {
        return score - value * 0.7f;
    }

    public float UpgradeObject(float _value)
    {
        return Mathf.Exp(_value);
    }

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
         score = UpgradeObject(value);
    }

    public void SetData(int _level)
    {
        level = _level;
        RedData();
    }
}
