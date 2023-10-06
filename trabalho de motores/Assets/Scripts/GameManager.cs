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
        restantes = FindObjectOfType<Moeda>().Length;

        ContadorDeMoedas.text = $"Moedas restantes: {restantes}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
