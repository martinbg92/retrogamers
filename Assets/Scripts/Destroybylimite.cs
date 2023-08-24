using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybylimite : MonoBehaviour
{
   public void OnTriggerExit(Collider other)
   {
     //   gameObject.SetActive(false);
        Destroy(other.gameObject);
    }
}
