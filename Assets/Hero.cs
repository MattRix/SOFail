using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Hero")]
public class Hero : ScriptableObject
{
    public int age = 30;

    public string bestFriend = "None";

    public int hitPoints = 100; 

    public List<int> levels = new List<int>(); 

    public int baseDamage; //notice no default specified
}
