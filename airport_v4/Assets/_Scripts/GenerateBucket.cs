using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBucket : MonoBehaviour {

    public GameObject bucket1;
    public GameObject bucket2;
    public GameObject bucket3;

    // Use this for initialization
    void Start () {
        InvokeRepeating("SpawnBucket", 3.0f, 3.0f);
    }
	
    void SpawnBucket()
    {
        int random_number = Random.Range(1, 4);
        if (random_number == 1)
        {
            var bucket = GameObject.Instantiate(bucket1);
        } else if (random_number == 2) 
        {
            var bucket = GameObject.Instantiate(bucket2);
        } else if (random_number == 3)
        {
            var bucket = GameObject.Instantiate(bucket3);
        }
        Vector3 position = new Vector3(5.35f, 1.806f, 0.096f);
        bucket.transform.position = position;
    }
}
