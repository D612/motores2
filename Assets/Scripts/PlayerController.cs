using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Variavel para definir a velocidade de deslocamento do jogador
    public float moveSpeed = 20.0f;

    //Variavel pos vai receber posicao do player na cena em x, y e z
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;

        //Vai moviemntar na posição x, o input vai de -1 a 1, tanto para o eixo x quanto para o eixo z, e multipla pelo tempo
        //Os eixos horizontais e verticais já estão configurados no Input (Edit>Project Settting Input Manager > Axis
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.z += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.position = pos;
    }
}
