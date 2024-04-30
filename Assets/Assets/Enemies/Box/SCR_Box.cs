using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCR_Box : SCR_Spawnable
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IHittable hittedObject = collision.gameObject.GetComponent<IHittable>();

        if (hittedObject != null)
        {
            hittedObject.Hitted();
            Destroy(gameObject);
        }
        else if (collision.gameObject.layer == 6) //If box hitted floor
        {
            Destroy(gameObject);
        }
    }
}