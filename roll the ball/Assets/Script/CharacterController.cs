using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Vector3 force;

    private void FixedUpdate() {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().velocity += force;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().velocity -= force;
        }
    }
}
