using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float velocity = 3.0f;
    public Rigidbody2D bird; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            // bird.linearVelocity = Vector2.zero;
 
            // bird.AddForce(Vector2.up * 30f) ;
            bird.linearVelocity = Vector2.up * velocity;
    
        }
    }
}
