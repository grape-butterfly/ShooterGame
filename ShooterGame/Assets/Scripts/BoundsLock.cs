/***
 * Created By: Rain Baldridge
 * Date Created: Sept 15, 2021
 * 
 * Last Edited By:
 * Last Updated: Sept 15, 2021
 * 
 * Description: Game Boundary.
 * 
 ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsLock : MonoBehaviour
{
    public Rect LevelBounds; // x,y and w,h of boundary rectangle

    private void LateUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, LevelBounds.xMin,
            LevelBounds.xMax), transform.position.y, Mathf.Clamp(transform.position.z, 
            LevelBounds.yMin, LevelBounds.yMax));
    } // end LateUpdate()

    private void OnDrawGizmosSelected()
    {
        const int CubeDepth = 1;
        Vector3 boundsCenter = new Vector3(LevelBounds.xMin + LevelBounds.width * 0.5f, 0, 
            LevelBounds.yMin + LevelBounds.height * 0.5f);
        Vector3 boundsHeight = new Vector3(LevelBounds.width, CubeDepth, LevelBounds.height);

        Gizmos.DrawWireCube(boundsCenter, boundsHeight);
    } // end OnDrawGizmosSelected()
}
