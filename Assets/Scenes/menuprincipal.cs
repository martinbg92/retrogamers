using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuprincipal : MonoBehaviour
{
    [SerializeField] private GameObject damenombre;
    public InputField user;
    private string scoreprefs = "score";

    private string nombreprefs = "Nombre";

    public void jugadornombre()
    {
        PlayerPrefs.SetInt(scoreprefs, 0);
        damenombre.SetActive(true);
    }

    [SerializeField] private GameObject Ingresanombre;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DameNombre()
    {
        Ingresanombre.SetActive(true);
    }

    //
    public void escenajuego()
    {

        //  PlayerPrefs.SetString("name", user.text);
        savedata();
        Time.timeScale = 1f;
        SceneManager.LoadScene("retrogamers1");  
    }

    public void cargarpartida()
    {
        SceneManager.LoadScene("FINJUEGO");
    }

    public void sonido()
    {

    }

    public void salir()
    {
        Application.Quit();
        Debug.Log("salio del juego");
    }

    private void savedata()
    {
        PlayerPrefs.SetString(nombreprefs, user.text);
    }
    /*
    private void loaddata()
    {

    }^*/
}
