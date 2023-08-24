using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;

    public float damage;

    public int scoreValue;
    private GameController gameController;

    void Start()

    {

        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();

    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("limite")) return;
        if (other.CompareTag("Jugador")) { other.GetComponent<Barradevida>().vidaActual -= damage; }
        else { Destroy(other.gameObject); }

        gameController.AddScore(scoreValue);
        Destroy(gameObject);
        Instantiate(explosion, transform.localPosition, transform.rotation);
    }
}
