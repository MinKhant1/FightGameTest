using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : StateMachineBehaviour
{

    public float HorizontalForce;
    public float VerticalForce;
    public CharacterScript Cscript;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {if (Cscript == null)
        {
            Cscript = animator.gameObject.GetComponent<CharacterScript>();
        }
        Cscript.body.AddRelativeForce(new Vector3(0, VerticalForce, 0));
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        Cscript.body.AddRelativeForce(new Vector3(0,0,HorizontalForce));
    }

}
