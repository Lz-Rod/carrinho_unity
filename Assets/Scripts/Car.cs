using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    //variáveis
    private Rigidbody CarRig;
    public int Speed;
    public float RotSpeed;

    // Start is called before the first frame update
    void Start()
    {
        CarRig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Aqui faz o carrinho se movimentar para frente ao pressionar a tecla W
        if (Input.GetKey(KeyCode.W))
        {
            CarRig.AddForce(transform.forward * Speed * Time.deltaTime, ForceMode.Impulse);
        }

        //Aqui faz o carrinho se movimentar para trás ao pressionar a tecla S
        if (Input.GetKey(KeyCode.S))
        {
            CarRig.AddForce(transform.forward * -Speed * Time.deltaTime, ForceMode.Impulse);
        }

        //Aqui faz o carrinho virar para a esquerda ao pressionar a tecla A
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -RotSpeed, 0);
        }

        //Aqui faz o carrinho virar para a direita ao pressionar a tecla D
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, RotSpeed, 0);
        }
        
    }
}
