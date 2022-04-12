using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evaluacion : MonoBehaviour
{
    // Start is called before the first frame update
    public string prod1;
    public string prod2;
    public string prod3;
    public int precio1;
    public int precio2;
    public int precio3;
    public  int cant1;
    public int cant2;
    public int cant3;
    
    void Start()
    {
        int suma = precio1 + precio2 + precio3;
        int pdesc;
        int desc = ((suma / 100) * 20);
        pdesc = suma - ((suma / 100) * 20);
        if ( precio1 < 0 || precio2 < 0 || precio3 < 0 || cant1 <0 || cant2 <0 || cant3 < 0)
        {
            Debug.Log(" error: no se puede ingresar valores menos a cero ");
        }

        if( cant1 > 3 || cant2 > 3 || cant3 > 3)
        {
            Debug.Log(" se te aplicara el descuento");
        }
        Debug.Log(" monto total sin descuento es igual a $ " + suma + ",el precio descontado es igual a $" + desc + "y el precio final con descuento es igual a $" + pdesc);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
