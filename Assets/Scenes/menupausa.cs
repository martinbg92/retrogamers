using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menupausa : MonoBehaviour
{
    [SerializeField] private GameObject BotonPause;
    [SerializeField] private GameObject MenuPausa;

    public void escenajuego()
    {
        //SceneManager.LoadScene("retrogamers1");
        Time.timeScale = 1f;
        BotonPause.SetActive(true);
        MenuPausa.SetActive(false);
    }

    public void guardarpartida()
    {

    }

    public void sonido()
    {
            
    }

    public void salir()
    {
        SceneManager.LoadScene("MENUPRINCIPAL");
    }
    public void marcadores()
    {
        SceneManager.LoadScene("FINJUEGO");
    }
}
