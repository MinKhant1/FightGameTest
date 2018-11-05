using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceScript : MonoBehaviour
{

    public GameObject ball;
    private Rigidbody ballrigid;
    public CharacterScript owner;
    public Vector3 forceamount = new Vector3(50, 20);
    private void Start()
    {
        ballrigid = ball.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (owner.attacking && collision.gameObject.tag == "Ball")
        {
            ballrigid.AddForce(forceamount, ForceMode.Impulse);
            Debug.Log("ball was hit");
        }
    }





}
