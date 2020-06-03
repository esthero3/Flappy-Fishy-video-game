using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacles : MonoBehaviour {

    //config param
    [SerializeField] float speed;

	//Moves the obstacles left
	void Update () {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
