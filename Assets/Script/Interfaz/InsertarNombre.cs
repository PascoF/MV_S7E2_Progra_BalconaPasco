using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InsertarNombre : MonoBehaviour
{
    public TextMeshProUGUI nombr;
    public TextMeshProUGUI Advertencia;
    public static string nombreAlmacenar;

    public GameObject PrimeraFase;
    public GameObject SegundaFase;

    private Button executeButton;


    private void Update()
    {
        if (nombr.text.Length >= 3)
        {
            Advertencia.gameObject.SetActive(true);

            if (Input.GetKey(KeyCode.Return))
            {
                nombreAlmacenar = nombr.text;
                PrimeraFase.SetActive(false);
                SegundaFase.SetActive(true);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Return))
            {
                Advertencia.gameObject.SetActive(true);
            }
        }
    }
}
