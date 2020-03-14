using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variavel pos vai receber posição do player na cena em x, y z
    private Vector3 pos;

    //Variavel para definir a velicdade que o player vai se movimentar
    public float moveSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
        // A variavel pos vai receber a posição x, y e  do component transform que esta lá na capsula
        pos = transform.position;

        // Vai movimentar na posição x, o Input vai de -1 a 1, tanto para o eixo x quanto para o eixo z, e multiplica pelo tempo
        //Os eixos horital e vertical já estão configrados no Input Manager do Unity
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += moveSpeed * Input.GetAxis("Vertical") *  Time.deltaTime;

        transform.position = pos;
    }
}
