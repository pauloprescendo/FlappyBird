using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceCanvasInativo : MonoBehaviour
{
    [SerializeField]
    private GameObject fundo;
    private Canvas canvas;
    [SerializeField]
    private Text texto;

    private void Awake()
    {
        this.canvas = this.GetComponent<Canvas>();
    }

    public void Mostrar(Camera camera)
    {
        this.fundo.SetActive(true);
        this.canvas.worldCamera = camera;
    }

    public void AtualizarTexto(int pontosParaReviver)
    {
        this.texto.text = pontosParaReviver.ToString();
    }

    public void Sumir()
    {
        this.fundo.SetActive(false);
    }
}
