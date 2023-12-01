using UnityEngine;

public class ColisorEncerrarJogo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que colidiu possui a tag desejada (opcional)
        if (other.CompareTag("Player"))
        {
            // Chama a função para encerrar o jogo
            EncerrarJogo();
        }
    }

    private void EncerrarJogo()
    {
        Debug.Log("Jogo encerrado!"); // Adicione esta linha para debugar no console

        // Aqui você pode adicionar lógica adicional antes de encerrar o jogo, se necessário

        // Encerra o jogo
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}