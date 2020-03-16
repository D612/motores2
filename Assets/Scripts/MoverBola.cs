using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour
{
    public float moveForce;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * moveForce;
        transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(h, 0));
    }
}
