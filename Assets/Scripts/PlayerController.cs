using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {
	



    public float moveSpeed;
	private float moveSpeedReset;

    public float speedMultiplier;

    public float speedIncreaseMil;
    private float speedMilCount;
	private float speedMilCountReset;

    public float JumpForce;

    private Rigidbody2D rigidBody;


    public bool onGround;
    public LayerMask whatIsGround;

    public Transform GroundCheck;
    public float groundCheckRadius;

    
    private Animator anim;

    public GameManager gameManager;



	public bool pausepressed;

	public Button pause;



	// Use this for initialization
	void Start () {

        rigidBody = GetComponent<Rigidbody2D>();
        
        anim = GetComponent<Animator>();

        speedMilCount = speedIncreaseMil;

		moveSpeedReset = moveSpeed;
		speedMilCountReset = speedMilCount;

		pause = GetComponent<Button>();

	}

	// Update is called once per frame
	void Update () {



		 


		onGround = Physics2D.OverlapCircle (GroundCheck.position, groundCheckRadius, whatIsGround);
        


		if (transform.position.x > speedMilCount) {
			speedMilCount += speedIncreaseMil;

			speedIncreaseMil = speedIncreaseMil * speedMultiplier;
			moveSpeed = moveSpeed * speedMultiplier;
		}



		rigidBody.velocity = new Vector2 (moveSpeed, rigidBody.velocity.y);





			
			

		anim.SetFloat ("Speed", rigidBody.velocity.x);
		anim.SetBool ("Ground", onGround);


			
	}

    

    void OnCollisionEnter2D (Collision2D other)
    {
       if (other.gameObject.tag == "killpoint")
        {
            gameManager.RestartGame();
			moveSpeed = moveSpeedReset;
			speedMilCount = speedMilCountReset;
        } 
    }

	public void Jump (){


			if (onGround) {
				rigidBody.velocity = new Vector2 (rigidBody.velocity.x, JumpForce);
			}
		
	}









	
	
	}
	
