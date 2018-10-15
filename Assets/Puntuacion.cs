using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puntuacion : MonoBehaviour {
    
    public static int nPuntuacion = 0;    
    public Text puntuacion;

    // Use this for initialization
    void Start () {

        puntuacion = GetComponent<Text>();
  
	}
	
	// Update is called once per frame
	void Update () {

        puntuacion.text = "Puntuacion:  " + nPuntuacion;
        
	}
}
