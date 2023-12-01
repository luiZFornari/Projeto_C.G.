using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using StarterAssets;
using UnityEditor;



public class PortaAbrir : MonoBehaviour
{
    public Animator _animator;

    private bool _colidindo = false;
    [SerializeField] private TextMeshProUGUI CodeText;
    [SerializeField] private TextMeshProUGUI feedbackText; // Adicionando um campo para exibir feedback
    [SerializeField] private TextMeshProUGUI Pergunta; // Adicionando um campo para exibir feedback


    string codeTextValue = "";
    public GameObject CodePanel;
    public bool isVisible = false;
    public bool portaAberta = false;

    private int valueA;
    private int valueB;
    private int answer;

    private bool isWaitingForAnswer = false;

    void Start()
    {

    }

    void Update()
    {
        CodeText.text = codeTextValue;


        int userAnswer;
        bool isNumeric = int.TryParse(codeTextValue, out userAnswer);

        if (isNumeric && userAnswer == answer && isWaitingForAnswer)
        {
            _animator.SetTrigger("Abrir");
            CodePanel.SetActive(false);
            isVisible = false;
            feedbackText.text = "Correto! Porta aberta!";
            isWaitingForAnswer = false;
            portaAberta = true;

        }
        else if (isNumeric && userAnswer != answer && isWaitingForAnswer)
        {
            feedbackText.text = "Incorreto! Tente novamente.";
        }


        if (Input.GetKey(KeyCode.E) && _colidindo == true && !isWaitingForAnswer && portaAberta == false)
        {
            CodePanel.SetActive(true);
            isVisible = true;
            GenerateNewOperation(); // Gera uma nova operação quando a porta é acionada
            feedbackText.text = "Insira a resposta";
            isWaitingForAnswer = true;

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _colidindo = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _colidindo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _colidindo = false;
        CodePanel.SetActive(false);
        isVisible = false;
        feedbackText.text = "";
        isWaitingForAnswer = false;
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }

    public void Reset(string digit)
    {
        codeTextValue = "";
    }

    private void GenerateNewOperation()
    {
        valueA = Random.Range(1, 11);
        valueB = Random.Range(1, 11);
        answer = valueA * valueB;

        // Exibindo a operação na tela
        Pergunta.text = valueA.ToString() + " x " + valueB.ToString();
    }
}
