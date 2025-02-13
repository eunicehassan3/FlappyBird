using System.Collections;
using UnityEngine;
// using UnityEngine.Vector3;

public class SpawnWalls : MonoBehaviour
{
    public GameObject walls;
       private IEnumerator coroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coroutine = WaitAndPrint(2.0f);
        StartCoroutine(coroutine);
         
    }

    // Update is called once per frame
    void Update()
    {
    
    }


    float getRandomPosition(){
       return Random.Range(2.37f,4.53f);
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        spawn();
    }

    void spawn(){
        Vector3 PositionNew =  new Vector3(transform.position.x, getRandomPosition(),transform.position.z);
        Instantiate(walls,PositionNew, transform.rotation);
    }
}
