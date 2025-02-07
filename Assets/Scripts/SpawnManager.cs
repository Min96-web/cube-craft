using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class SpawnManager : MonoBehaviour
{
    public GameObject armchairPrefab;

    public GameObject bookcasePrefab;

    public GameObject coffeeTablePrefab;

    public GameObject plant1Prefab;

    public GameObject plant2Prefab;

    private static readonly Vector3 SpawnPosition = new (0,0,0);
    
    // Start is called before the first frame update
    void Start()
    {
        // Invoke("SpawnArmchair");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnArmchair()
    {
        Instantiate(armchairPrefab, SpawnPosition, armchairPrefab.transform.rotation);
    }
}
