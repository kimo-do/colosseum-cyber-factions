using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactionGameController : MonoBehaviour
{
    public List<Faction> factions;

    // Start is called before the first frame update
    void Start()
    {
        List<Faction> attackers = new List<Faction>()
        {
            factions[1],
        };

        Faction defender = factions[0];

        GameScreen.instance.blockDetailScreen.SetFactions(attackers, defender);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
