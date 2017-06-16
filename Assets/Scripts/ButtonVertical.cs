using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVertical : MonoBehaviour {

    public ButtonVertical button;
    public Plataform finnis;

    public bool isLeft;
    public bool ButtonLeft;
    public bool pisouPlataform;

    public Transform Finnis;
    public Transform Plataform;
    public Transform ButonLeft;
    public Transform ButtonRight;

    public float movimento;
    public float tempoEspera;

    public int quantidadeMovimento;
    

    // Use this for initialization
    void Start()
    {
        isLeft = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (ButtonLeft && isLeft)
        {
            StartCoroutine("actionButton");
            isLeft = false;
            button.isLeft = isLeft;
        }
        else
        {
            if (!ButtonLeft && !isLeft)
            {
                StartCoroutine("actionButton");
                isLeft = true;
                button.isLeft = isLeft;
            }
        }

    }

    IEnumerator actionButton()
    {
        int cont;
        for (cont = 0; cont < quantidadeMovimento; cont++)
        {
            if(finnis.pisouPlataform){
                Finnis.position = new Vector3(Finnis.position.x + movimento, Finnis.position.y);
            }
            Plataform.position = new Vector3(Plataform.position.x + movimento, Plataform.position.y);
            ButonLeft.position = new Vector3(ButonLeft.position.x + movimento, ButonLeft.position.y);
            ButtonRight.position = new Vector3(ButtonRight.position.x + movimento, ButtonRight.position.y);
            yield return new WaitForSeconds(tempoEspera);
        }
    }
}
