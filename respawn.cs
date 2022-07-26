using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        switch(hit.gameObject.tag)
        {
            case "SpeedBoost":
                speed = 25f;
                break;
            case "JumpPad":
                jumpHeight = 25f;
                break;
            case "Ground":
                jumpHeight = 3f;
                speed = 12f;
                break;
            case "dead":
                controller.enabled = false;
                controller.transform.position = spawnpoint.transform.position;
                controller.enabled = true;
                break;

        }   
       
        
    }
}
