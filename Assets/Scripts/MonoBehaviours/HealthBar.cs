using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{

    public HitPoints hitPoints;

    [HideInInspector]
    public Player character;
    public Image meterImage;

    public TextMeshProUGUI hpText;

    float maxHitPoints;

    void Start()
    {
        if(character != null){
            maxHitPoints = character.maxHitPoints;
        }
    }

    void Update()
    {
        if(character != null){
            meterImage.fillAmount = hitPoints.value / maxHitPoints;
        }
        hpText.text = "HP: " + (meterImage.fillAmount*100);
    }
}
