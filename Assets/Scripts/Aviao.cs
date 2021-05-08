using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    private bool deveImpulsionar;
    private Animator animacao;

    [SerializeField]
    private float forca;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;
        this.animacao = this.GetComponent<Animator>();
    }

    private void Start()
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.deveImpulsionar = true;
        }
        this.animacao.SetFloat("VelocidadeY", this.fisica.velocity.y);
    }

    private void FixedUpdate()
    {
        if (this.deveImpulsionar)
        {
            this.Impulsionar();
        }
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
        this.deveImpulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
