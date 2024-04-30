using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerView : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Animator component reference")]
    private Animator _anim;

    [SerializeField]
    [Tooltip("Sprite renderer component reference")]
    private SpriteRenderer _sr;

    public void UpdateValues(float xSpeed, float ySpeed)
    {
        _anim.SetInteger("XSpeed", Mathf.RoundToInt(xSpeed));
        _anim.SetFloat("YSpeed", ySpeed);
    }

    public void FlipSprite(bool value)
    {
        _sr.flipX = value;
    }

    public void DeathAnimation()
    {
        _anim.SetTrigger("Death");
    }
}