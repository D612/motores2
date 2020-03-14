using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    //Velocidade do movimento de deslocamento da camera para o alvo
    public float moveSpeed;

    //Alvo que a camera vai seguir
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (target != null) {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * moveSpeed);        
        }
    }
}
