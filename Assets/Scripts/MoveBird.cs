using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float velocity = 3.0f;
    public Rigidbody2D bird; 
    public AudioSource src;
    public AudioClip bounce;
    public AudioClip fail;
    public bool collide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        collide = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            // bird.linearVelocity = Vector2.zero;
 
            // bird.AddForce(Vector2.up * 30f) ;
            bird.linearVelocity = Vector2.up * velocity;
            src.clip = bounce;
            src.Play();
    
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("you hit something");
        collide = true;
        string collided = collision.gameObject.tag;

        if(collided == "Wall"){
            collide = true;
            src.clip = fail;
            src.Play();
            // SceneManager.LoadScene("GameOver");
            Debug.Log("Game Over");
        }
    }
}
