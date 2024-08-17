using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioManager : MonoBehaviour
{
    private List<string> items = new List<string>();

    public void Añadir(string itemName)
    {
        items.Add(itemName);
    }

    public bool SeTieneItem(string itemName)
    {
        return items.Contains(itemName);
    }
}
