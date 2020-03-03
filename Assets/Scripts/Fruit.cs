using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Poem poem;
    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
    }

    void OnMouseDown()
    {
        gameManager.ShowPoem(poem);
        Debug.Log("Mouse pressed");
    }


}
