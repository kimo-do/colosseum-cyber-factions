using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Faction", menuName = "Faction", order = 51)]
public class Faction : ScriptableObject
{
    public int id;
    public string ticker;
    public string factionTitle;
    public string factionDescription;
    public string contractAddress;
    public Sprite icon;
    public Color color;
}
