using UnityEngine;

public class Dados : MonoBehaviour
{
    valorDado1 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        valorDado1 = Random.Range(1, 12);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int valorDado1(){
        return valorDado1;
    }
    public void tirarDado(){
        valorDado1 = Random.Range(1, 12);
    }
}
