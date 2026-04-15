using UnityEngine;

public class Apuesta : MonoBehaviour
{
    int apuesta = 0;
    int dinero = 100; // dinero inicial
    bool partidaActiva = false;

    // Obtener apuesta
    public int GetApuesta()
    {
        return apuesta;
    }

    // Obtener dinero
    public int GetDinero()
    {
        return dinero;
    }

    // Incrementar apuesta
    public void IncrementarApuesta(int valor)
    {
        if (partidaActiva) return;

        if (dinero >= valor)
        {
            apuesta += valor;
            dinero -= valor;
            Debug.Log("Apuesta: " + apuesta + " | Dinero: " + dinero);
        }
        else
        {
            Debug.Log("❌ No tienes suficiente dinero");
        }
    }

    // Disminuir apuesta
    public void DecrementarApuesta(int valor)
    {
        if (partidaActiva) return;

        if (apuesta >= valor)
        {
            apuesta -= valor;
            dinero += valor;
            Debug.Log("Apuesta: " + apuesta + " | Dinero: " + dinero);
        }
    }

    // Empezar partida
    public void EmpezarPartida()
    {
        if (apuesta <= 0)
        {
            Debug.Log("⚠️ Debes apostar algo antes de jugar");
            return;
        }

        partidaActiva = true;
        Debug.Log("🎲 Partida iniciada con apuesta: " + apuesta);
    }

    // Ganar
    public void Ganar()
    {
        dinero += apuesta * 2;
        Debug.Log("🏆 Ganaste! Dinero: " + dinero);
        Reiniciar();
    }

    // Perder
    public void Perder()
    {
        Debug.Log("😢 Perdiste. Dinero: " + dinero);
        Reiniciar();
    }

    // Empate
    public void Empatar()
    {
        dinero += apuesta;
        Debug.Log("🤝 Empate. Dinero: " + dinero);
        Reiniciar();
    }

    // Reset de ronda
    void Reiniciar()
    {
        apuesta = 0;
        partidaActiva = false;
    }
}