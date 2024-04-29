using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerModel : MonoBehaviour
{
    [SerializeField][Tooltip("Player jumping strenght.")]

    private float pl_speed;

    public float GetSpeed()
    {
        return pl_speed;
    }

    [SerializeField]
    [Tooltip("Player jumping strenght.")]
    private float pl_jumpStrenght;

    public float GetJumpStrenght()
    {
        return pl_jumpStrenght;
    }

    [SerializeField]
    [Tooltip("Player ground checker lenght.")]
    private float pl_jumpCheckerLenght;

    public float GetJumpCheckerLenght()
    {
        return pl_jumpCheckerLenght;
    }

    [SerializeField]
    [Tooltip("Player ground checker layer mask.")]
    private LayerMask pl_jumpCheckerMask;

    public LayerMask GetJumpCheckerMask()
    {
        return pl_jumpCheckerMask;
    }

    [SerializeField]
    [Tooltip("Player ground checker layer mask.")]
    private Transform pl_jumpCheckerStartPoint;

    public Transform GetJumpCheckerStartPoint()
    {
        return pl_jumpCheckerStartPoint;
    }
}