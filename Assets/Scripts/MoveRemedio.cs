using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRemedio : MonoBehaviour
{

    public Transform remedio;
    public bool funcionou;

    // Use this for initialization
    void Start()
    {
        funcionou = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (!funcionou)
        {
            float cont;
            for (cont = remedio.position.x; cont > -6.08f; cont = cont - 0.01f)
            {
                StartCoroutine("cano");
            }

            remedio.position = new Vector3(6.09f, 3.54f);

            for (cont = remedio.position.x; cont > 4.71f; cont = cont - 0.01f)
            {
                StartCoroutine("cano");
            }
            funcionou = true;
        }
    }

    IEnumerator cano()
    {
        remedio.position = new Vector3(remedio.position.x - 0.01f, remedio.position.y);
        yield return new WaitForSeconds(0.1f);
    }
}