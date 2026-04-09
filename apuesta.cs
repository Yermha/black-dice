using UnityEngine;

public class apuesta : MonoBehaviour
{
    valorApuesta = 0;
    jugador jugador;
    parar=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int getApuesta(){
        //aqui se obtiene la apuesta del jugador, se llama desde el boton de apostar
        return valorApuesta;
    }
    public void setApuesta(int valor){
        //aqui se establece la apuesta del jugador, se llama desde el boton de apostar
        valorApuesta = valor;
    }
    public void incrementarApuesta(int valor){
        //aqui se incrementa la apuesta del jugador, se llama desde el boton de incrementar apuesta
        valorApuesta = valorApuesta + 10;
        jugador.decrementarMonedero(10);
    }
    public void decrementarApuesta(int valor){
        //aqui se decrementa la apuesta del jugador, se llama desde el boton de decrementar apuesta
        valorApuesta = valorApuesta - 10;
        jugador.incrementarMonedero(10);
    }
    void empezarpartida(){
        //aqui se empieza la partida, se llama desde el boton de empezar partida
        parar=true;
        apuesta.setApuesta(valorApuesta);
    }
}