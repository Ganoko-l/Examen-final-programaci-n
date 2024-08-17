using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public float alcance = 3f;
    public LayerMask itemLayer;
    public InventarioManager inventario;
    public Camara cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TryPickupItem();
        }
    }

    void TryPickupItem()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;
        Debug.DrawRay(cam.transform.position, cam.transform.forward * alcance, Color.red, 1f);
        if (Physics.Raycast(ray, out hit, alcance, itemLayer))
        {
            Item item = hit.collider.GetComponent<Item>();
            if (item != null && item.keyItem != null)
            {
                inventario.Añadir(item.keyItem.itemNombre);
                Destroy(hit.collider.gameObject);
                Debug.Log("Has recogido: " + item.keyItem.itemNombre);
            }
        }

    }
}
