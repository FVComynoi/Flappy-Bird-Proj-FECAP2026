using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;

    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
        /*if (transform.position.x <= endPos)
        {
            transform.position = new Vector3(startPos, Random.Range(maxHeight,minHeight), transform.position.z);
        }
        if (transform.position.x == midPos)
        {
            Instantiate(PipeParent, new Vector3(startPos, Random.Range(maxHeight, minHeight), 0), Quaternion.identity);
        }
        */
    // private void OnCollisionEnter2D(Collision2D other)
    // {
    // gameObject.
    // }
}