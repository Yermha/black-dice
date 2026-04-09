using UnityEngine;

public class Dados : MonoBehaviour
{
    monedero = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int monedero(){
        return monedero;
    }
    //metodo para incrementar o decrementar el monedero del jugador, se maneja mediante las victorias y las derrotas del jugador
    public void incrementarMonedero(int valor){
        monedero = monedero + valor;
    }
    public void decrementarMonedero(int valor){
        monedero = monedero - valor;
    }
}
