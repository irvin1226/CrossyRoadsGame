using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    //Dictates how many "enemies" are currently in the world
    private bool canSpawn = false;
    [SerializeField] [Range(0, 1)] public int RNGLevel;

    //Dictates how many "enemies" to spawn when the game runs
    //public int spawnEnemies;
    public float delay = 5f;
    private float timeToSpawn = 0f;

    public GameObject enem;
    public GameObject SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;
        timeToSpawn = delay;
    }

    // Update is called once per frame
    void Update()
    {
        int RNG = RandomNum()%2;
        if(RNG == RNGLevel && timeToSpawn <= 0)
        {
            Spawn();
        }
        timeToSpawn -= Time.deltaTime;

    }

    private int RandomNum()
    {
        int randNum = Random.Range(0, 11);
        return randNum;
    }

    private void Spawn()
    {
        timeToSpawn = delay;
        GameObject enemy = Instantiate(enem, transform.position, transform.rotation);
    }
}
