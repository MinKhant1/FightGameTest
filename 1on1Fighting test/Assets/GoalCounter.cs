using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoalCounter : MonoBehaviour {

    public Text goaltext;
    public int score = 0;
  
    


    // Use this for initialization
    void Start () {
      
	}


    private void Update()
    {
        
        updateScore(); 
       
    }

    public void updateScore()
    {
        goaltext.text = score.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Ball")
        {
            score++;

           

            Debug.Log("hitt");
        }
    }
}
