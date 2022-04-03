using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Postotci : MonoBehaviour
{
    public static double Sveukupno;
    public double PostotakMeso;
    public double PostotakMliko;
    public double PostotakVocePovrce;
    public Text MesoText;
    public Text MlikoText;
    public Text VoceText;
    public Text VoceNovac;
    public Text MesoNovac;
    public Text MlikoNovac;
    public static bool ResetGrafBool;
    void Start()
    {
        ResetGrafBool = false;
        BuyItem.BuyCheck = true;
       Sveukupno = PlayerPrefs.GetFloat("Sveukupno");
    }


    void Update()
    {
        if (BuyItem.BuyCheck == true)
        {
            PostotakMeso = ((NewBehaviourScript.value3 / Sveukupno) * 100);
            PostotakMeso = Mathf.RoundToInt((float)PostotakMeso);
            MesoText.text = PostotakMeso + "%";
            PostotakVocePovrce = (NewBehaviourScript.value2 / Sveukupno) * 100;
            PostotakVocePovrce = Mathf.RoundToInt((float)PostotakVocePovrce);
            VoceText.text = PostotakVocePovrce + "%";
            PostotakMliko = (NewBehaviourScript.value1 / Sveukupno) * 100;
            PostotakMliko = Mathf.RoundToInt((float)PostotakMliko);
            MlikoText.text = PostotakMliko + "%";

            MlikoNovac.text = NewBehaviourScript.value1 + "kn";
            VoceNovac.text = NewBehaviourScript.value2 + "kn";
            MesoNovac.text = NewBehaviourScript.value3 + "kn";
        }
    }
    public void ResetMonthlyChart()
    {
        PlayerPrefs.SetFloat("Sveukupno", 0);
        PlayerPrefs.SetFloat("Value1", 0);
        PlayerPrefs.SetFloat("Value2", 0);
        PlayerPrefs.SetFloat("Value3", 0);
        Application.Quit();
    }
}
