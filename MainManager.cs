using UnityEngine;
using UnityEngine.Video;

public class MainManager : MonoBehaviour {

    public VideoPlayer vid;

    public GameObject playButton, pauseButton;

    public GameObject mainCanvas;

    // Use this for initialization
    void Start () {
        HideUI();
    }

    public void HideUI()
    {
        mainCanvas.SetActive(false);
    }

    public void DisplayUI()
    {
        mainCanvas.SetActive(true);
    }

    public void Play()
    {
        vid.Play();
        playButton.SetActive(false);
        pauseButton.SetActive(true);
    }
	
    public void Pause()
    {
        vid.Pause();
        pauseButton.SetActive(false);
        playButton.SetActive(true);
    }

    public void Replay()
    {
        vid.Stop();
        vid.Play();
    }

    public void Disable() {
        pauseButton.SetActive(false);
        playButton.SetActive(true);
        mainCanvas.SetActive(false);
        vid.Stop();
    }
}
