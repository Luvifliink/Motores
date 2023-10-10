using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TextMeshProUGUI ContadorDeMoedas, parabains;
    public int restantes;
    
    // Start is called before the first frame update
    void Start()
    {
        restantes = FindObjectsOfType<Moeda>().Length;
        ContadorDeMoedas.text = $"Moedas restantes: {restantes}";       
    }

    // Update is called once per frame
    
    public void TirarMoedas(int Valor)
    {
        restantes = restantes - Valor;
        ContadorDeMoedas.text = $"Moedas Restantes: {restantes}";
        if (restantes <= 0)
        {
            parabains.text = "Parabéns";
        }
    }
    void Update()
    {
        
    }
}
