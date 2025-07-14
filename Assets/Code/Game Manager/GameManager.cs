using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager gameInstance;
    [Header("Lists")]
    public List<PlayerController> players;
    public List<TankPawn> pawns;

    [Header("Prefabs")]
    public GameObject playerPawnPrefab;
    public GameObject playerControllerPrefab;

    private void Awake()
    {
        if (gameInstance == null)
        {
            // Set instance of GM to our static variable
            gameInstance = this;

            // Prevent object destruction on scene load
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Prevents multiple GMs from existing
            Destroy(gameObject);
        }



    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnStart(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnStart(Vector3 spawnPosition)
    {
        GameObject tempPlayerControllerObject = Instantiate<GameObject>(playerControllerPrefab); //Create player object and copy of controller using prefab
        tempPlayerControllerObject.transform.position = Vector3.zero; //Move to 0,0,0
        PlayerController tempPlayerController = tempPlayerControllerObject.GetComponent<PlayerController>(); //Get component for controller
        players.Add(tempPlayerController);

        GameObject tempPlayerPawnObject = Instantiate<GameObject>(playerPawnPrefab); //Create Tank Pawn object and copy of Tank using prefab
        TankPawn tempPlayerPawn = tempPlayerPawnObject.GetComponent<TankPawn>(); //Get component for Tank Pawn
        tempPlayerPawnObject.transform.position = spawnPosition; //Creates tank at Spawn Point
        pawns.Add(tempPlayerPawn);

        tempPlayerController.pawn = tempPlayerPawn; // Connect pawn to controller
    }
}
