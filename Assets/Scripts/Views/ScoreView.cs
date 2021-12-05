using System;
using TMPro;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class ScoreView : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreComponent;
        [SerializeField] private ScoreManager _scoreManager;

        private void Start()
        {
            _scoreManager = ScoreManager.Instance;
        }

        private void OnEnable()
        {
            _scoreManager.OnChangeScore += ShowScore;
        }

        private void OnDisable()
        {
            _scoreManager.OnChangeScore -= ShowScore;
        }

        private void ShowScore(int score)
        {
            _scoreComponent.text = score.ToString();
        }
    }
}