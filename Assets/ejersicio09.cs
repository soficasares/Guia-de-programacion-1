using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejersicio09 : MonoBehaviour
{
    public string nombre1;
    public string nombre2;
    public string nombre3;  

    public float capital1;
    public float capital2;
    public float capital3;

    float capitaltotal;
    float porc1;
    float porc2;
    float porc3;
    //porc = porcentaje

    // Start is called before the first frame update
    void Start()
    {
        porc1 = capital1 / capitaltotal * 100;
        porc2 = capital2 / capitaltotal * 100;
        porc3 = capital3 / capitaltotal * 100;
        Debug.Log("Nombre: " + nombre1 + "capital aportado: $" + capital1 + "Porcentaje del capital: %" + porc1 + "Monto total aportado:" +capitaltotal);
        Debug.Log("Nombre: " + nombre2 + "capital aportado: $" + capital2 + "Porcentaje del capital: %" + porc2 + "Monto total aportado:" + capitaltotal);
        Debug.Log("Nombre: " + nombre3 + "capital aportado: $" + capital3 + "Porcentaje del capital: %" + porc3 + "Monto total aportado:" + capitaltotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
