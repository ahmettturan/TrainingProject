using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Dersleri : MonoBehaviour
{
    private void Start() 
    {
        Vector3 vektor = transform.position;
        float uzunluk = vektor.magnitude;
        Debug.Log(uzunluk);     
    }

   

    
}



//  public  void OncekiMethod()
//  {
//   //Start is called before the first frame update
//      void Start()
//   {
        
//   }

// // Update is called once per frame
//      void Update()
//      {
//         transform.Translate(Vector3.one * Time.deltaTime);
//      }
//  }