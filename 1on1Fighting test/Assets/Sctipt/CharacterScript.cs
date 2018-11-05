using UnityEngine;

public class CharacterScript : MonoBehaviour {

    public Animator anim;
    public Rigidbody rb;
    public States currentStates = States.Idle;

    public CharacterScript opponent;
    public static float Max_Health = 100f;
    public float health = Max_Health;

    public float random;
    public float settime;

    public enum PlayerType
    { Human,Ai}

   

    public PlayerType type;

    void Start() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }


    void Update() {
       /* anim.SetFloat("Health", 1);
        if(opponent!=null)
        {
            anim.SetFloat("OpponentHealth", opponent.healthperc);
        }
        else
        {
            anim.SetFloat("OpponentHealth", 1);
        }*/

        if (type == PlayerType.Human)
        {
            UpdatePlayerInput();
        }
        else
        {
            UpdateAiInput();
        }
        
    }

    private float DistanceToOpponent()
    {
        return Mathf.Abs(transform.position.z - opponent.transform.position.z);
    }

    public void UpdatePlayerInput()
    {
        if (Input.GetAxis("Horizontal") > 0.1)
        {
            anim.SetBool("Moveforward", true);
        }
        else
        {
            anim.SetBool("Moveforward", false);
        }

        if (Input.GetAxis("Vertical") > 0.1)
        {
            anim.SetTrigger("JumpActive");
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            anim.SetBool("MoveBackward", true);
        }
        else
        {
            anim.SetBool("MoveBackward", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Kicking");

        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("Punching");

        }
    }
    public void UpdateAiInput()
    {
        anim.SetFloat("DistanceToOpponent", DistanceToOpponent());


        if(Time.time-settime>1)
        {
            random = Random.value;
            settime = Time.time;
        }
        anim.SetFloat("Random", random);
        
    }

    
    public bool attacking
    {
        get
        {
            return currentStates == States.Attack;
        }
    }
    public bool invurlable
    {
        get
        {
            return currentStates == States.Take_Hit || currentStates == States.Take_HitDef || currentStates == States.Dead;
        }
    }

    public Rigidbody body
    {
        get
        {
            return this.rb;
        }
    }
    public float healthperc
    {
        get
        {
            return health / Max_Health;
        }
    }

    public void hurt(float damage)
    {
        if (!invurlable)
        {
            if (health >= damage)
            {
                health -= damage;
            }
            else
            {
                health = 0;
            }
        }

    }
    
        

}
