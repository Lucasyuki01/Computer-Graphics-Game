using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleitinhoandar : MonoBehaviour
{
    private Animator animator;
    
    private bool ir = false;
    private bool voltar = false;
   
    private bool indo = false;
  
    Vector3 direcaoAndar = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        ir = true;
        indo = true;

    }

    // Update is called once per frame
    void Update()
    {   

        if (ir)
        {
            direcaoAndar.z = 0.01f;
            animator.SetBool("andar", true);
            StartCoroutine(CleitinhoAndar());
            ir = false;
        } 
        if (voltar)
        {
            direcaoAndar.z = 0.01f;
            animator.SetBool("andar", true);
            StartCoroutine(CleitinhoAndar());
            voltar = false;
        }
        transform.Translate(direcaoAndar);

    }
    IEnumerator CleitinhoAndar()
    {
        
        yield return new WaitForSeconds(8);
        direcaoAndar.z = 0;
        StartCoroutine(CleitinhoVirar());
        
        
    }
    IEnumerator CleitinhoVirar()
    {
        animator.SetBool("andar", false);
        transform.Rotate(0, 180, 0, Space.Self);
        yield return new WaitForSeconds(4);
        if (indo)
        {
            indo = false;
            voltar = true;
        }
        else
        {
            indo = true; 
            voltar = false;
            ir = true;
        }
    }
    
}
