using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float velocity = 3.0f;
    public Rigidbody2D bird; 
    public AudioSource src;
    public AudioClip bounce;
    public AudioClip fail;
    public bool collide;
    public ParticleSystem crashParticle;
    public ParticleSystem boostParticle;
    public float forwardSpeed = 10.0f;
    public static int score = 0;

    private Animation animation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        collide = false;
        animation = GetComponent<Animation>();
    }

    // Update is called once per frame
    public void Update()
    {
        
        if(Input.GetMouseButtonDown(0)){
            score += 20;
            // bird.linearVelocity = Vector2.zero;
 
            // bird.AddForce(Vector2.up * 30f) ;
            bird.linearVelocity = Vector2.up * velocity;
            src.clip = bounce;
           
            src.Play();
    
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            // bird.AddForce(transform.forward, ForceMode2D.Impulse);
            transform.position += transform.forward * forwardSpeed * Time.deltaTime;
            bird.linearVelocity += Vector2.right * forwardSpeed; 
            boostParticle = Instantiate(boostParticle,transform.position, Quaternion.identity);
            
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
            crashParticle = Instantiate(crashParticle,transform.position, Quaternion.identity);
            crashParticle.Play();
            src.Play();
            // SceneManager.LoadScene("GameOver");
            Debug.Log("Game Over");
        }
    }


    
    
}
