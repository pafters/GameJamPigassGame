using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private ScoreManager _scoreManager;

    private void Start()
    {
        _scoreManager = ScoreManager.Instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.name == "Salo")
        {
            Debug.Log("ISWORKSALOED");
            _scoreManager.AddScore();
        }
        
    }
   
}
