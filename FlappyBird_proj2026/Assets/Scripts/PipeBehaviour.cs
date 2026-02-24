using UnityEngine;

public class PipeBehaviour : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        if (transform.position.x >= -1.011)
        {
            //transform.position.x = 0.746;
            //            Random.Range(0.597,-0.341)
        }
            
    }
}
