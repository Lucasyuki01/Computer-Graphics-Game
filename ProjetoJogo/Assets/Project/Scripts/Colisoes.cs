using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Colisoes : MonoBehaviour
{
    
    int pontos = 100;
    
    public TextMeshProUGUI txtPontos;
    // Start is called before the first frame update

    public void Start(){
        
       
   }

    private void OnCollisionEnter(Collision collision){

      
   
        switch (collision.gameObject.tag)
        {

           
            default:
                pontos = pontos - 5;
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
                pontos = pontos - 5;
                break;

            case "SinalVerde":
                pontos = pontos + 2;
                break;

            case "SinalAmarelo":
                break;

            case "ColisorCalcada":
                print("Subiu na calçada");
                pontos = pontos -5;
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
