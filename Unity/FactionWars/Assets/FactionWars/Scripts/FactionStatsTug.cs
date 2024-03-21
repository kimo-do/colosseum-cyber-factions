using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactionStatsTug : MonoBehaviour
{
    public Image iconImage;

    private RectTransform rectTrans;
    private LayoutElement layoutElement;
    private Image backgroundImage;


    private Faction currentFaction;

    public RectTransform RectTrans { get => rectTrans; set => rectTrans = value; }

    private void Awake()
    {
        rectTrans = GetComponent<RectTransform>();
        layoutElement = GetComponent<LayoutElement>();
        backgroundImage = GetComponent<Image>();    
    }

    public void SetFaction(Faction faction, int width)
    {
        currentFaction = faction;
        layoutElement.preferredWidth = width;
        iconImage.sprite = faction.icon;
        backgroundImage.color = faction.color;

        if (width < 150)
        {
            iconImage.gameObject.SetActive(false);
        }
        else
        {
            iconImage.gameObject.SetActive(true);
        }

        LayoutRebuilder.ForceRebuildLayoutImmediate(rectTrans);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
