using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mao : MonoBehaviour
{
    private SpriteRenderer imagem;

    private void Start()
    {
        this.imagem = this.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Desaparecer();
        }
    }

    private void Desaparecer()
    {
        this.imagem.enabled = false;
    }
}
