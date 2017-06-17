using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHorizontal : MonoBehaviour {

    public ButtonHorizontal button;
    public Plataform finnis;

    public bool isCima;
    public bool ButtonCima;
    public bool pisouPlataform;

    public Transform Finnis;
    public Transform Plataform;
    public Transform ButonCima;
    public Transform ButtonBaixo;

    public float movimento;
    public float tempoEspera;

    public int quantidadeMovimento;


    // Use this for initialization
    void Start()
    {
        isCima = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (ButtonCima && isCima)
        {
            StartCoroutine("actionButton");
            isCima = false;
            button.isCima = isCima;
        }
        else
        {
            if (!ButtonCima && !isCima)
            {
                StartCoroutine("actionButton");
                isCima = true;
                button.isCima = isCima;
            }
        }

    }

    IEnumerator actionButton()
    {
        int cont;
        for (cont = 0; cont < quantidadeMovimento; cont++)
        {
            if (finnis.pisouPlataform)
            {
                Finnis.position = new Vector3(Finnis.position.x, Finnis.position.y + movimento);
            }
            Plataform.position = new Vector3(Plataform.position.x, Plataform.position.y + movimento);
            ButonCima.position = new Vector3(ButonCima.position.x, ButonCima.position.y + movimento);
            ButtonBaixo.position = new Vector3(ButtonBaixo.position.x, ButtonBaixo.position.y + movimento);
            yield return new WaitForSeconds(tempoEspera);
        }
    }
}
