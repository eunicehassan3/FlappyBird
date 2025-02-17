using System.Collections;
using System.Threading;
using UnityEngine;
// using UnityEngine.Vector3;

public class SpawnWalls : MonoBehaviour
{
    public GameObject walls;
    private float timer;
    public float interval = 2.0f;
    //    private IEnumerator coroutine;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn();
        // coroutine = WaitAndPrint(2.0f);
        // StartCoroutine(coroutine);
         
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval){
            spawn();
            timer = 0.0f;
        }
    }


    float getRandomPosition(){
        // return Random.Range(2.37f,4.53f);
       return Random.Range(2f,5f);
    }

    // private IEnumerator WaitAndPrint(float waitTime)
    // {
    //     yield return new WaitForSeconds(waitTime);
    //     spawn();
    // }

    void spawn(){
        Vector3 PositionNew =  new Vector3(transform.position.x, getRandomPosition(),transform.position.z);
        Instantiate(walls,PositionNew, transform.rotation);

        
    
    }
}
