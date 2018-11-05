using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterSelect : MonoBehaviour {


    public GameObject[] characters = new GameObject[3];
    public Transform characterPanel;
    private int SelectedChar;
    public Transform charspawnpoint;
    public GameObject lastviewhero;

    private void Start()
    {
        CharSelect();
    }
    public void CharSelect()
    {
        int i=0;
        foreach (Transform t in characterPanel)
        {
            int currentindex = i;
            Button b = t.GetComponent<Button>();
            b.onClick.AddListener(() => CharacterChosen(currentindex));
            
            i++;
         
        }
        }


    public void CharacterChosen(int index)
    {
        Debug.Log("selecting hero" + index);


        if (lastviewhero != null)
            Destroy(lastviewhero);

        lastviewhero = GameObject.Instantiate(characters[index]) as GameObject;
         lastviewhero.transform.SetParent(charspawnpoint);
        //lastviewhero.transform.localPosition = Vector3.zero;

        // Instantiate(characters[index],charspawnpoint);

       


    }
}
