using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_drone : MonoBehaviour
{

    private Rigidbody rig;
    public float range;


    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = new Vector3(0, 0, Random.Range(-600, -200));
    



    }

    //void Update() 
    //{


    //}


}
