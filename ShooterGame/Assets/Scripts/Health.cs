/***
 * Created By: Rain Baldridge
 * Date Created: Sept 20, 2021
 * 
 * Last Edited By:
 * Last Updated: 
 * 
 * Description: GameObject Health
 * 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    /** variables **/
    public bool DestroyOnDeath = true;
    public GameObject DeathPrefab = null;
    [SerializeField] private float _HealthPoints = 100f;
    
    public float HealthPoints {  
        get { return _HealthPoints; } 
        set { _HealthPoints = value; 
           if(HealthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);
                
                if(DeathPrefab != null)
                {
                    Instantiate(DeathPrefab, transform.position, transform.rotation);
                }
                if (DestroyOnDeath)
                {
                    Destroy(gameObject);
                }
            }
        } // end set
    } // end HealthPoints

    // Update is called once per frame
    void Update()
    {
        // Debug Health test
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HealthPoints = 0;
        } // end debug
    }
}
