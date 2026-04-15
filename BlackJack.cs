using UnityEngine;

public class BlackjackDados : MonoBehaviour
{
    int jugadorTotal = 0;
    int bancaTotal = 0;
    bool juegoTerminado = false;
    int dinero = 100; // dinero inicial
    int apuestaActual = 0;
    public GameObject dadoPrefab;
public Transform puntoSpawn;

    void Start()
    {
        NuevoJuego();
    }

    public void NuevoJuego()
    {
        jugadorTotal = 0;
        bancaTotal = 0;
        juegoTerminado = false;

        Debug.Log("Nuevo juego شروع 🎲");
        PedirDado(); // tirada inicial
        PedirDado();
    }

    public void PedirDado()
{
    if (juegoTerminado) return;

    int valor = Random.Range(1, 13);
    jugadorTotal += valor;

    // Crear dado en escena
    GameObject nuevoDado = Instantiate(dadoPrefab, puntoSpawn.position, Quaternion.identity);

    // (Opcional) moverlos un poco para que no se amontonen
    nuevoDado.transform.position += new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2));

    Debug.Log("Jugador tira: " + valor + " | Total: " + jugadorTotal);

    if (jugadorTotal > 21)
    {
        Debug.Log("💥 Te pasaste. Pierdes.");
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
        while (bancaTotal < 17)
        {
            int dado = Random.Range(1, 13);
            bancaTotal += dado;
            Debug.Log("Banca tira: " + dado + " | Total: " + bancaTotal);
        }

        ResultadoFinal();
    }

    void ResultadoFinal()
{
    juegoTerminado = true;

    Debug.Log("Jugador: " + jugadorTotal + " | Banca: " + bancaTotal);

    if (bancaTotal > 21 || jugadorTotal > bancaTotal)
    {
        Debug.Log("🏆 ¡Ganaste!");
        dinero += apuestaActual * 2;
    }
    else if (jugadorTotal < bancaTotal)
    {
        Debug.Log("😢 Pierdes.");
    }
    else
    {
        Debug.Log("🤝 Empate.");
        dinero += apuestaActual;
    }

    apuestaActual = 0;

    Debug.Log("Dinero total: " + dinero);
}

}
