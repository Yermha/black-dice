using UnityEngine;

public class valores : MonoBehaviour
{
    jugador jugador;
    apuesta apuesta;
    lista lista;
    valores valores;
    valortotal=0;
    parar=false;
    dados dados;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        apuesta.getApuesta();
    }

    // Update is called once per frame
    void Update()
    {
        if(parar==true){
            winLose();
        }
    }
    //Metodo que se llama para volver a tirar el dado, se llama desde el boton de tirar
    void tirar(){
        if(parar==false){
            for(int i=0; i<lista.cantidad(); i++){
                valortotal=lista.obtener(i)+dados.valorDado1();
                dados.tirarDado();
            }
            //comprobacion de que el valor total no se pase de 22
            winLose();
        }
    }
    public void winLose(){
        //se comprueva cada conjunto de dados que tiene el jugador
        for(int i=0; i<lista.cantidad(); i++){
            valortotal=lista.obtener(i);
            //si este se pasa de 22 pierde, si es igual a 22 gana, si el jugador decide parar y su valor total es menor o igual al del de la casa pierde, si el jugador decide parar y su valor total es mayor al de la casa gana
            if(valortotal >22){
            Print("perdiste");
            jugador.decrementarMonedero(apuesta.getApuesta());

        }
        else if(valortotal==22){
            Print("ganaste");
            jugador.incrementarMonedero(apuesta.getApuesta());
        }
        else if(parar==true && valortotal<=valores.valortotal()){
            Print("perdiste");
            jugador.decrementarMonedero(apuesta.getApuesta());
        }
        else if(parar==true && valortotal>valores.valortotal()){
            Print("ganaste");
            jugador.incrementarMonedero(apuesta.getApuesta());
        }
        }
        
    }
    public int valortotal(){
        return valortotal;
    }
    // Método para crear grupos de dados, se llama desde el botón de dividir
    public void dividir(){
        //La apuesta se duplica, el valor total se resta el valor del dado que se acaba de dividir y se agrega a la lista el valor del dado que se acaba de dividir
        nuevaApuesta=apuesta.getApuesta()*2;
        apuesta.setApuesta(nuevaApuesta);
        valortotal=valortotal-dados.valorDado1();
        valortotal2=dados.valorDado1();
        lista.agregar(valortotal2);
    }
}
