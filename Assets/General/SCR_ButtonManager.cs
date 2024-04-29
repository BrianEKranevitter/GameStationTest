using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_ButtonManager : MonoBehaviour
{
    #region VARIABLES
    private static SCR_ButtonManager _instance;
    public static SCR_ButtonManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Game Manager is null");

            return _instance;
        }
    }

    private bool moveLeft, moveRight;

    [SerializeField][Tooltip("Player controller component reference")]
    private SC_PlayerController _playerController;
    #endregion

    private void Awake()
    {
        if (_instance != null)
            Destroy(gameObject);
        else
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    public void LeftButtonPressed()
    {
        moveLeft = true;
    }

    public void LeftButtonReleased()
    {
        moveLeft = false;
    }

    public void RightButtonPressed()
    {
        moveRight = true;
    }

    public void RightButtonReleased()
    {
        moveRight = false;
    }

    void PassToPlayer()
    {

    }
}