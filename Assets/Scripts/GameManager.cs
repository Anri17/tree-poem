using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject poemUI;
    public Text authorName;
    public Text authorClassNumber;
    public Text authorClass;
    public Text poem;

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

    public void ShowPoemInformation(Poem poem)
    {
        ShowPoemUI();
        authorName.text = poem.authorName;
        authorClassNumber.text = poem.authorClassNumber;
        authorClass.text = poem.authorClass;
        this.poem.text = poem.poemText;
    }
}
