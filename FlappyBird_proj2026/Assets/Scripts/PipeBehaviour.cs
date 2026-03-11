using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float startPos = 0.924f;
    [SerializeField] private float endPos=-1.011f;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] float minHeight= -0.341f, maxHeight= 0.597f;
    [SerializeField] GameObject PipeParent;
    void Update()
    {
        float midPos = Random.Range(0.023f,0.095f);
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        if (transform.position.x <= endPos)
        {
            transform.position = new Vector3(startPos, Random.Range(maxHeight,minHeight), transform.position.z);
        }
        if (transform.position.x == midPos)
        {
            Instantiate(PipeParent, new Vector3(startPos, Random.Range(maxHeight, minHeight), 0), Quaternion.identity);
        }
    }

    // private void OnCollisionEnter2D(Collision2D other)
    // {
    // gameObject.
    // }
}