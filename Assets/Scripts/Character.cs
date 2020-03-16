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
        // Verificar se o jogador esta colidindo com algo
        if (control.isGrounded) {
            //Recebendo os valores de entrada do jogador
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //Atribuindo a posição do jogador (local) com a nova direção no mundo (world)

            //Você precisa entender a diferença entre o espaço local e o mundo.
            //Local space é para direções e rotações em relação ao objeto, e o world location é relativo ao mundo do jogo.
            //Essa função pega uma direção local de um objeto e encontra essa direção no espaço do mundo.
            //Exemplo: Vector3 (1,0,0) é o mesmo que a função Vector3.right (x está 1, ou seja, positivo, vai mover para a direita)
            //que no espaço local do objeto é a direção que aponta para a direita do objeto.
            //Dependendo de como o objeto é girado, a saída no espaço do mundo mudará.
            moveDir = transform.TransformDirection(moveDir);
            //Adiionando a velocidade do movimento
            moveDir *= vel;
        }
        //Aplicando a gravidade durante o jogo
        moveDir.y -= gravidade * Time.deltaTime;
        //Executando a função para realizar o movimento com base nos novos valores de enrtada recebidos do vetor moveDir
        control.Move(moveDir * Time.deltaTime);
    }
}
