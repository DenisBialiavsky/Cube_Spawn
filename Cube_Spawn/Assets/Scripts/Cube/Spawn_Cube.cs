using UnityEngine;
using UnityEngine.UI;


public class Spawn_Cube : MonoBehaviour
{
    public GameObject[] cubemassiv;

    public Transform[] spawncube;

    

    private bool count = false;
    private int rand;
    private int randPosition;
    private float timecubeSpawn;
    public float startTimecubeSpawn;

    public void SpawnvalueTime(string spawntime) => startTimecubeSpawn = float.Parse(spawntime);

    public void Spawnvaluecube(float timespawn) => startTimecubeSpawn = timespawn;
   

    void Start() => timecubeSpawn = startTimecubeSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count = true;
        }

        else if (Input.GetKeyDown(KeyCode.F))
        {
            count = false;
        }

        if (count == true)
        {
            Createcube();
        }
        else 
        {
            count = false;
            
        }
        

    }

    public void Createcube()
    {
        if (timecubeSpawn <= 0)
        {
            rand = Random.Range(0, cubemassiv.Length);
            randPosition = Random.Range(0, spawncube.Length);
            Instantiate(cubemassiv[rand], spawncube[randPosition].transform.position, Quaternion.identity);
            timecubeSpawn = startTimecubeSpawn;
        }
        else
        {
            timecubeSpawn -= Time.deltaTime;
        }
    }
}
