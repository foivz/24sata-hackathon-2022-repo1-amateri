using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuNavigation : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject ShoppingCart;
    public GameObject Allofem;
    public GameObject AddItem;
    public GameObject ProizvodiMesni;
    public GameObject ProizvodiMlekni;
    public GameObject ProizvodiZeleni;
    public GameObject Areyousurereset;
    public GameObject ResetGraf;
    public GameObject Instagram;
    public GameObject PanelPotrosnja;
    public GameObject MesoNovac;
    public GameObject MlekoNovac;
    public GameObject VoceNovac;
    public static bool ResetYes;
    // Start is called before the first frame update
    void Start()
    {
        MlekoNovac.SetActive(false);
        MesoNovac.SetActive(false);
        VoceNovac.SetActive(false);
        ResetGraf.SetActive(false);
        MainMenu.SetActive(true);
        Instagram.SetActive(false);
        Allofem.SetActive(false);
        ShoppingCart.SetActive(false);
        Areyousurereset.SetActive(false);
        ResetYes = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ResetYes == true)
        {
            ResetYes = false;
            OpenAll();
        }
        if (Postotci.ResetGrafBool == true)
        {
            Postotci.ResetGrafBool = false;
            BuyItem.BuyCheck = true;
            OpenMenu();
        }
    }

    public void OpenCart()
    {
        MainMenu.SetActive(false);
        Allofem.SetActive(false);
        ShoppingCart.SetActive(true);
        AddItem.SetActive(false);
    }
    public void OpenAll()
    {
        MainMenu.SetActive(false);
        Allofem.SetActive(true);
        ShoppingCart.SetActive(false);
        AddItem.SetActive(false);
        Areyousurereset.SetActive(false);
}
    public void OpenMenu()
    {
        MainMenu.SetActive(true);
        Allofem.SetActive(false);
        ShoppingCart.SetActive(false);
        AddItem.SetActive(false);
        Instagram.SetActive(false);
        PanelPotrosnja.SetActive(false);
        ResetGraf.SetActive(false);
    }
    public void Addtem()
    {
        MainMenu.SetActive(false);
        Allofem.SetActive(false);
        AddItem.SetActive(true);
        ProizvodiMesni.SetActive(false);
        ProizvodiMlekni.SetActive(false);
        ProizvodiZeleni.SetActive(true);
    }
    public void MesniProizvodi()
    {
        ProizvodiMesni.SetActive(true);
        ProizvodiMlekni.SetActive(false);
        ProizvodiZeleni.SetActive(false);
    }
    public void MljiecniProizvodi()
    {
        ProizvodiMesni.SetActive(false);
        ProizvodiMlekni.SetActive(true);
        ProizvodiZeleni.SetActive(false);
    }
    public void ZeleniProizvodi()
    {
        ProizvodiMesni.SetActive(false);
        ProizvodiMlekni.SetActive(false);
        ProizvodiZeleni.SetActive(true);
    }
    public void InstagramOpen()
    {
        Instagram.SetActive(true);
    }
    public void ResetAreYouSure()
    {
        Areyousurereset.SetActive(true);
    }
    public void resetAreYouSureGraf()
    {
        ResetGraf.SetActive(true);
    }
    public void Potrosnja()
    {
        PanelPotrosnja.SetActive(true);
        MainMenu.SetActive(false) ;
        Allofem.SetActive(false);
        ShoppingCart.SetActive(false);
        AddItem.SetActive(false);
        Instagram.SetActive(false);
        ResetGraf.SetActive(false);
    }
    public void OpenVoceNovac()
    {
        VoceNovac.SetActive(true);
    }
    public void OpenMesoNovac()
    {
        MesoNovac.SetActive(true);
    }
    public void OpenMlikoNovac()
    {
        MlekoNovac.SetActive(true);
    }
    public void CloseVoceNovac()
    {
        VoceNovac.SetActive(false);
    }
    public void CloseMlikoNovac()
    {
        MlekoNovac.SetActive(false);
    }
    public void CloseMesoNovac()
    {
        MesoNovac.SetActive(false);
    }

}
