
using Unity.VisualScripting;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    public float wallspeed = 2.0f;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(-0.5f,0f) * Time.deltaTime * wallspeed;

        // if transform.position = 
        
    }
}
