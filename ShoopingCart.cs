using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoopingCart : MonoBehaviour
{
    public GameObject RacicaStvar;
    public GameObject Milk;
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
    public GameObject Apple;
    public Transform TextPos;
    public GameObject Content;
    public GameObject Canvas;
    public GameObject tronzakcije;
    public GameObject PlusUno;
    public static bool Ampple;
    public static bool Mlijeko;
    public static bool Sir;
    public static bool Jogurt;
    public static bool Maslac;
    public static bool Vrhnje;
    public static bool Svinja;
    public static bool Pile;
    public static bool Krava;
    public static bool Pure;
    public static bool Janje;
    public static bool Mrkva;
    public static bool Banana;
    public static bool Krompir;
    public static bool Rajcica;

    // Start is called before the first frame update
    void Start()
    {
        Ampple = false;
        Mlijeko = false;
        Sir = false;
        Jogurt = false;
        Maslac = false;
        Vrhnje = false;
        Svinja = false;
        Pile = false;
        Krava = false;
        Pure = false;
        Janje = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RemoveThing()
    {
        Destroy(transform.parent.gameObject);
    }
    public void addMilk()
    {
        Plusone();
        var myNewMilk = Instantiate(Milk, TextPos.position, TextPos.rotation);
        myNewMilk.transform.SetParent(Canvas.transform, false);
        myNewMilk.transform.parent = Content.transform ;
        myNewMilk.transform.position = (TextPos.position);
    }
    public void addApple()
    {
        Plusone();
        var myNewApple = Instantiate(Apple, TextPos.position, TextPos.rotation);
        myNewApple.transform.SetParent(Canvas.transform, false);
        myNewApple.transform.parent = Content.transform;
        myNewApple.transform.position = (TextPos.position);
    }
    public void addSir()
    {
        Plusone();
        var myNewSir = Instantiate(SirItem, TextPos.position, TextPos.rotation);
        myNewSir.transform.SetParent(Canvas.transform, false);
        myNewSir.transform.parent = Content.transform;
        myNewSir.transform.position = (TextPos.position);
    }
    public void addJogurt()
    {
        Plusone();
        var myNewJogurt = Instantiate(JogurtItem, TextPos.position, TextPos.rotation);
        myNewJogurt.transform.SetParent(Canvas.transform, false);
        myNewJogurt.transform.parent = Content.transform;
        myNewJogurt.transform.position = (TextPos.position);
    }
    public void addMaslac()
    {
        Plusone();
        var myNewMaslac = Instantiate(MaslacItem, TextPos.position, TextPos.rotation);
        myNewMaslac.transform.SetParent(Canvas.transform, false);
        myNewMaslac.transform.parent = Content.transform;
        myNewMaslac.transform.position = (TextPos.position);
    }
    public void addVrhnje()
    {
        Plusone();
        var myNewVrhnje = Instantiate(VrhnjeItem, TextPos.position, TextPos.rotation);
        myNewVrhnje.transform.SetParent(Canvas.transform, false);
        myNewVrhnje.transform.parent = Content.transform;
        myNewVrhnje.transform.position = (TextPos.position);
    }
    public void addSvinja()
    {
        Plusone();
        var myNewSvinja = Instantiate(SvinjaItem, TextPos.position, TextPos.rotation);
        myNewSvinja.transform.SetParent(Canvas.transform, false);
        myNewSvinja.transform.parent = Content.transform;
        myNewSvinja.transform.position = (TextPos.position);
    }
    public void addPile()
    {
        Plusone();
        var myNewPile = Instantiate(PileItem, TextPos.position, TextPos.rotation);
        myNewPile.transform.SetParent(Canvas.transform, false);
        myNewPile.transform.parent = Content.transform;
        myNewPile.transform.position = (TextPos.position);
    }
    public void addKrava()
    {
        Plusone();
        var myNewKrava = Instantiate(KravaItem, TextPos.position, TextPos.rotation);
        myNewKrava.transform.SetParent(Canvas.transform, false);
        myNewKrava.transform.parent = Content.transform;
        myNewKrava.transform.position = (TextPos.position);
    }
    public void addPure()
    {
        Plusone();
        var myNewPure = Instantiate(PureItem, TextPos.position, TextPos.rotation);
        myNewPure.transform.SetParent(Canvas.transform, false);
        myNewPure.transform.parent = Content.transform;
        myNewPure.transform.position = (TextPos.position);
    }
    public void addJanje()
    {
        Plusone();
        var myNewJanje = Instantiate(JanjeItem, TextPos.position, TextPos.rotation);
        myNewJanje.transform.SetParent(Canvas.transform, false);
        myNewJanje.transform.parent = Content.transform;
        myNewJanje.transform.position = (TextPos.position);
    }
    public void addMrkva()
    {
        Plusone();
        var myNewMrkva = Instantiate(MrkvaItem, TextPos.position, TextPos.rotation);
        myNewMrkva.transform.SetParent(Canvas.transform, false);
        myNewMrkva.transform.parent = Content.transform;
        myNewMrkva.transform.position = (TextPos.position);
    }
    public void addKrompir()
    {
        Plusone();
        var myNewKrompir = Instantiate(KrompirItem, TextPos.position, TextPos.rotation);
        myNewKrompir.transform.SetParent(Canvas.transform, false);
        myNewKrompir.transform.parent = Content.transform;
        myNewKrompir.transform.position = (TextPos.position);
    }
    public void addBanana()
    {
        Plusone();
        var myNewBanana = Instantiate(BananaItem, TextPos.position, TextPos.rotation);
        myNewBanana.transform.SetParent(Canvas.transform, false);
        myNewBanana.transform.parent = Content.transform;
        myNewBanana.transform.position = (TextPos.position);
    }
    public void addRajcica()
    {
        Plusone();
        var myNewRajcica = Instantiate(RacicaStvar, TextPos.position, TextPos.rotation);
        myNewRajcica.transform.SetParent(Canvas.transform, false);
        myNewRajcica.transform.parent = Content.transform;
        myNewRajcica.transform.position = (TextPos.position);
    }

        public void BuyApple()
    {
        Ampple = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyMliko()
    {
        Mlijeko = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuySir()
    {
        Sir = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyJogurt()
    {
        Jogurt = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyMaslac()
    {
        Maslac = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyVrhnje()
    {
        Vrhnje = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuySvinja()
    {
        Svinja = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyPile()
    {
        Pile = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyKrava()
    {
        Krava = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyPure()
    {
        Pure = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyJanje()
    {
        Janje = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyMrkva()
    {
        Mrkva = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyBanana()
    {
        Banana = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyKrompir()
    {
        Krompir = true;
        Destroy(transform.parent.gameObject);
    }
    public void BuyRajcica()
    {
        Rajcica = true;
        Destroy(transform.parent.gameObject);
    }
    IEnumerator Plusone()
    {
        PlusUno.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        PlusUno.SetActive(false);
    }



}
