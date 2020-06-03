using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour {

    //config params
    [SerializeField] float scorePoints;
    [SerializeField] TextMeshProUGUI scoreText;

    //state variables
    [SerializeField] float currentScore = 0f;


	// Use this for initialization
	void Start () {
        scoreText.text = currentScore.ToString();
    }

    //acumulates score points
    public void AddToScore()
    {
        //currentScore += pointsPerBlockDestroyed;
        currentScore = currentScore + scorePoints;
        scoreText.text = currentScore.ToString();
    }

    //resets score method
    public void ResetScore()
    {
        Destroy(gameObject);
    }
}
