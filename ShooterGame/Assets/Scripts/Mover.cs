/***
 * Created By: Rain Baldridge
 * Date Created: Sept 20, 2021
 * 
 * Last Edited By:
 * Last Updated: 
 * 
 * Description: Continuously moves GameObject
 * 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /*** variables ***/
    public float MaxSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * MaxSpeed * Time.deltaTime;
    }
}
