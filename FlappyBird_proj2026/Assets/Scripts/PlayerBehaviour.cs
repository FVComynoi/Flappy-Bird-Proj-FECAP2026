using System;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1;
        private Rigidbody2D rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.GetButtonDown("Fire1")) 
            {
                rb.linearVelocity += Vector2.up*jumpForce;
            }
        }
}