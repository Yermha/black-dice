using UnityEngine;

public class apuesta : MonoBehaviour
{
    valorApuesta = 0;
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
    }
}