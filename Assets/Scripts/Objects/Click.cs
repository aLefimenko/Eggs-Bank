using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Click : Object, IUpgrade
{
    public void SellObject()
    {
        
    }

    public float UpgradeObject()
    {
        return Mathf.Sqrt
    }

    void Start()
    {
        type = "click";
        level = 0;
        value = Mathf.Pow(10f, level * 2.5f);
        eggsPerSecond = UpgradeObject();
    }

  
}
