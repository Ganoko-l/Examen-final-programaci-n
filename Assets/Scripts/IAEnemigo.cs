using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAEnemigo : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject jugador;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        jugador = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        SeguirJugador();
    }

    void SeguirJugador()
    {
        agent.SetDestination(jugador.transform.position);
    }
}
