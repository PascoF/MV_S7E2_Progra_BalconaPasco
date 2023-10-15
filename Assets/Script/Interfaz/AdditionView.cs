using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class AdditionView : MonoBehaviour
{
    private AdditionController controller;

    [SerializeField]
    private TMP_InputField inputFieldVida;

    [SerializeField]
    private TMP_InputField inputFieldDestreza;
    [SerializeField]
    private TMP_InputField inputFieldFuerza;
    [SerializeField]
    private TextMeshProUGUI TextoResultado;
    [SerializeField]
    private Button executeButton;

    [SerializeField]
    private TextMeshProUGUI Vida;
    [SerializeField]
    private TextMeshProUGUI Destreza;
    [SerializeField]
    private TextMeshProUGUI Fuerza;
    [SerializeField]
    private TextMeshProUGUI Poder;

    public GameObject TerceraFase, SegundaFase, Interfaz, PAD;

    public TextMeshProUGUI Advertencia;

    void Awake()
    {
        controller = new AdditionController();
        executeButton.onClick.AddListener(Execute);
    }

    void Execute()
    {
        controller.Execute(int.Parse(inputFieldVida.text), int.Parse(inputFieldDestreza.text), int.Parse(inputFieldFuerza.text), ShowResult);
        controller.Puntos(int.Parse(inputFieldVida.text), PuntosJugVID);
        controller.Puntos(int.Parse(inputFieldDestreza.text), PuntosJugDES);
        controller.Puntos(int.Parse(inputFieldFuerza.text), PuntosJugFUE);
    }



    void PuntosJugVID(int Puntos)
    {
        Vida.text = Puntos.ToString();

        if (Puntos <= 0)
        {
            PAD.SetActive(true);
        }

    }

    void PuntosJugDES(int Puntos)
    {

        Destreza.text = Puntos.ToString();
        if (Puntos <= 0)
        {
            PAD.SetActive(true);
        }

    }

    void PuntosJugFUE(int Puntos)
    {

        Fuerza.text = Puntos.ToString();

        if (Puntos <= 0)
        {
            PAD.SetActive(true);
        }

    }


    void ShowResult(int result)
    {
        TextoResultado.text = result.ToString();
        Poder.text = result.ToString();


        if (result <= 100)
        {
            Interfaz.SetActive(true);
            TerceraFase.SetActive(true);
            SegundaFase.SetActive(false);
        }
        else
        {
            Advertencia.gameObject.SetActive(true);
        }


    }

}
