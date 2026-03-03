using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float startPos = 0.924f;
    [SerializeField] private float endPos=-1.011f;
    [SerializeField] private float moveSpeed = 2f;
    private float pipePosition;
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        if (transform.position.x <= endPos)
        {
            transform.position = new Vector3(startPos, Random.Range(0.597f,-0.341f), transform.position.z);
        }
    }

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    // gameObject.
    // }
}