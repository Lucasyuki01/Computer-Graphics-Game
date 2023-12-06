using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Semaforo : MonoBehaviour
   
{
    public Light luzVermelha;
    public Light luzVerde;
    public Light luzAmarela;
    private bool terminou_piscar;
    public BoxCollider colisorSemaforo;
    
    // Start is called before the first frame update
    void Start()
    {
        luzVermelha.enabled = false;
        luzVerde.enabled = false;
        luzAmarela.enabled = false;
        terminou_piscar = true;
    }

    // Update is called once per frame
    void Update()
    {   
        if (terminou_piscar)
        {   
            terminou_piscar = false;
            StartCoroutine(PiscarLuzVermelha());
        }
       
        
    }
    IEnumerator PiscarLuzVermelha()
    {
        colisorSemaforo.enabled = true;
        luzAmarela.enabled = false;
        luzVermelha.enabled = !luzVermelha.enabled;
        yield return new WaitForSeconds(15);
        StartCoroutine(PiscarLuzVerde());
    }
    IEnumerator PiscarLuzVerde()
    {   
        colisorSemaforo.enabled = false;
        luzVermelha.enabled = !luzVermelha.enabled;
        luzVerde.enabled = !luzVerde.enabled;
        yield return new WaitForSeconds(5);
        StartCoroutine(PiscarLuzAmarela());
    }
    IEnumerator PiscarLuzAmarela()
    {
        luzVerde.enabled = !luzVerde.enabled;
        luzAmarela.enabled = !luzAmarela.enabled;
        yield return new WaitForSeconds(3);
        terminou_piscar = true;
    }
}
