using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucharscript : MonoBehaviour {


    private float settime;
    private float random;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time - settime > 1)
        {
            random = Random.Range(1f, 2f);
            settime = Time.time;
        }
        



    }

   public void StartGame()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(random>1.5)
            {
                anim.SetTrigger("pun");
            }
            else
            {
                anim.SetTrigger("ki");
            }
        }
       


    }
    


}
