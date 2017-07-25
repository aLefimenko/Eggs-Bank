using System.IO;
using UnityEngine;
using UnityEngine.UI;


public abstract class Example : MonoBehaviour
{
    protected string type;
    protected int level;
    protected float value;
    protected float eggsPerSecond;
    protected int upgrade;
    protected float score;
    //public FirstBase dataBase;

    void Start()
    {
        //GameObject.FindGameObjectWithTag("score").GetComponent<Text>().text = "Eggs : " + score.ToString();
    } 
    

    public float SellObject(float _value)
    {
        return score - value * 0.7f;
    }

    public float UpgradeObject(float _value)
    {
        return Mathf.Exp(_value);
    }

}