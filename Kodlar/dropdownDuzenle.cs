using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dropdownDuzenle : MonoBehaviour
{
    public Text TextBox;

    void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>(); //dropdown objesini tanımlama

        dropdown.options.Clear(); 

        List<string> items = new List<string>();   //dropdowna eklenecek öğeler
        items.Add("Baklava");
        items.Add("Balık");
        items.Add("Biftek");
        items.Add("Çorba");
        items.Add("Döner");
        items.Add("Dondurma");
        items.Add("Ekmek");
        items.Add("Hamburger");
        items.Add("Çizburger");
        items.Add("Kebap");
        items.Add("Köfte"); 
        items.Add("Makarna");
        items.Add("Mantı");
        items.Add("Patates Kızartması");
        items.Add("Pide");
        items.Add("Pilav");
        items.Add("Pizza");
        items.Add("Sushi");
        items.Add("Süt");
        items.Add("Tavuk");
        items.Add("Yoğurt");
        items.Add("Yumurta");
        

        foreach (var item in items)         //foreach döngüsü ile dropdowna öğe ekleme
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }

        DropdownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }

    void DropdownItemSelected(Dropdown dropdown)    //dropdown seçim fonksiyonu
    {
        int index = dropdown.value;
        yemek = dropdown.options[index].text;
        yemekSecim();
        TextBox.text = kalori.ToString();
    }
    //switch case ile kalori hesaplama
    string yemek;
    int kalori = -173;

    void yemekSecim()
    {

        switch (yemek)
        {
            case "Yumurta":
                kalori +=154;
                break;
            case "Süt":
                kalori +=42;
                break;
            case "Patates Kızartması":
                kalori += 311;
                break;
            case "Pizza":
                kalori += 266;
                break;
            case "Sushi":
                kalori += 400;
                break;
            case "Hamburger":
                kalori += 257;
                break;
            case "Kebap":
                kalori += 325;
                break;
            case "Makarna":
                kalori += 131;
                break;
            case "Pilav":
                kalori += 359;
                break;
            case "Çizburger":
                kalori += 303;
                break;
            case "Biftek":
                kalori += 133;
                break;
            case "Dondurma":
                kalori += 207;
                break;
            case "Tavuk":
                kalori += 239;
                break;
            case "Çorba":
                kalori += 57;
                break;
            case "Döner":
                kalori += 128;
                break;
            case "Baklava":
                kalori += 173;
                break;
            case "Köfte":
                kalori += 200;
                break;
            case "Pide":
                kalori += 600;
                break;
            case "Ekmek":
                kalori += 264;
                break;
            case "Balık":
                kalori += 205;
                break;
            case "Mantı":
                kalori += 322;
                break;
            case "Yoğurt":
                kalori += 58;
                break;

        }
    }

    //bar boyutu ve değişkenleri 
    public int maximum=2500;
    public int current;
    public Image mask;
    public Image fill;

    void GetCurrentFill()
    {
        float fillAmount = (int)kalori / (float)maximum; 
        mask.fillAmount = fillAmount;
    }

    void Update()
    { 
        GetCurrentFill();
        //bar rengi
        if (kalori <1000)
        {
            fill.color = Color.green;
        }
        if (kalori > 1000 && kalori < 2000)
        {
            fill.color = Color.yellow;
        }
        if (kalori > 2000)
        {
            fill.color = Color.red; 
        }
    }

    public void ChangeScene()  //ekran değiştirme
    {
        SceneManager.LoadScene("fitness");
    }

}
