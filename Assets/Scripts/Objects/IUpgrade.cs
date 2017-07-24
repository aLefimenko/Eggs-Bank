using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IUpgrade
{
    float UpgradeObject(float _value);
    float SellObject(float _value);
    void BuyObject();
    void SetData(int level);
    void RedData();
}

