using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    private float moveVelocity;
    public float speed = 5f;
    public float speedUp = 5f;
    private Rigidbody2D RBPlayer;
    public bool suelo;
    private Animator APlayer;
	// Use this for initialization
	void Start () {
        RBPlayer = GetComponent<Rigidbody2D>();
        APlayer = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        moveVelocity = 0f;

        APlayer.SetFloat("Speed", Mathf.Abs(RBPlayer.velocity.x));
        APlayer.SetBool("Grounded", suelo);

        float hInput = Input.GetAxis("Horizontal");
        RBPlayer.velocity = new Vector2(speed * hInput, RBPlayer.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (suelo==true)
            {
                RBPlayer.velocity = new Vector2(RBPlayer.velocity.x, speedUp);
            }
        }

        if (hInput > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (hInput < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }


        float newX = Mathf.Clamp(transform.position.x, -19, 19);
        float newY = Mathf.Clamp(transform.position.y, -15, 15);
        transform.position = new Vector3(newX, newY, transform.position.z);
    }
}
