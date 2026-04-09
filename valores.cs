using UnityEngine;

public class valores : MonoBehaviour
{
    lista lista;
    valores valores;
    valortotal=0;
    parar=false;
    dados dados;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(parar==true){
            winLose();
        }
    }
    void tirar(){
        if(parar==false){
            for(int i=0; i<lista.cantidad(); i++){
                valortotal=lista.obtener(i)+dados.valorDado1();
                dados.tirarDado();
            }
            winLose();
        }
    }
    public void winLose(){
        for(int i=0; i<lista.cantidad(); i++){
            valortotal=lista.obtener(i);
            if(valortotal >22){
            Print("perdiste");
        }
        else if(valortotal==22){
            Print("ganaste");
        }
        else if(parar==true && valortotal<=valores.valortotal()){
            Print("perdiste");
        }
        else if(parar==true && valortotal>valores.valortotal()){
            Print("ganaste");
        }
        }
        
    }
    public int valortotal(){
        return valortotal;
    }
    public void dividir(){
        valortotal=valortotal-dados.valorDado1();
        valortotal2=dados.valorDado1();
        lista.agregar(valortotal2);
    }
}
