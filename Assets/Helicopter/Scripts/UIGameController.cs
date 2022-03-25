using UnityEngine;
using System.Collections;


public class UIGameController : MonoBehaviour
{

    public GameObject RestartButton;
    public GameObject InfoButton;
    public GameObject InfoPanel;

    // Use this for initialization
    public static UIGameController runtime;

    private void Awake()
    {
        runtime = this;
    }

    void Start()
    {
        ShowInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ShowInfoPanel(bool isShow)
    {

        RestartButton.SetActive(!isShow);
        InfoButton.SetActive(!isShow);
        InfoPanel.SetActive(isShow);
    }

    public void ShowInfo()
    {
        ShowInfoPanel(true);
    }
    public void HideInfo()
    {
        ShowInfoPanel(false);
    }
}


