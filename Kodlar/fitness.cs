using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fitness : MonoBehaviour
{
    public Slider slider;
    public Text sliderText;
    public Slider slider2;
    public Text sliderText2;
    public Text yakilan;
    public int uyku=0;
    public int spor=0;
    public int yakma=0;
    

    void Start()
    {               //slider değerlerini tutan arrow fonksiyonları
        slider.onValueChanged.AddListener((v) =>
        {
            sliderText.text = v.ToString("0");
        });
        
        slider2.onValueChanged.AddListener((w) =>
        {
            sliderText2.text = w.ToString("0");
        });

    }

    void Update()
    {               //yakılan kalori hesaplama
        uyku = int.Parse(sliderText.text);
        spor = int.Parse(sliderText2.text);
        yakma = (uyku * 50) + (spor * 140);
        yakilan.text = yakma.ToString("0"); 
    }

    public void ChangeScene()   //ekran değişme
    {
        SceneManager.LoadScene("SampleScene");
    }

  


}
