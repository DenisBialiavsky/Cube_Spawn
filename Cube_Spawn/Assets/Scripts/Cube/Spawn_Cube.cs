using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Spawn_Cube : MonoBehaviour
{
    public GameObject[] cubemassiv;

    public Transform[] spawncube;

    public Button buttoncreatecube;
    public Button buttonstopcreatecube;

    private int count = 0;
    private int rand;
    private int randPosition;
    private float timecubeSpawn;
    public float startTimecubeSpawn;

    public void SpawnvalueTime(string spawntime)
    {
        startTimecubeSpawn = float.Parse(spawntime);
    }

    public void Spawnvaluecube(float timespawn)
    {
        startTimecubeSpawn = timespawn;
    }

    void Start()
    {
        timecubeSpawn = startTimecubeSpawn;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count = 1;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            count = 0;
        }

        if (count == 1)
        {
            Createcube();
        }
        else 
        {
            count = 0;
            
        }
        

    }

    public void Createcube()
    {
        if (timecubeSpawn <= 0)
        {
            rand = UnityEngine.Random.Range(0, cubemassiv.Length);
            randPosition = UnityEngine.Random.Range(0, spawncube.Length);
            Instantiate(cubemassiv[rand], spawncube[randPosition].transform.position, Quaternion.identity);
            timecubeSpawn = startTimecubeSpawn;
        }
        else
        {
            timecubeSpawn -= Time.deltaTime;
        }
    }

    private void CreatecubeonCkick()
    {
        buttoncreatecube.onClick.AddListener(Createcube);
        count = 1;
    }
    private void Stopcreatecube()
    {
        count = 0;
    }
}
