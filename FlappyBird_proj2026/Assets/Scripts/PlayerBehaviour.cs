using System;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject EndScreen;
    [SerializeField] private float jumpForce = 1;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        EndScreen.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AudioManager.Instance.PlayFlyingSound();
            rb.linearVelocity = Vector2.up * jumpForce;
        }

        transform.rotation = Quaternion.Euler(0f, 0f, rb.linearVelocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            AudioManager.Instance.PlayHitSound();
            GameManager.Instance.GameOver();
            jumpForce = 0f;
        }
    }
}