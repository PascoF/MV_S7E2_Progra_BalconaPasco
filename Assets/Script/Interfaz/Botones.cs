using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public GameObject PrimeraFase, Perdida;

    public void Reiniciar()
    {
        Perdida.SetActive(false);
        PrimeraFase.SetActive(true);
    }
}
