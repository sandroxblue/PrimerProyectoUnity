using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {

    private Movimiento Player;
	// Use this for initialization
	void Start () {
        Player = GetComponentInParent<Movimiento>();
	}

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelos") Player.suelo = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelos") Player.suelo = false;
    }
}
