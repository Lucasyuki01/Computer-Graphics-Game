using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuGameManager : MonoBehaviour
{
    [SerializeField] private GameObject Objetivo1;
    [SerializeField] private GameObject Objetivo2;
    [SerializeField] private GameObject Objetivo3;
    [SerializeField] private GameObject Final;
    public GameObject menuPrincipal, controles;
    public Button sair, controlesEsc, sairControles, recomecar;
    private bool menuEsc = true;

    public void Retornar(){
        Objetivo1.SetActive(false);
        Objetivo2.SetActive(false);
        Objetivo3.SetActive(false);
        Final.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuPrincipal.SetActive(menuEsc);
            menuEsc = !menuEsc;
        }
        sair.onClick.AddListener(SairParaMenu);
        controlesEsc.onClick.AddListener(AbrirMenuControles);
        sairControles.onClick.AddListener (FecharMenuControles);
        recomecar.onClick.AddListener(SairParaMenu);
       
    }
    private void SairParaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    private void AbrirMenuControles()
    {
        controles.SetActive(true);
    }
    private void FecharMenuControles()
    {
        controles.SetActive(false);
    }
    
}
