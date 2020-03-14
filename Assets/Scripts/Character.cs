using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public CharacterController control;
    public float vel = 6;
    public Vector3 moveDir = Vector3.zero;
    public float gravidade = 20;

    // Update is called once per frame
    void Update()
    {
        if (control.isGrounded) {
            //Recebendo os valores de entrada do jogador
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= vel;
        }
        //Simulando a gravidade dentro do jogo
        moveDir.y -= gravidade * Time.deltaTime;
        //Executando a função para realizar o movimento com base nos novos valores de entrada
        control.Move(moveDir * Time.deltaTime);
    }
}
