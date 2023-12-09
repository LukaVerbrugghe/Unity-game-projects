using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Vector3 forceRight;
    public Vector3 forceForward;

    private void FixedUpdate() {
        if (Input.GetKey(KeyCode.RightArrow)){
            GetComponent<Rigidbody>().velocity += forceRight;
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            GetComponent<Rigidbody>().velocity -= forceRight;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            GetComponent<Rigidbody>().velocity += forceForward;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            GetComponent <Rigidbody>().velocity -= forceForward;
        }
    }
}
