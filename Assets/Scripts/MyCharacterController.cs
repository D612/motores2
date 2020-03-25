using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacterController : MonoBehaviour
{
    //Referencia do CharacterController a ser considerado
    public CharacterController control;
    public Vector3 moveDir = Vector3.zero;
    public float vel = 6;
    public float gravidade = 10;

    // Update is called once per frame
    void Update()
    {
        //Verificar se o jogador esta no chão
        if (control.isGrounded) {
            //Recebendo os valores de entrada do movimento do jogador em X e Z
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //Atribuindo o transform do jogador com a nova direção
            moveDir = transform.TransformDirection(moveDir);
            //Adicionando a velocidade do movimento
            moveDir *= vel;
        }

        //Adicionando a gravidade durante o jogo no personagem
        moveDir.y -= gravidade * Time.deltaTime;
        //Execuntando a função para realizar o movimento com base nos novos valores de entrada recebidos do Input
        control.Move(moveDir * Time.deltaTime);
    }
}
