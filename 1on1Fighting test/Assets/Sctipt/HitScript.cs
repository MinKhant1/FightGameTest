using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScript : MonoBehaviour {

    public string attname;
    public float damage;
    public CharacterScript owner;
    public GameObject ball;
    private Rigidbody ballrigid;
    public Vector3 forceamount = new Vector3(50, 20);

    private void Start()
    {
        ballrigid = ball.GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        CharacterScript sdt = other.gameObject.GetComponent<CharacterScript>();
        if (owner.attacking)
        {
            if (sdt != null && sdt != owner)
            {
                sdt.hurt(damage);
            }
        }
        if(owner.attacking && other.gameObject.tag=="Ball")
        {
            ballrigid.AddForce(forceamount, ForceMode.Impulse);
            Debug.Log("ball was hit");
        }
        
    }
}
