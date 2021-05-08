using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    [SerializeField]
    private float tempoParaGerarFacil;
    [SerializeField]
    private float tempoParaGerarDificil;
    private float cronometro;
    [SerializeField]
    private GameObject ManualDeInstrucoes;
    private ControleDeDificuldade controleDeDificuldade;
    private bool parado;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerarFacil;
    }

    private void Start()
    {
        this.controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }

    public void Recomecar()
    {
        this.parado = false;
    }

    private void Update()
    {
        if (this.parado) return;

        this.cronometro -= Time.deltaTime;

        if (this.cronometro < 0)
        {
            GameObject.Instantiate(this.ManualDeInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = Mathf.Lerp(this.tempoParaGerarFacil,
                                         this.tempoParaGerarFacil,
                                         this.controleDeDificuldade.Dificuldade);
        }
    }

    public void Parar()
    {
        this.parado = true;
    }
}
