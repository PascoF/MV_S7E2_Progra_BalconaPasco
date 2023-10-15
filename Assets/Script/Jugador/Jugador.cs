using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField]
    private float Vida;
    [SerializeField]
    private float Destreza;
    [SerializeField]
    private float Fuerza;

    public GameObject Perdida;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.Vida <= 0f)
        {
            Perdida.SetActive(true);
        }
    }
}
