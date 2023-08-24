using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid_rotation : MonoBehaviour
{

    private Rigidbody rig;
    public float range;
    

    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.angularVelocity = Random.insideUnitSphere * range;
        rig.velocity = new Vector3(0, 0, Random.Range(-200, -200));
    }

   

    
}
  