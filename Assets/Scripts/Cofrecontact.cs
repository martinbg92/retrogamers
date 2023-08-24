using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cofrecontact : MonoBehaviour
{
    public GameObject explosion;

    public float damage;

    
    private GameController gameController;

    void Start()

    {

        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("limite")) return;
        if (other.CompareTag("Jugador")) { other.GetComponent<Barradevida>().vidaActual += damage; }
        else { Destroy(other.gameObject); }

        
        Destroy(gameObject);
        Instantiate(explosion, transform.localPosition, transform.rotation);
    }
}