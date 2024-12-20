using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int carrotsNeeded = 10; // Liczba marchewek potrzebnych do wygranej
    private int carrotsCollected = 0; // Licznik zebranych marchewek

    public int CarrotsCollected => carrotsCollected; // Właściwość do odczytu

    public void AddCarrot()
    {
        carrotsCollected++;
        Debug.Log("Marchewki zebrane: " + carrotsCollected + " / 10");
    }

    public void WinGame()
    {
        Debug.Log("Wygrana!"); // Tymczasowe debugowanie
        // Tu później dodamy logikę wyświetlania komunikatu o zwycięstwie
    }
}
