using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public PlayerController pl;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            pl.isOnGround = true;
            //Debug.Log("Landed on the ground.");
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player") && !pl.isOnGround)
        {
            pl.isOnGround = true;
           // Debug.Log("Staying on the ground.");
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        pl.isOnGround = false;
       // Debug.Log("Walked off cliff.");
    }
}
