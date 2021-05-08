using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiretorMultiplayer : Diretor
{
    private Jogador[] jogadores;
    private bool alguemMorto;
    private int pontosDesdeAMorte;

    protected override void Start()
    {
        base.Start();
        this.jogadores = GameObject.FindObjectsOfType<Jogador>();
    }

    public void Reviver()
    {
        if (this.alguemMorto)
        {
            this.pontosDesdeAMorte++;
            if (this.pontosDesdeAMorte >= 2)
            {
                this.ReviverJogadores();
            }
        }
    }

    public void AvisarQueAlguemMorreu()
    {
        this.alguemMorto = true;
        this.pontosDesdeAMorte = 0;
    }

    private void ReviverJogadores()
    {
        this.alguemMorto = false;
        foreach(var jogador in this.jogadores)
        {
            jogador.Ativar();
        }
    }
}
