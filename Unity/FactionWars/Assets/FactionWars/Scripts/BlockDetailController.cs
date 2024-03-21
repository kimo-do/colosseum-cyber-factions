using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockDetailController : MonoBehaviour
{
    public List<FactionStatsTug> attackingFactions;
    public RectTransform attackingSide;

    public FactionStatsTug defendingFaction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFactions(List<Faction> attackers, Faction defender)
    {
        int screenWidth = Screen.width;
        int screenHeight = Screen.height;

        foreach (FactionStatsTug factionUI in attackingFactions)
        {
            factionUI.gameObject.SetActive(false);
        }

        int dominanceLeft = screenWidth;
        int dominanceHeight = UnityEngine.Random.Range(100, screenHeight);

        for (int i = 0; i < attackers.Count; i++)
        {
            attackingFactions[i].gameObject.SetActive(true);
            int useWidth = dominanceLeft;

            if (i < attackers.Count - 1)
            {
                useWidth = UnityEngine.Random.Range(Mathf.Min(100, dominanceLeft), dominanceLeft / 2);
                dominanceLeft -= useWidth;
            }

            attackingFactions[i].SetFaction(attackers[i], useWidth);
        }

        defendingFaction.SetFaction(defender, screenWidth);

        defendingFaction.RectTrans.sizeDelta = new Vector2(screenWidth, screenHeight - dominanceHeight);
        attackingSide.sizeDelta = new Vector2(screenWidth, dominanceHeight);

    }
}
