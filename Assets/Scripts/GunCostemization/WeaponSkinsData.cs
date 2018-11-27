using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinsData :ScriptableObject {

    //All skins for the gun

    public List<Texture2D> skins;
    //each skin need a preview .
    public List<Image> skinsPreview;

	//TODO create en editor script that generate previews from the skins list.
    //TODO expand this more so instead of all skins in one file , each skin get a file , description cost, material..ect
}
