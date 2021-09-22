/***
 * Created By: Rain Baldridge
 * Date Created: Sept 22, 2021
 * 
 * Last Edited By:
 * Last Updated: 
 * 
 * Description: Ammo
 * 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    /*** variables ***/
    public float Damage = 100f;
    public float LifeTime = 2f;

    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", LifeTime);
    } // end OnEnable()

    private void OnTriggerEnter(Collider other)
    {
        Health H = other.gameObject.GetComponent<Health>();

        H.HealthPoints -= Damage;
        Die();
    } // end OnTriggerEnter()

    void Die()
    {
        gameObject.SetActive(false);
    } // end Die()

    // Start is called before the first frame update
    void Start()
    {
        
    } // end Start()

    // Update is called once per frame
    void Update()
    {
        
    } // end Update()
}
