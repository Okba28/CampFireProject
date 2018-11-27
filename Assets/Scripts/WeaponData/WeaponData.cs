using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : ScriptableObject
{

    //All gun data and stats

    public string weaponName= "deafultGun";
    
    public float maxRange = 975f;         //max distance the bullet will travel in meters
    public float maxDamage=25f;           //max health 1 bullet can take.
    public float minDamage =18.4f;       //min health points 1 bullet can take .
    public float roundPerMinute = 800f ; //in another worde fire rate.
    public float reloadTimeFull = 1.80f; //relaod time if bullet still in mag.
    public float relaodTimeEmpty = 2.80f;//reload time in empty mag
    public float bulletVelocity = 650f; // bullet speed m/s.
    public int   magSize = 31;           //the gun magazine size.
    public AmmunitionType ammunitionType = 0;//type of ammunition used wth this gun , different type can affect speed, fire rate and damage.
    public WeaponSkinsData skinsData;
    public WaeponAttachementData attachementData;
    
    public FireMode fireMode = FireMode.auto; //uh fire mode!
}

public enum AmmunitionType
{
    defaultAmmo,HighVelocity
};
public enum FireMode
{
    single,auto,none
};


