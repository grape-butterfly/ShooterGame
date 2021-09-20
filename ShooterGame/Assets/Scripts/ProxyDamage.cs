/***
 * Created By: Rain Baldridge
 * Date Created: Sept 20, 2021
 * 
 * Last Edited By:
 * Last Updated: Sept 20, 2021
 * 
 * Description: Deal damage to any colliding obj w/ health component.
 * 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    /*** variables ***/
    public float DamageRate = 10f; // damage per second

    private void OnTriggerStay(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();

        if(H == null) { return;  }

        H.HealthPoints -= DamageRate * Time.deltaTime;
    }
}
