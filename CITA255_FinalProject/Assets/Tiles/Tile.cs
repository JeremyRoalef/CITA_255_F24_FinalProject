using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script is attached to the tile game obejct
 * 
 * This script will be responsible for updating the name of the tiles in the game (for convinience) while in unity editor,
 * Handling mouse input logic when the tile is clicked, & more
 */

[ExecuteAlways]
public class Tile : MonoBehaviour
{
    //Using the x-z plane to place my tiles
    int xPos;
    int zpos;
    //The grid snap size
    const int GRID_SNAP_SIZE = 10;

    void Update()
    {
        //Update the name of the tile script to the x and z position (x,z)
        xPos = (int)transform.position.x;
        zpos = (int)transform.position.z;
        int xCoordinate = xPos/GRID_SNAP_SIZE;
        int zCoordinate = zpos/GRID_SNAP_SIZE;

        //Update the name of the object
        gameObject.name = $"({xCoordinate}, {zCoordinate})";
    }
}
