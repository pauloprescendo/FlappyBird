using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public int Pontos { get; private set; }
    [SerializeField]
    private Text textoPontuacao;
    private AudioSource audioPontuacao;
    [SerializeField]
    private UnityEvent aoPontuar;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        this.Pontos++;
        this.textoPontuacao.text = this.Pontos.ToString();
        this.audioPontuacao.Play();
        this.aoPontuar.Invoke();
    }

    public void Reiniciar()
    {
        this.Pontos = 0;
        this.textoPontuacao.text = this.Pontos.ToString();
    }

    public void SalvarRecorde()
    {
        int recordAtual = PlayerPrefs.GetInt("recorde");
        if (this.Pontos > recordAtual)
        {
            PlayerPrefs.SetInt("recorde", this.Pontos);
        }
    }
}
