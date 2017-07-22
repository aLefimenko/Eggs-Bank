using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggTap : MonoBehaviour {

    private Animation animEgg;
    private Text textScore;
    private int i = 0;

	void Start () {
        textScore = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        animEgg = GetComponent<Animation>();
        animEgg.Stop();
        textScore.text = "Eggs : " + i.ToString();
	}
	

	
	void Update () {
		
	}

    void OnMouseDown()
    {
        i++;
        if(animEgg.isPlaying)
        {
            animEgg.Stop();
        }
        animEgg.Play();
        textScore.text = "Eggs : " + i.ToString();
    }
}
