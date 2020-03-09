using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject poemUI;
    public Image authorImage;
    public Text authorName;
    public Text poem;
    public AudioSource poemAudio;

    public Button playButton;
    public Button stopButton;
    public Slider volumeSlider;

    public bool poemListShowing = false;

    public Animator listAnimator;

    void Awake()
    {
        MakeSingleton();
        HidePoemUI();
    }

    void MakeSingleton()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowPoemUI() => poemUI.SetActive(true);
    public void HidePoemUI() => poemUI.SetActive(false);

    public void ShowPoem(Poem poem)
    {
        ShowPoemUI();
        authorName.text = poem.authorName;
        this.poem.text = poem.poemText;
        poemAudio.clip = poem.poemVoice;
        authorImage.sprite = poem.authorPhoto;
        if (poemAudio.clip == null)
        {
            playButton.interactable = false;
            stopButton.interactable = false;
        }
        else
        {
            playButton.interactable = true;
            stopButton.interactable = true;
        }
    }

    public void ClosePoem()
    {
        HidePoemUI();
        StopPoem();
        poemAudio.clip = null;
    }

    public void PlayPoem()
    {
        if (poemAudio.clip != null)
        {
            poemAudio.Play();
        }
    }

    public void StopPoem()
    {
        if (poemAudio.clip != null)
        {
            poemAudio.Stop();
        }
    }

    public void ChangeAudioVolume()
    {
        poemAudio.volume = volumeSlider.value;  
    }

    public void TogglePoemList()
    {
        if (listAnimator.GetBool("listShown"))
        {
            listAnimator.SetBool("listShown", false);
        }
        else if (!listAnimator.GetBool("listShown"))
        {
            listAnimator.SetBool("listShown", true);
        }
    }
}
