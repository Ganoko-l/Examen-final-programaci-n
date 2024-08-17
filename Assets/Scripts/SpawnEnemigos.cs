using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemigos : MonoBehaviour
{
    public GameObject prefabEnemigo;         
    public Transform[] puntosSpawn;
    public float intervalo = 5f;
    public int enemigosMaximos = 20;

    private float tiempo;
    private int enemigoActuales = 0;

    void Start()
    {
        tiempo = intervalo;
    }

    void Update()
    {
        tiempo -= Time.deltaTime;

        if (tiempo <= 0f && enemigoActuales < enemigosMaximos)
        {
            SpawnEnemigo();
            tiempo = intervalo;
        }
    }

    void SpawnEnemigo()
    {
        int spawnIndex = Random.Range(0, puntosSpawn.Length);
        Transform spawnPoint = puntosSpawn[spawnIndex];

        GameObject newEnemy = Instantiate(prefabEnemigo, spawnPoint.position, spawnPoint.rotation);
        newEnemy.GetComponent<VidaDelEnemigo>().DestruirEnemigo += EnemigoDestruido;

        enemigoActuales++;
    }

    void EnemigoDestruido()
    {
        enemigoActuales--;
    }
}
