using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private TextMeshProUGUI scoreText;
    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        AudioManager.Instance.PlayScoreSound();
        GameManager.Instance.AddScore();
    }
}