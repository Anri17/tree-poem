using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameManager gameManager;

    void OnMouseDown()
    {
        gameManager.TogglePoemList();
    }
}
