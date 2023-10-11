using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
            Invoke("ProxFase", 5);
        }
    }
    
    //colocar omaga na vitoria da fase 2 e outras coisas engraçadas
    void Update()
    {
        
    }

    void ProxFase()
    {
        SceneManager.LoadScene("Fase2");
    }
}
