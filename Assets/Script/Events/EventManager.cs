using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    private int index = 0;

    public GameObject Quadro;
    public EventSO eventSO;
    public TextMeshProUGUI TextoNomeOrador;
    public TextMeshProUGUI TextoEvento;
    public TextMeshProUGUI bt1Texto;
    public TextMeshProUGUI bt2Texto;
    public TextMeshProUGUI bt1Descri��o;
    public TextMeshProUGUI bt2Descri��o;
    public GameObject Bt1Descria��opanel;
    public GameObject Bt2Descria��opanel;
    public Image ImagemOrador;
    public Image ImagemDeCorpo;
    public Button BotaoEscolha1;
    public Button BotaoEscolha2;
    public Button BotaoContinuar;
    public Button BotaoFechar;
    private eventos eventoAnterior;


    private int diaaleatorio;
    private int mesaleatorio;
    private int anoaleatorio;

    public int AnoMinimoAleatorio =1221;
    public int AnoMaximoAleatorio = 1900;

    private void Awake()
    {
        foreach (var evento in eventSO.Eventos)
        {
            if (evento.Aleatorio)
            {
                diaaleatorio = Random.Range(1, 29);
                mesaleatorio = Random.Range(1, 13);
                anoaleatorio = Random.Range(AnoMinimoAleatorio, AnoMaximoAleatorio);
                print(diaaleatorio + "/" + mesaleatorio + "/" + anoaleatorio);
                evento.dia = diaaleatorio;
                evento.mes = mesaleatorio;
                evento.ano = anoaleatorio;
               
            }
        }
    }
    void Start()
    {
        BotaoContinuar.onClick.AddListener(ProximaMensagem);
    }

    void Update()
    {
        eventos eventoAtual = eventSO.Eventos.Find(e => e.dia == Calendar.date.day && e.mes == Calendar.date.month && e.ano == Calendar.date.year);
       
        if (eventoAtual != null)
        {
           
            if (eventoAtual != eventoAnterior)
            {
                index = 0;
                eventoAnterior = eventoAtual;
            }
            if (index > eventoAtual.TextoDeCorpo.Length || index >= eventoAtual.nome.Length)
            {
                return;
            }
           
            Calendar.date.Paused = true;
            TImer.Timer.stop = true;
            Quadro.SetActive(true);
            if (eventoAtual.ImagemCentral != null && index < eventoAtual.ImagemCentral.Length)
            {
                ImagemOrador.sprite = eventoAtual.ImagemCentral[index];
            }
            if (eventoAtual.ImagemDeCorpo != null && index < eventoAtual.ImagemDeCorpo.Length)
            {
                ImagemDeCorpo.sprite = eventoAtual.ImagemDeCorpo[index];
            }
            if (eventoAtual.EfeitoBotao1 != null && eventoAtual.EfeitoBotao2 != null)
            {
                bt1Texto.text = eventoAtual.TextoEscolha1;
                bt2Texto.text = eventoAtual.TextoEscolha2;
                bt1Descri��o.text = eventoAtual.Descri��oEscolha1;
                bt2Descri��o.text = eventoAtual.Descri��oEscolha2;
            }


            TextoNomeOrador.text = eventoAtual.nome[index];
            TextoEvento.text = eventoAtual.TextoDeCorpo[index];
            

            if (!eventoAtual.BotaoContinuar)
            {
                BotaoEscolha1.gameObject.SetActive(true);
                BotaoEscolha2.gameObject.SetActive(true);
                BotaoContinuar.gameObject.SetActive(false);
            }
            else
            {
                BotaoEscolha1.gameObject.SetActive(false);
                BotaoEscolha2.gameObject.SetActive(false);
                BotaoContinuar.gameObject.SetActive(true);
            }
            
           
        }
    }

    void ProximaMensagem()
    {
        eventos eventoAtual = eventSO.Eventos.Find(e => e.dia == Calendar.date.day && e.mes == Calendar.date.month && e.ano == Calendar.date.year);

        if (eventoAtual != null)
        {
           
            index++;
            
        }
        Debug.Log("Novo �ndice: " + index);
    }

    public void Fechar()
    {
        eventos eventoAtual = eventSO.Eventos.Find(e => e.dia == Calendar.date.day && e.mes == Calendar.date.month && e.ano == Calendar.date.year);
        if (eventoAtual.Repete == true)
        {
            eventoAtual.ano++;
        }
        TImer.Timer.stop = false;
        Calendar.date.Paused = false;
        Calendar.date.day++; 
        Quadro.SetActive(false);

    }
    void Fechar2()
    {
        TImer.Timer.stop = false;
        Calendar.date.Paused = false;
        Calendar.date.day++;
        Quadro.SetActive(false);
    }

}
