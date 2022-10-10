using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriaMoeda : MonoBehaviour
{
    public GameObject moeda;
    
    // Start is called before the first frame update
    void Start()
    {
        CriaCircunferencia();
        CriaVertical();
        
    }
    void CriaCirculo(){
        float y;
        for (float x = -10f; x < 10f; x+= 0.9f)
        {            
                // circulo
                y = 0.0f*x+-2.4f;
                Instantiate(moeda, new Vector3(y,x,-2), Quaternion.identity);
        }
    }
    void CriaVertical(){
            float y;
            for (float x =0f; x < 0f; x+=0f)
            {            
                    // circulo
                    y = 0.0f*x+-1.2f;
                    Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
            }
        }

    void CriaParabola(){
        float y;

        for (float x = -10; x < 10; x+=0.9f)
        {
            
                // parábola
                y = (float)(-0.1*x*x+2*x+0);
            
                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
            
        }
    }
    void CriaCircunferencia(){
        float y,x;
        float raio = 2.5f;

        for (double teta = 0; teta <  Math.PI; teta+=0.3)
        {
            
                //circunferência
                x = (float)(raio*Math.Cos(teta));
                y = (float)(raio*Math.Sin(teta));

                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
