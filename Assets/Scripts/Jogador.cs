using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private Carrossel[] cenario;
    private GeradorObstaculos obstaculo;
    private Aviao aviao;
    private bool estouMorto;

    private void Start()
    {
        this.cenario = this.GetComponentsInChildren<Carrossel>();
        this.obstaculo = this.GetComponentInChildren<GeradorObstaculos>();
        this.aviao = this.GetComponentInChildren<Aviao>();
    }

    public void Desativar()
    {
        this.estouMorto = true;
        this.obstaculo.Parar();
        foreach(var carrosel in this.cenario)
        {
            carrosel.enabled = false;
        }
    }

    public void Ativar()
    {
        if (this.estouMorto)
        {
            this.aviao.Reiniciar();
            this.obstaculo.Recomecar();
            foreach(var carrosel in this.cenario)
            {
                carrosel.enabled = true;
            }
            this.estouMorto = false;
        }
    }
}
