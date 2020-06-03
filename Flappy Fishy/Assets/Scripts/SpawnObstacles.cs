using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {

    //time before new pipe is spawned
    [SerializeField] float maxTime;

    //time passing
    private float timer = 0;

    //height of obstacle
    [SerializeField] float height;

    //reference to pipe game object
    public GameObject obstacles;

    // Use this for initialization
    void Start () {
        GameObject newObstacle = Instantiate(obstacles);
        newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }
	
	// Spawn Pipes
	void Update () {
        if (timer > maxTime)
        {
            GameObject newobstacle = Instantiate(obstacles);
            newobstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newobstacle, 5);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
