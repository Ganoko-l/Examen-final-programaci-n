using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDelEnemigo : MonoBehaviour, IRecibirDaño
{
    public float vida = 50f;
    public delegate void EnemigoDestruido();
    public event EnemigoDestruido DestruirEnemigo;


    public void RecibirDaño(float daño)
    {
        vida = vida - daño;
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
