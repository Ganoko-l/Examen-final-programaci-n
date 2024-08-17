using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : MonoBehaviour
{
    public float da�o = 10f;
    public float alcance = 100f;
    public Camera camaraDelJugador;
    public LayerMask layerEnemigo;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        RaycastHit hit;
        if (Physics.Raycast(camaraDelJugador.transform.position, camaraDelJugador.transform.forward, out hit, alcance, layerEnemigo))
        {
            Debug.DrawRay(camaraDelJugador.transform.position, camaraDelJugador.transform.forward * alcance, Color.green, 1f);
            IRecibirDa�o objetivoARecibirDa�o = hit.transform.GetComponent<IRecibirDa�o>();
            if (objetivoARecibirDa�o != null)
            {
                objetivoARecibirDa�o.RecibirDa�o(da�o);
            }
        }
    }
}
