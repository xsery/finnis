using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaParado : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        StartCoroutine("action");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator action()
    {
        yield return new WaitForSeconds(5.0f);
        gameObject.SetActive(false);
    }
}