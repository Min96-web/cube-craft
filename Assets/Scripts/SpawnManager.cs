using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    //public List<GameObject> furniturePrefabs;
    //public GameObject[] furniture;
    public GameObject armchairPrefab;

    public GameObject bookcasePrefab;

    public GameObject coffeeTablePrefab;

    //public GameObject plant1Prefab;

    //public GameObject plant2Prefab;

    private static readonly Vector3 SpawnPosition = new(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnArmchair()
    {
        Instantiate(armchairPrefab, SpawnPosition, Quaternion.identity);
    }
    public void SpawnBookCase()
    {
        Instantiate(bookcasePrefab, SpawnPosition, Quaternion.identity);
    }

    public void SpawnCoffeeTable()
    {
        Instantiate(coffeeTablePrefab, SpawnPosition, Quaternion.identity);
    }
    //public void SpawnFurniture(int furnitureIndex)
    //{
        //if (furnitureIndex < 0 || furnitureIndex >= furniturePrefabs.Count)
        //{
            //Debug.LogWarning("Invalid furniture index!");
            //return;
        //}
        
        //GameObject furniture = Instantiate(furniturePrefabs[furnitureIndex], SpawnPosition, Quaternion.identity);
    //}
}