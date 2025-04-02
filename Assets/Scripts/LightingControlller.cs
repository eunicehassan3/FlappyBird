using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightingControlller : MonoBehaviour
{
    public GameObject birdSpotLight;
    private int score; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = NewMonoBehaviourScript.score;
    }

    // Update is called once per frame
    void Update()
    {
        score = NewMonoBehaviourScript.score;
        if(score > 1000 && score <= 2000){
            Light2D mainLight = gameObject.GetComponent<Light2D>();
            // mainLight.color = new Color(0,0,0);
            birdSpotLight.SetActive(true);
        }

        else{
            birdSpotLight.SetActive(false);
        }
    }
}
