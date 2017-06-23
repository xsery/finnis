using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadNurse : MonoBehaviour {

    public GameObject blood;
    public ContagemSangue contagemSangue;
    public string nome;
    public GameObject nurse;
    public ConclusaoDeFase fase;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.name == nome)
        {
            blood.SetActive(true);
            fase.parte1OK();
            contagemSangue.iniciaContagem();
            Destroy(nurse);
        }
    }
}
