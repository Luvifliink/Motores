using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private AudioSource source;
    public AudioClip moeda, vitoria;
    public TextMeshProUGUI ContadorDeMoedas, parabains;
    public int restantes;
    
    // Start is called before the first frame update
    void Start()
    {
        TryGetComponent(out source);
        restantes = FindObjectsOfType<Moeda>().Length;
        ContadorDeMoedas.text = $"Moedas restantes: {restantes}";       
    }

    // Update is called once per frame
    
    public void TirarMoedas(int Valor)
    {
        source.PlayOneShot(moeda);
        restantes = restantes - Valor;
        ContadorDeMoedas.text = $"Moedas Restantes: {restantes}";
        if (restantes <= 0)
        {
            parabains.text = "Parabéns";
            source.Stop();
            source.PlayOneShot(vitoria);
        }
    }
    void Update()
    {
        
    }
}
