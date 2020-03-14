using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterController control;
    public Vector3 moveDir = Vector3.zero;
    public float vel = 6;
    public float gravidade = 20;

    // Update is called once per frame
    void Update()
    {
        // Verificar se o jogador esta no chão
        if (control.isGrounded) {
            //Recebendo os valores de entrada do jogador
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //Atribuindo a posição do jogador (local) com a nova direção no mundo (world0
            moveDir = transform.TransformDirection(moveDir);
            //Adiionando a velocidadedo movimento
            moveDir *= vel;
        }
        //Aplicando a gravidade durante o jogo
        moveDir.y -= gravidade * Time.deltaTime;
        //Executando a função para realizar o movimento com base nos novos valores de enrtada recebidos do vetor moveDir
        control.Move(moveDir * Time.deltaTime);
    }
}
