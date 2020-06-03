using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fishy : MonoBehaviour {

    //config params
    [SerializeField] float jumpAmount;

    //cached
    Rigidbody2D myRigidBody2D;

    // Use this for initialization
    void Start () {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }
	
	//Fishy jumps every time mouse is right clicked or space bar is pressed
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
            Time.timeScale = 1;
        }
    }

    //Jump method
    public void Jump()
    {
        myRigidBody2D.velocity = Vector2.up * jumpAmount;
    }

    //end game when Fishy collides with the floor
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Lose"))
        {
            Debug.Log("dead");
            SceneManager.LoadScene("Game Over");
        }
        
        
    }
}
