using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public string sceneToLoad;

    public void OnPlayButton()
    {
        SceneManager.LoadScene(sceneToLoad);
    }   
    public void OnExitButton()
    {
        Application.Quit();
    }
}
