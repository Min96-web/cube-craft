using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] furniture;
    //public GameObject armchairPrefab;

    //public GameObject bookcasePrefab;

    //public GameObject coffeeTablePrefab;

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


    public void SpawnFurniture(int furnitureIndex)
    {
        //Instantiate(armchairPrefab, SpawnPosition, armchairPrefab.transform.rotation);
        //Instantiate(bookcasePrefab, SpawnPosition, bookcasePrefab.transform.rotation);
        //Instantiate(coffeeTablePrefab, SpawnPosition, coffeeTablePrefab.transform.rotation);
        //Instantiate(plant1Prefab, SpawnPosition, plant1Prefab.transform.rotation);
        //Instantiate(plant2Prefab, SpawnPosition, plant2Prefab.transform.rotation);
        Instantiate(furniture[furnitureIndex], SpawnPosition, furniture[furnitureIndex].transform.rotation);
    }
}