using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntuacionMax : MonoBehaviour {

    public static int puntosMax = 0;
    public Text puntuacionMax;

    // Use this for initialization
    void Start () {

        puntuacionMax = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {

        puntuacionMax.text = "Puntuacion Maxima:  " + puntosMax;
        if (Puntuacion.nPuntuacion >= puntosMax) puntosMax = Puntuacion.nPuntuacion;

    }
}
