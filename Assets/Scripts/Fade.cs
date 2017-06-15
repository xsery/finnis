using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        FadeMe();

    }

    public void FadeMe()
    {
        StartCoroutine("DoFade");
    }

    IEnumerator DoFade()
    {
        yield return new WaitForSeconds(1);
        CanvasGroup canvasGroup = GetComponent<CanvasGroup>();
        while (canvasGroup.alpha > 0)
        {
            canvasGroup.alpha -= Time.deltaTime / 2;
            yield return null;
        }
        canvasGroup.interactable = false;
        yield return null;
    }
}
