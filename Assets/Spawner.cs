using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    public float time = 0;
    public GameObject pipes;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipes = Instantiate(pipes);
        newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);   
    }

    // Update is called once per frame
    void Update()
    {
        if (time >maxTime){
            GameObject newPipes = Instantiate(pipes);
            newPipes.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); 
            Destroy(newPipes, 8);
            time = 0;
        }
        time += Time.deltaTime;
    }
}
