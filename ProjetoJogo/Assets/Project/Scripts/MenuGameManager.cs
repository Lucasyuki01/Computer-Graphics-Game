using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameManager : MonoBehaviour
{
    [SerializeField] private GameObject Objetivo1;
    [SerializeField] private GameObject Objetivo2;
    [SerializeField] private GameObject Objetivo3;
    [SerializeField] private GameObject Final;

    public void Retornar(){
        Objetivo1.SetActive(false);
        Objetivo2.SetActive(false);
        Objetivo3.SetActive(false);
        Final.SetActive(false);
    }
}
