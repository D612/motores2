using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public CharacterController control;
    public float vel = 6;
    public Vector3 moveDir = Vector3.zero;
    public float gravidade = 20;
    public float velocidadeRotacao = 50.0f;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (control.isGrounded) {
            //Recebendo os valores de entrada do jogador
            moveDir = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= vel;
        }
        //Simulando a gravidade dentro do jogo
        moveDir.y -= gravidade * Time.deltaTime;
        //Executando a função para realizar o movimento com base nos novos valores de entrada
        control.Move(moveDir * Time.deltaTime);

        //rotação do jogador
        float rotacao = Input.GetAxis("Horizontal") * velocidadeRotacao;
        rotacao *= Time.deltaTime;
        transform.Rotate(0, rotacao, 0);

        //Animação
        if (control.isGrounded) {
            //Verificando se meu jogador esta andando
            if (moveDir.z != 0){
                //Animação Walk/Andando
                anim.SetBool("Parado", false);
                anim.SetBool("Andando", true);   
            }else {
                //Animação Idle/Parado
                anim.SetBool("Parado", true);
                anim.SetBool("Andando", false);
                anim.SetBool("AtaqueCurto1", false);
            }

            if (Input.GetKeyDown(KeyCode.Mouse0)) {
                anim.SetBool("AtaqueCurto1", true);
            }
        }
    }
}
