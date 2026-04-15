using UnityEngine;

public class BlackJackDados : MonoBehaviour
{
    //public apuesta sistemaApuesta;

    int jugadorTotal = 0;
    int bancaTotal = 0;
    bool juegoTerminado = false;

    public void NuevoJuego()
    {
        jugadorTotal = 0;
        bancaTotal = 0;
        juegoTerminado = false;

        Debug.Log("🎲 Nueva ronda");

        // tiradas iniciales
        PedirDado();
        PedirDado();
    }

    public void PedirDado()
    {
        if (juegoTerminado) return;

        int dado = Random.Range(1, 13);
        jugadorTotal += dado;

        Debug.Log("Jugador: " + jugadorTotal);

        if (jugadorTotal > 21)
        {
            Debug.Log("💥 Te pasaste");
            sistemaApuesta.Perder();
            juegoTerminado = true;
        }
    }

    public void Plantarse()
    {
        if (juegoTerminado) return;

        Debug.Log("Jugador se planta con: " + jugadorTotal);
        TurnoBanca();
    }

    void TurnoBanca()
    {
        Debug.Log("🏦 Turno de la casa");

        while (bancaTotal < 17)
        {
            int dado = Random.Range(1, 13);
            bancaTotal += dado;

            Debug.Log("Casa tira... total: " + bancaTotal);
        }

        Resultado();
    }

    void Resultado()
    {
        juegoTerminado = true;

        Debug.Log("Jugador: " + jugadorTotal + " | Casa: " + bancaTotal);

        if (bancaTotal > 21)
        {
            Debug.Log("🏆 La casa se pasa, ganas");
            //sistemaApuesta.Ganar();
        }
        else if (jugadorTotal > bancaTotal)
        {
            Debug.Log("🏆 Ganas");
            //sistemaApuesta.Ganar();
        }
        else if (jugadorTotal < bancaTotal)
        {
            Debug.Log("😢 Pierdes");
            //sistemaApuesta.Perder();
        }
        else
        {
            Debug.Log("🤝 Empate");
            //sistemaApuesta.Empatar();
        }
    }
}