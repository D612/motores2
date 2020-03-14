using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeguir : MonoBehaviour
{
    //Alvo que acamera vai seguir
    public GameObject target;

    //Velocidade do movimento de deslocamento da camera
    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        //Verificar se o alvo da camera existe, não foi destruido, para que
        if (target != null) {
            transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * moveSpeed);
        }
    }
}
