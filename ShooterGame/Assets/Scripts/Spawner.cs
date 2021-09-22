/***
 * Created By: Rain Baldridge
 * Date Created: Sept 21, 2021
 * 
 * Last Edited By:
 * Last Updated: 
 * 
 * Description: Spawns new enemies.
 * 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    /*** variables ***/
    public float MaxRadius = 1f;
    public float Interval = 5f;
    public GameObject ObjToSpawn = null;
    private Transform Origin = null;

    private void Awake()
    {
        Origin = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, Interval);
    }

    void Spawn()
    {
        if(Origin == null) { return; }

        Vector3 SpawnPos = Origin.position + Random.onUnitSphere * MaxRadius;

        SpawnPos = new Vector3(SpawnPos.x, 0f, SpawnPos.z);
        Instantiate(ObjToSpawn, SpawnPos, Quaternion.identity);
    }
}
