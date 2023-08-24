using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barradevida : MonoBehaviour
{
    [SerializeField] private GameObject GAMEOVER;
    public Image barraDevida;

    public float vidaActual;
    public float vidaInicial;

    public GameObject explosion_player;

    // Update is called once per frame
    void Update()
    {
        barraDevida.fillAmount = vidaActual / vidaInicial;
        if (barraDevida.fillAmount <= 0)
        {
            Time.timeScale = 1f;
            GAMEOVER.SetActive(true);
            Destroy(gameObject);
            Instantiate(explosion_player, transform.position, transform.rotation);
        }
    }
}

