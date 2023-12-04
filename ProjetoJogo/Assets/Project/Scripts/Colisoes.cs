using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Colisoes : MonoBehaviour
{
    int pontos = 100;
    [Header("UI")]
    public TextMeshProUGUI txtPontos;
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision collision){

      
   
        switch (collision.gameObject.tag)
        {

           
            default:
                print("Bateu em alguma coisa");
                break;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {

            case "SinalVermelho":
                print("Passou no sinal vermelho");
                pontos = pontos - 1;
                break;
            default:
                
                break;
        }
    }
    public void Update()
    {
        txtPontos.text = "Pontos: " + pontos;
    }
}
