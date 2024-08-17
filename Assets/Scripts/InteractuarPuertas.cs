using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarPuertas : MonoBehaviour
{
    public float alcance = 3f;
    public LayerMask puertaLayer;
    public InventarioManager inventario;
    public Camara cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IntentarInteraccion();
        }
    }

    void IntentarInteraccion()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, alcance, puertaLayer))
        {
            Puerta puerta = hit.collider.GetComponent<Puerta>();
            if (puerta != null)
            {
                puerta.IntentarAbrir(inventario);
            }
        }
    }
}
