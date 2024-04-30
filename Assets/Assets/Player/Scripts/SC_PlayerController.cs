using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerController : MonoBehaviour
{
    #region VARIABLES
    [SerializeField]
    [Tooltip("Player view script reference")]
    private SC_PlayerView pl_view;

    [SerializeField]
    [Tooltip("Player model script reference")]
    private SC_PlayerModel pl_model;

    [SerializeField]
    [Tooltip("Player rigidbody component reference")]
    private Rigidbody2D pl_rb;

    private bool _moveLeft, _moveRight;
    private float _currentSpeed;

    #endregion

    #region FUNCTIONS

    void Update()
    {
        Animate();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        pl_rb.velocity = new Vector2(_currentSpeed, pl_rb.velocity.y);
    }

    private void Jump()
    {
        pl_rb.AddForce(Vector2.up * pl_model.GetJumpStrenght(), ForceMode2D.Impulse);
    }

    private void Animate()
    {
        pl_view.UpdateValues(pl_rb.velocity.x, pl_rb.velocity.y);
    }

    public void LeftPressed()
    {
        _currentSpeed = -pl_model.GetSpeed();
        pl_view.FlipSprite(true);
        _moveLeft = true;

    }

    public void RightPressed()
    {
        _currentSpeed = pl_model.GetSpeed();
        pl_view.FlipSprite(false);
        _moveRight = true;
    }

    public void LeftReleased()
    {
        _moveLeft = false;

        if (_moveRight)
        {
            pl_view.FlipSprite(false);
            _currentSpeed = pl_model.GetSpeed();
        }
        else
            _currentSpeed = 0;
    }

    public void RightReleased()
    {
        _moveRight = false;

        if (_moveLeft)
        {
            pl_view.FlipSprite(true);
            _currentSpeed = -pl_model.GetSpeed();
        }
        else
            _currentSpeed = 0;
    }

    public void JumpPressed()
    {
        JumpCheck();
    }

    private void JumpCheck()
    {
        if (RayCastProvider.provideRaycast(pl_model.GetJumpCheckerStartPoint().position, Vector2.down, pl_model.GetJumpCheckerLenght(), pl_model.GetJumpCheckerMask()))
            Jump();
    }
    #endregion
}