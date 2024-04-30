using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCR_UIManager : MonoBehaviour
{
    [SerializeField]
    GameObject _pausePanel;

    [SerializeField]
    Image[] _lifeIcons;

    public void PauseMenu()
    {
        _pausePanel.SetActive(true);
    }

    public void ResumeMenu()
    {
        _pausePanel.SetActive(false);
    }

    public void SubstractLife(int lifeToTurnOff)
    {
        _lifeIcons[lifeToTurnOff].enabled = false;
    }
}