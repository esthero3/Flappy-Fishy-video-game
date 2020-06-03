using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fishy : MonoBehaviour {

    //config params
    [SerializeField] float jumpAmount;

    //cached
    Rigidbody2D myRigidBody2D;

    // Use this for initialization
    void Start () {
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }
	
	//Fishy jumps every time mouse is right clicked or space bar is pressed
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    //Jump method
    public void Jump()
    {
        myRigidBody2D.velocity = Vector2.up * jumpAmount;
    }

    //end game when Fishy collides with the floor
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("dead");
        // SceneManager.LoadScene("Game Over");
    }
}
