using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject canvasPlay;
    public GameObject canvasPrincipal;

    void Start()
    {
        // Al iniciar, solo muestra el Canvas play y oculta Canvas Principal
        ShowPlayCanvas();
    }

    public void ShowPlayCanvas()
    {
        canvasPlay.SetActive(true);
        canvasPrincipal.SetActive(false);
    }

    public void ShowPrincipalCanvas()
    {
        canvasPlay.SetActive(false);
        canvasPrincipal.SetActive(true);
    }
}
