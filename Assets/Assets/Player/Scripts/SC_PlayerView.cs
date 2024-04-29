using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerView : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Animator component reference")]
    private Animator _anim;
    
    public void UpdateValues(float xSpeed, float ySpeed)
    {
        _anim.SetFloat("XSpeed", xSpeed);
        _anim.SetFloat("YSpeed", ySpeed);
    }
}