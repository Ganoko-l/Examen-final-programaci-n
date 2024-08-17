using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDelEnemigo : MonoBehaviour, IRecibirDa�o
{
    public float vida = 50f;
    public delegate void EnemigoDestruido();
    public event EnemigoDestruido DestruirEnemigo;


    public void RecibirDa�o(float da�o)
    {
        vida = vida - da�o;
        if (vida == 0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (DestruirEnemigo != null)
        {
            DestruirEnemigo();
        }
    }
}
