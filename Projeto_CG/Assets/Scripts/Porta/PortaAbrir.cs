using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaAbrir : MonoBehaviour
{
    public Animator _animator;
    public int valorMinimo = 1;
    public int valorMaximo = 10;

    private bool _colidindo;
    private bool portaAberta = false;
    private int respostaCorreta;

    void Start()
    {
        // Gerar aleatoriamente um número para o cálculo
        int numero1 = Random.Range(valorMinimo, valorMaximo);
        int numero2 = Random.Range(valorMinimo, valorMaximo);
        respostaCorreta = numero1 + numero2;

        Debug.Log("Calcule: " + numero1 + " + " + numero2);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _colidindo)
        {
            // Verificar se a resposta do jogador está correta
            int respostaJogador = CalcularRespostaDoJogador();
            if (respostaCorreta == respostaJogador)
            {
                portaAberta = true;
                _animator.SetTrigger("PortaAbrirAnimacao");
            }
            else
            {
                Debug.Log("Resposta incorreta. Tente novamente!");
            }
        }
    }

    int CalcularRespostaDoJogador()
    {
        int resposta = 0;

        // Obtendo a entrada do jogador
        // Neste exemplo, estou lendo a entrada do teclado (pode ser uma interface gráfica ou outra forma de entrada)
        // Aqui, o jogador precisa digitar um número e pressionar Enter para submeter a resposta
        string input = Input.inputString;

        if (input.Length > 0 && input[input.Length - 1] == '\n')
        {
            input = input.Substring(0, input.Length - 1); // Remover o caractere de nova linha (\n)
            int.TryParse(input, out resposta); // Converter a string para um número inteiro
        }

        return resposta;
    }

    void OnTriggerEnter(Collider _col)
    {
        if (_col.gameObject.CompareTag("Player"))
        {
            _colidindo = true;
        }
    }

    void OnTriggerExit(Collider _col)
    {
        if (_col.gameObject.CompareTag("Player"))
        {
            _colidindo = false;
        }
    }
}
