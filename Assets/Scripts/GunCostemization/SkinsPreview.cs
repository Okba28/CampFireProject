using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinsPreview : MonoBehaviour {

    // This component will get the skins available to the chosen gun and display them
    [SerializeField]
    private WeaponData selectedWeapon;//the weapon player seleced for custimizatoon
    public List<Button> displaySlots; // the slot when display the skin, using buttons here to use the click functionality .
    //TODO make this dynamic and private, spa<n buttons and dynamickly scale the panel
    
   
    //GET THE SELECTED WEAPON AND SET OUR VARIABLES

    private void OnEnable()
    {
        //diplay the preview 
        DisplayPreview();
    }
    private void OnDisable()
    {
        //unload everything 
    }
    void DisplayPreview()
    {
        List<Image> skinPreview = selectedWeapon.skinsData.skinsPreview;
        //Extraxt the preview images and put them on the buttons images 
        //TODO put checkers so we don't loop out of range
        foreach (var preview in skinPreview )
        {
            foreach (var button in displaySlots)
            {
                button.image = preview;
            }
        }
    }
}
