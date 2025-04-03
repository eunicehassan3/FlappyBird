using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightingControlller : MonoBehaviour
{
    public GameObject birdSpotLight;
    public GameObject backgroundImage;
    private int score; 
    private Light2D mainLight;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainLight = gameObject.GetComponent<Light2D>();
        score = NewMonoBehaviourScript.score;
    }

    // Update is called once per frame
    void Update()
    {
        score = NewMonoBehaviourScript.score;
        if(score > 1000 && score <= 2000){
            if(mainLight != null){
                mainLight.intensity = Mathf.Lerp(mainLight.intensity, 0.2f, Time.deltaTime * 2);
            }
            
            backgroundImage.SetActive(false);
            birdSpotLight.SetActive(true);
        }

        else{
            birdSpotLight.SetActive(false);
            backgroundImage.SetActive(true);
            mainLight.intensity = 1;
        }
    }
}
