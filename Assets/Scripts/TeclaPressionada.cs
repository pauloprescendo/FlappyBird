using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeclaPressionada : MonoBehaviour
{
    [SerializeField]
    private UnityEvent aoPressionarTecla;
    [SerializeField]
    private KeyCode tecla;

    private void Update()
    {
        if (Input.GetKeyDown(this.tecla))
        {
            this.aoPressionarTecla.Invoke();
        }
    }
}
