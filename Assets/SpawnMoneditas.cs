using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoneditas : MonoBehaviour {
    public GameObject monedita;
    public GameObject[] moneditasList;
    public float minMonedas = 1f;        
    public float maxMonedas = 5f;

	public void Update () {
        moneditasList = GameObject.FindGameObjectsWithTag("PickUp");
        if (moneditasList.Length == 0) MoneditaSpawn();
        Debug.Log(moneditasList.Length);
	}

    public void MoneditaSpawn()
    {
        for (int i=0;i<Random.Range(minMonedas,maxMonedas); i++)
        {

            Vector3 randomSpawn = new Vector3(Random.Range(-17.5f, 17.5f), Random.Range(-10.0f, 9.0f), 0);
            Instantiate(monedita, randomSpawn, transform.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(monedita);
        Puntuacion.nPuntuacion += 1;    
    }
}
