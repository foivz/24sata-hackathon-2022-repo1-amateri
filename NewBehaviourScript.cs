using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Image[] imagesPieChar;
    public static float value1;
    public static float value2;
    public static float value3;
    float[] value4;

    // Start is called before the first frame update
    void Start()
    {
        value1 = PlayerPrefs.GetFloat("Value1");
        value2 = PlayerPrefs.GetFloat("Value2");
        value3 = PlayerPrefs.GetFloat("Value3");
        value4 = new float[3];
        value4[0] = value1;
        value4[1] = value2;
        value4[2] = value3;
        SetValues(value4);
    }

    // Update is called once per frame
    void Update()
    {
        if (BuyItem.BuyCheck == true)
        {
            BuyItem.BuyCheck = false;
            value4 = new float[3];
            value4[0] = value1;
            value4[1] = value2;
            value4[2] = value3;
            SetValues(value4);
        }
    }

    public void SetValues(float[] valuesToSet)
    {
        float totalValues = 0;
        for (int i = 0; i < value4.Length; i++)
        {
            totalValues += Findprecentage(valuesToSet, i);
            imagesPieChar[i].fillAmount = totalValues;
        }
    }

    private float Findprecentage(float[] valueToSet, int index)
    {
        float totalAmount = 0f;
        for (int i = 0; i < valueToSet.Length; i++)
        {
            totalAmount += valueToSet[i];
        }

        return valueToSet[index] / totalAmount;
    }
}
