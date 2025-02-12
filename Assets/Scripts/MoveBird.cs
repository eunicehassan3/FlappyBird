using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 2.0f;
    public Rigidbody2D bird; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            // transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f);
            bird.AddForce(Vector3.up);
            // transform.position += Vector3.up * speed * Time.deltaTime;
            
        }
    }
}
