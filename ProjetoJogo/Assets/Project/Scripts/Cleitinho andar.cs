using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cleitinhoandar : MonoBehaviour
{
    private Animator animator;
    public Button botao;
    private bool andar = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        botao.onClick.AddListener(onClickEvent);
    }

    // Update is called once per frame
    void Update()
    {
        if (andar)
        {
            transform.Translate(new Vector3(0, 0, 1 * Time.deltaTime));
            animator.SetBool("andar", true);
        }
        else
        {
            transform.Translate(new Vector3(0, 0, 0 * Time.deltaTime));
            animator.SetBool("andar", false);
        }
        


    }
    void onClickEvent()
    {   
        andar = !andar;
    }
    
}
