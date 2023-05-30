using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTerrain : MonoBehaviour
{
    public GameObject Terrain0;
    public GameObject Terrain1;
    public GameObject Terrain2;
    public GameObject Terrain3;
    public GameObject Terrain4;

    private float zPosition;
    public int Size = 5;

    public Transform player;
    public GameObject spawn;

    private List<GameObject> TerrainType = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position.z >= 75f)
        {
            Destroy(spawn);
        }

        //Debug.Log("Can Spawn? " + canSpawn());
        if(canSpawn())
        {
            GenerateTerrain();
        }
        else if (player.position.z >= ((TerrainType[3].transform.position.z) - 20f))
        {
            RemoveTerrain();
        }


    }

    private bool canSpawn()
    {
        if(TerrainType.Count < Size)
        {
            return true;
        }

        return false;
    }

    private void GenerateTerrain()
    {
        int RNG = Random.Range(0, 5);

        
        if(RNG == 0)
        {
            zPosition += 40;
            TerrainType.Add(Instantiate(Terrain0, new Vector3(0, 0, zPosition), Quaternion.identity) as GameObject);
        }
        else if (RNG == 1)
        {
            zPosition += 40;
            TerrainType.Add(Instantiate(Terrain1, new Vector3(0, 0, zPosition), Quaternion.identity) as GameObject);
        }
        else if (RNG == 2)
        {
            zPosition += 40;
            TerrainType.Add(Instantiate(Terrain2, new Vector3(0, 0, zPosition), Quaternion.identity) as GameObject);
        }
        else if (RNG == 3)
        {
            zPosition += 40;
            TerrainType.Add(Instantiate(Terrain3, new Vector3(0, 0, zPosition), Quaternion.identity) as GameObject);
        }
        else if (RNG == 4)
        {
            zPosition += 40;
            TerrainType.Add(Instantiate(Terrain4, new Vector3(0, 0, zPosition), Quaternion.identity) as GameObject);
        }
    }

    private void RemoveTerrain()
    {
        GameObject toRemove = TerrainType[0];
        Destroy(toRemove);
        TerrainType.Remove(TerrainType[0]);
    }
}
