using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItem : MonoBehaviour
{
    public GameObject RacicaSTvar;
    public GameObject MilkItem;
    public GameObject SirItem;
    public GameObject JogurtItem;
    public GameObject MaslacItem;
    public GameObject VrhnjeItem;
    public GameObject SvinjaItem;
    public GameObject PileItem;
    public GameObject KravaItem;
    public GameObject PureItem;
    public GameObject JanjeItem;
    public GameObject KrompirItem;
    public GameObject BananaItem;
    public GameObject MrkvaItem;
    public GameObject JabukaItem;
    public Transform TextPos;
    public GameObject Canvas;
    public GameObject Content;
    public GameObject BudgeText;
    public GameObject BudgeText2;
    public InputField InputBudget;
    public GameObject PlusUno;
    public static bool BuyCheck;
    public int Buget;
    // Start is called before the first frame update
    void Start()
    {
        Buget = PlayerPrefs.GetInt("Budzet");
        BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";

    }

    // Update is called once per frame
    void Update()
    {
        if (ShoopingCart.Svinja == true)
        {
            BoughtSvinja();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Janje == true)
        {
            BoughtJanje();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Krava == true)
        {
            BoughtKrava();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Pure == true)
        {
            BoughtPure();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Pile == true)
        {
            BoughtPiletina();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Mlijeko == true)
        {
            BoughtMilk();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Sir == true)
        {
            BoughtSir();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Jogurt == true)
        {
            BoughtJogurt();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Vrhnje == true)
        {
            BoughtVrhnje();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Maslac == true)
        {
            BoughtMaslac();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Mrkva == true)
        {
            BoughtMrkva();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Krompir == true)
        {
            BoughtKrompir();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Rajcica == true)
        {
            BoughtRajcica();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Banana == true)
        {
            BoughtBanana();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
        if (ShoopingCart.Ampple == true)
        {
            BoughtJabuka();
            BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
            BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        }
    }
 
    public void ResetBudget()
    {
        PlayerPrefs.SetInt("Budzet", 0);
        Buget = PlayerPrefs.GetInt("Budzet");
        BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        MenuNavigation.ResetYes = true;
    }
    public void GetBudget()
    {
        string BugetString = InputBudget.text;
        int ParsedNumber;
        int.TryParse(BugetString, out ParsedNumber);
        Buget = Buget + ParsedNumber;
        PlayerPrefs.SetInt("Budzet", Buget);
        BudgeText.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
        BudgeText2.GetComponent<Text>().text = "Budžet: " + Buget + " kn";
    }

    public void BoughtMilk()
    {
        ShoopingCart.Mlijeko = false;
        var myNewMilk = Instantiate(MilkItem, TextPos.position, TextPos.rotation);
        myNewMilk.transform.SetParent(Canvas.transform, false);
        myNewMilk.transform.parent = Content.transform;
        myNewMilk.transform.position = (TextPos.position);
        Buget = Buget - 8;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value1 = NewBehaviourScript.value1 + 8;
        PlayerPrefs.SetFloat("Value1", NewBehaviourScript.value1);
        Postotci.Sveukupno = Postotci.Sveukupno + 8;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtSir()
    {
        ShoopingCart.Sir = false;
        var myNewSir = Instantiate(SirItem, TextPos.position, TextPos.rotation);
        myNewSir.transform.SetParent(Canvas.transform, false);
        myNewSir.transform.parent = Content.transform;
        myNewSir.transform.position = (TextPos.position);
        Buget = Buget - 48;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value1 = NewBehaviourScript.value1 + 48;
        PlayerPrefs.SetFloat("Value1", NewBehaviourScript.value1);
        Postotci.Sveukupno = Postotci.Sveukupno + 48;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtVrhnje()
    {
        ShoopingCart.Vrhnje = false;
        var myNewVrhnje = Instantiate(VrhnjeItem, TextPos.position, TextPos.rotation);
        myNewVrhnje.transform.SetParent(Canvas.transform, false);
        myNewVrhnje.transform.parent = Content.transform;
        myNewVrhnje.transform.position = (TextPos.position);
        Buget = Buget - 3;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value1 = NewBehaviourScript.value1 + 3;
        PlayerPrefs.SetFloat("Value1", NewBehaviourScript.value1);
        Postotci.Sveukupno = Postotci.Sveukupno + 3;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtJogurt()
    {
        ShoopingCart.Jogurt = false;
        var myNewJogurt = Instantiate(JogurtItem, TextPos.position, TextPos.rotation);
        myNewJogurt.transform.SetParent(Canvas.transform, false);
        myNewJogurt.transform.parent = Content.transform;
        myNewJogurt.transform.position = (TextPos.position);
        Buget = Buget - 13;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value1 = NewBehaviourScript.value1 + 13;
        PlayerPrefs.SetFloat("Value1", NewBehaviourScript.value1);
        Postotci.Sveukupno = Postotci.Sveukupno + 13;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtMaslac()
    {
        ShoopingCart.Maslac = false;
        var myNewMaslac = Instantiate(MaslacItem, TextPos.position, TextPos.rotation);
        myNewMaslac.transform.SetParent(Canvas.transform, false);
        myNewMaslac.transform.parent = Content.transform;
        myNewMaslac.transform.position = (TextPos.position);
        Buget = Buget - 17;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value1 = NewBehaviourScript.value1 + 17;
        PlayerPrefs.SetFloat("Value1", NewBehaviourScript.value1);
        Postotci.Sveukupno = Postotci.Sveukupno + 17;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtKrompir()
    {
        ShoopingCart.Krompir = false;
        var myNewKrompir = Instantiate(KrompirItem, TextPos.position, TextPos.rotation);
        myNewKrompir.transform.SetParent(Canvas.transform, false);
        myNewKrompir.transform.parent = Content.transform;
        myNewKrompir.transform.position = (TextPos.position);
        Buget = Buget - 8;
        PlayerPrefs.SetInt("Budzet", Buget); BuyCheck = true;
        BuyCheck = true;
        NewBehaviourScript.value2 = NewBehaviourScript.value2 + 8;
        PlayerPrefs.SetFloat("Value2", NewBehaviourScript.value2);
        Postotci.Sveukupno = Postotci.Sveukupno + 8;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtMrkva()
    {
        ShoopingCart.Mrkva = false;
        var myNewMrkva = Instantiate(MrkvaItem, TextPos.position, TextPos.rotation);
        myNewMrkva.transform.SetParent(Canvas.transform, false);
        myNewMrkva.transform.parent = Content.transform;
        myNewMrkva.transform.position = (TextPos.position);
        Buget = Buget - 7;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value2 = NewBehaviourScript.value2 + 7;
        PlayerPrefs.SetFloat("Value2", NewBehaviourScript.value2);
        Postotci.Sveukupno = Postotci.Sveukupno + 7;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtRajcica()
    {
        ShoopingCart.Rajcica = false;
        var myNewRajcica = Instantiate(RacicaSTvar, TextPos.position, TextPos.rotation);
        myNewRajcica.transform.SetParent(Canvas.transform, false);
        myNewRajcica.transform.parent = Content.transform;
        myNewRajcica.transform.position = (TextPos.position);
        Buget = Buget - 15;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value2 = NewBehaviourScript.value2 + 15;
        PlayerPrefs.SetFloat("Value2", NewBehaviourScript.value2);
        Postotci.Sveukupno = Postotci.Sveukupno + 48;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtBanana()
    {
        ShoopingCart.Banana = false;
        var myNewBanana = Instantiate(BananaItem, TextPos.position, TextPos.rotation);
        myNewBanana.transform.SetParent(Canvas.transform, false);
        myNewBanana.transform.parent = Content.transform;
        myNewBanana.transform.position = (TextPos.position);
        Buget = Buget - 9;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value2 = NewBehaviourScript.value2 + 9;
        PlayerPrefs.SetFloat("Value2", NewBehaviourScript.value2);
        Postotci.Sveukupno = Postotci.Sveukupno + 9;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtJabuka()
    {
        ShoopingCart.Ampple = false;
        var myNewApple = Instantiate(JabukaItem, TextPos.position, TextPos.rotation);
        myNewApple.transform.SetParent(Canvas.transform, false);
        myNewApple.transform.parent = Content.transform;
        myNewApple.transform.position = (TextPos.position);
        Buget = Buget - 10;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value2 = NewBehaviourScript.value2 + 10;
        PlayerPrefs.SetFloat("Value2", NewBehaviourScript.value2);
        Postotci.Sveukupno = Postotci.Sveukupno + 10;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtPiletina()
    {
        ShoopingCart.Pile = false;
        var myNewPile = Instantiate(PileItem, TextPos.position, TextPos.rotation);
        myNewPile.transform.SetParent(Canvas.transform, false);
        myNewPile.transform.parent = Content.transform;
        myNewPile.transform.position = (TextPos.position);
        Buget = Buget - 26;
        PlayerPrefs.SetInt("Budzet", Buget); 
        BuyCheck = true;
        NewBehaviourScript.value3 = NewBehaviourScript.value3 + 26;
        PlayerPrefs.SetFloat("Value3", NewBehaviourScript.value3);
        Postotci.Sveukupno = Postotci.Sveukupno + 26;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtKrava()
    {
        ShoopingCart.Krava = false;
        var myNewKrava = Instantiate(KravaItem, TextPos.position, TextPos.rotation);
        myNewKrava.transform.SetParent(Canvas.transform, false);
        myNewKrava.transform.parent = Content.transform;
        myNewKrava.transform.position = (TextPos.position);
        Buget = Buget - 25;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value3 = NewBehaviourScript.value3 + 25;
        PlayerPrefs.SetFloat("Value3", NewBehaviourScript.value3);
        Postotci.Sveukupno = Postotci.Sveukupno + 25;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtPure()
    {
        ShoopingCart.Pure = false;
        var myNewPure = Instantiate(PureItem, TextPos.position, TextPos.rotation);
        myNewPure.transform.SetParent(Canvas.transform, false);
        myNewPure.transform.parent = Content.transform;
        myNewPure.transform.position = (TextPos.position);
        Buget = Buget - 36;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value3 = NewBehaviourScript.value3 + 36;
        PlayerPrefs.SetFloat("Value3", NewBehaviourScript.value3);
        Postotci.Sveukupno = Postotci.Sveukupno + 36;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtSvinja()
    {
        ShoopingCart.Svinja = false;
        var myNewSvinja = Instantiate(SvinjaItem, TextPos.position, TextPos.rotation);
        myNewSvinja.transform.SetParent(Canvas.transform, false);
        myNewSvinja.transform.parent = Content.transform;
        myNewSvinja.transform.position = (TextPos.position);
        Buget = Buget - 27;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value3 = NewBehaviourScript.value3 + 27;
        PlayerPrefs.SetFloat("Value3", NewBehaviourScript.value3);
        Postotci.Sveukupno = Postotci.Sveukupno + 27;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void BoughtJanje()
    {
        ShoopingCart.Janje = false;
        var myNewJanje = Instantiate(JanjeItem, TextPos.position, TextPos.rotation);
        myNewJanje.transform.SetParent(Canvas.transform, false);
        myNewJanje.transform.parent = Content.transform;
        myNewJanje.transform.position = (TextPos.position);
        Buget = Buget - 29;
        PlayerPrefs.SetInt("Budzet", Buget);
        BuyCheck = true;
        NewBehaviourScript.value3 = NewBehaviourScript.value3 + 29;
        PlayerPrefs.SetFloat("Value3",NewBehaviourScript.value3);
        Postotci.Sveukupno = Postotci.Sveukupno + 29;
        PlayerPrefs.SetFloat("Sveukupno", ((float)Postotci.Sveukupno));
    }
    public void RemoveThing()
    {
        Destroy(transform.parent.gameObject);
    }

    

}
