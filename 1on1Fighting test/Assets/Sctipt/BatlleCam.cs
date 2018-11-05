using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatlleCam : MonoBehaviour {
    public Transform LeftPlayer;
    public Transform RightPlayer;
    public float MiniDist;
        // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float DistBetweentargets = Mathf.Abs(LeftPlayer.position.z - RightPlayer.position.z) * 2;
        
        float centerPost = (LeftPlayer.position.z + RightPlayer.position.z) / 2;

        transform.position = new Vector3(DistBetweentargets > MiniDist ? -DistBetweentargets : -MiniDist, transform.position.y,centerPost
                                         );

    }
}
