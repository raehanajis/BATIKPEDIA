using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTN_Management : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject CreditPanel;
    public GameObject InfoPanel;
    public GameObject Batikmaduradesc;
    public GameObject Batik2;
    public GameObject Batik3;
    public GameObject Batik4;
    public GameObject Batik5;
    public GameObject Batik6;
    public GameObject BackArPanel;
    public GameObject GuidePanel;
    
    void Start()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        GuidePanel.SetActive(false);
    }


    public void ButtonClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(true);
        BackArPanel.SetActive(false);
    }
    public void Loadscene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void BackButton1Clicked()
    {
        MenuPanel.SetActive(true);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(false);
        GuidePanel.SetActive(false);
    }
    public void InfobuttoClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(true);
    }
    public void maduradesc()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(false);
        Batikmaduradesc.SetActive(true);
    }
    public void BackButton2Clicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(true);
        Batikmaduradesc.SetActive(false);
        Batik2.SetActive(false);
        Batik3.SetActive(false);
        Batik4.SetActive(false);
        Batik5.SetActive(false);
        Batik6.SetActive(false);
    }
    public void dressdesc()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(false);
        Batik2.SetActive(true);
    }
    public void bantaldesc()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(false);
        Batik3.SetActive(true);
    }
    public void topidesc()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(false);
        Batik4.SetActive(true);
    }
    public void gapuradesc()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(false);
        Batik5.SetActive(true);
    }
    public void tasdesc()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        InfoPanel.SetActive(false);
        Batik6.SetActive(true);
    }
    public void InfoClicked()
    {
        MenuPanel.SetActive(false);
        CreditPanel.SetActive(false);
        GuidePanel.SetActive(true);
    }
    public void Quit_Clicked()
    {
        Application.Quit();
    }
}
