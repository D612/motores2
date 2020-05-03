using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBola : MonoBehaviour
{
    public float moveForce;
    private float direction;

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Horizontal") * moveForce;
        transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(direction, 0));

    }

}
