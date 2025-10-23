using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Spawn car on start
    // Variables
    public GameObject carPreFab;
    public Transform carSpawnPosition;


    // Start is called before the first frame update
    void Start()
    {
        CarSpawner();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CarSpawner()
    {
        SpawnACar();
        SpawnACar();
        SpawnACar();

        Invoke("CarSpawner", 1.5f);
    }

    void SpawnACar()
    {
        GameObject newCar = Instantiate(carPreFab, carSpawnPosition);

        Vector3 newSpawnPos = new Vector3(carSpawnPosition.position.x,
                                    carSpawnPosition.position.y,
                                    UnityEngine.Random.Range(2, 12)
                                    );

        newCar.transform.position = newSpawnPos;
    }
}
