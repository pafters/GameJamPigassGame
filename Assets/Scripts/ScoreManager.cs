using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public event Action<int> OnChangeScore;
    
    private int _score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void AddScore(int addScore = 1)
    {
        Debug.Log("+1");
        _score += addScore;
        OnChangeScore?.Invoke(_score);
    }
  
}
