﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;
public class RoomTemplates : MonoBehaviour
{

    #region Variables
    public GameObject[] bottomRooms;
    public GameObject[] topRooms;
    public GameObject[] leftRooms;
    public GameObject[] rightRooms;
    public GameObject closedRoom;
    public List<GameObject> rooms;
    public float waitTime;
    private bool spawnedBoss = false;
    public GameObject boss;

    #endregion

    private void Update()
    {



        if (waitTime <= 0 && spawnedBoss == false)
        {
           // Instantiate(boss, rooms[rooms.Count - 1].transform.position, Quaternion.identity);
            spawnedBoss = true;

        }
        else
        {
            waitTime -= Time.deltaTime;
            Scene scene = SceneManager.GetActiveScene();


        }
    }



}
