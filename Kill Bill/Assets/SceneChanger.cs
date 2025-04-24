using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoSceneChanger : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Drag your VideoPlayer here in the inspector
    public string sceneToLoad; // Name of the scene you want to load after video ends

    void Start()
    {
        if (videoPlayer == null)
            videoPlayer = GetComponent<VideoPlayer>();

        videoPlayer.loopPointReached += OnVideoEnd; // Event when video finishes
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
