using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour {

    public static bool Pausado = false;

    public GameObject menuPausaUI;
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pausado)
            {
                Continuar();
            }
            else
            {
                Pausar();
            }
        }
	}

    public void Continuar()
    {
        menuPausaUI.SetActive(false);
        Time.timeScale = 1f;
        Pausado = false;
    }

    void Pausar()
    {
        menuPausaUI.SetActive(true);
        Time.timeScale = 0f;
        Pausado = true;
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Main");
        Puntuacion.nPuntuacion = 0;
        Time.timeScale = 1f;
        Debug.Log("Reiniciarndo juego...");
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
