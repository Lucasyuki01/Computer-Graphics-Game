using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Objetivos : MonoBehaviour
{
    public GameObject objHospital, objMAC, objPadaria, CanvaHospital, CanvaMAC, CanvaFinal;
    public Light Hospital, mac, padaria;
    public TextMeshProUGUI txtObj;
    
    // Start is called before the first frame update
    void Start()
    {
        objMAC.GetComponent<BoxCollider>().enabled = false;
        objHospital.GetComponent<BoxCollider>().enabled = false;
        objMAC.GetComponent<MeshRenderer>().enabled = false;
        objHospital.GetComponent<MeshRenderer>().enabled = false;
        mac.enabled = false;
        Hospital.enabled = false;
        txtObj.text = "VÁ ATÉ A PADARIA";
        
        

    }
    public void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {

            case "Hospital":
                objHospital.GetComponent<MeshRenderer>().enabled = false;
                objHospital.GetComponent<BoxCollider>().enabled = false;
                Hospital.enabled = false;
                CanvaFinal.SetActive(true);
                txtObj.text = "";
                break;

            case "Padaria":
                txtObj.text = "VÁ ATÉ O MAC";
                objPadaria.GetComponent<BoxCollider>().enabled = false;
                objPadaria.GetComponent<MeshRenderer>().enabled = false;
                padaria.enabled = false;
                objMAC.GetComponent<MeshRenderer>().enabled = true;
                objMAC.GetComponent<BoxCollider>().enabled = true;
                mac.enabled = true;
                CanvaMAC.SetActive(true);
                break;
            case "Mac":
                txtObj.text = "VÁ ATÉ O HOSPITAL";
                objMAC.GetComponent<BoxCollider>().enabled = false;
                objMAC.GetComponent<MeshRenderer>().enabled = false;
                mac.enabled = false;
                objHospital.GetComponent<MeshRenderer>().enabled = true;
                objHospital.GetComponent<BoxCollider>().enabled = true;
                Hospital.enabled = true;
                break;

            default:
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
