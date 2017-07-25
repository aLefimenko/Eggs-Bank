using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public abstract class Example : MonoBehaviour
{
    protected string type;
    protected int level;
    protected float value; // стоимость
    protected float eggsPerSecond; // заработок в секунду
    protected int upgrade; // уровень апгрейда
    protected float score; // 
    protected Coroutine corTime;
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

    public void StartGet()
    {
        StartCoroutine(Return());
    }

    IEnumerator Return()
    {
        yield return new WaitForSeconds(1f);
        score += eggsPerSecond;
        Debug.Log(score.ToString() + "   " + eggsPerSecond.ToString());

    }
}