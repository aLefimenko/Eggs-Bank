using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class ScriptClick : Click
{
    void OnMouseDown()
    {
        BuyObject();
        StartGet();
    }
}

