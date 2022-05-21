using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour
{
    void HandleMovement()
    {
        if(isLocalPlayer)
        {
            float moveHorizontal = Input.GetAxis("Horizontal") * 0.1f;
            float moveVertical = Input.GetAxis("Vertical") * 0.1f;
            Vector3 Movement = new Vector3(moveHorizontal, moveVertical, 0);
            transform.position = transform.position + Movement;
        }
    }
    void Update()
    {
        HandleMovement();
    }
}
