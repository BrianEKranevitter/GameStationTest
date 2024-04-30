using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_GameManager : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The amount of lifes to start")]
    private int _lifes;

    [SerializeField]
    [Tooltip("UI manager reference")]
    private SCR_UIManager _uiManager;

    public void SubstractLife()
    {
        _lifes--;
        _uiManager.SubstractLife(_lifes);
    }

    public int GetLifes()
    {
        return _lifes;
    }
}