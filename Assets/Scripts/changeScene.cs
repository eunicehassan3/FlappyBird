using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void goToGame(){
        SceneManager.LoadScene("MainGame");
    }
}
