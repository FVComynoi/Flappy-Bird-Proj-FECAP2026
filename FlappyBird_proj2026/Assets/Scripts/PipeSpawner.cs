using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate = 1f; 
    [SerializeField] float minHeight = -0.341f, maxHeight = 0.597f;

//private Time pipeLife=new Time();
    //public static void Instantiate()
    void Start()
    {
        StartCoroutine(SpawnPipe());    
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            Vector2 spawnPosition = 
                new Vector2(transform.position.x, Random.Range(minHeight, maxHeight));
            Instantiate(pipePrefab, spawnPosition, transform.rotation);
        }
    }
}
