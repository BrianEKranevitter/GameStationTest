using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_ButtonManager : MonoBehaviour
{
    #region VARIABLES
    [SerializeField]
    [Tooltip("Player controller component reference")]
    private SC_PlayerController _playerController;
    #endregion

    public void LeftButtonPressed()
    {
        _playerController.LeftPressed();
    }

    public void LeftButtonReleased()
    {
        _playerController.LeftReleased();
    }

    public void RightButtonPressed()
    {
        _playerController.RightPressed();
    }

    public void RightButtonReleased()
    {
        _playerController.RightReleased();
    }

    public void JumpButtonPressed()
    {
        _playerController.JumpPressed();
    }
}