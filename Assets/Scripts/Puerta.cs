using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public enum Requisito
    {
        None,
        Llave,
        Tarjeta,
        Bateria,
        Engranaje,
        Explosivo
    }

    public Requisito requiredItem = Requisito.None;
    public bool estaAbierta = false;

    public void IntentarAbrir(InventarioManager inventario)
    {
        if (requiredItem == Requisito.None || inventario.SeTieneItem(requiredItem.ToString()))
        {
            Abrir();
        }
    }

    void Abrir()
    {
        if (!estaAbierta)
        {
            estaAbierta = true;
            Destroy(gameObject);
        }
    }
}
