using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonpausa : MonoBehaviour
{
    [SerializeField] private GameObject BotonPause;
    [SerializeField] private GameObject MenuPausa;

    public void escenapausa()
    {
        Time.timeScale = 0f;
        BotonPause.SetActive(false);
        MenuPausa.SetActive(true);
        // SceneManager.LoadScene("MENUDEPAUSA");
    }
}
