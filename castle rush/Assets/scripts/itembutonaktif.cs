using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itembutonaktif : MonoBehaviour
{
    public GameObject[] kbt;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 0) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); kbt[24].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 1) { if (PlayerPrefs.GetInt("boneaxe") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 2) { if (PlayerPrefs.GetInt("crystalhalberd") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 3) { if (PlayerPrefs.GetInt("club") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 4) { if (PlayerPrefs.GetInt("lute") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 5) { if (PlayerPrefs.GetInt("broom") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 6) { if (PlayerPrefs.GetInt("crystalsworddouble") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 7) { if (PlayerPrefs.GetInt("crystalsword") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 8) { if (PlayerPrefs.GetInt("naturestaff") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 9) { if (PlayerPrefs.GetInt("musketrifle") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 10) { if (PlayerPrefs.GetInt("revolver") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 11) { if (PlayerPrefs.GetInt("sai") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 12) { if (PlayerPrefs.GetInt("hammer") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 13) { if (PlayerPrefs.GetInt("musketpistol") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 14) { if (PlayerPrefs.GetInt("naginata") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 15) { if (PlayerPrefs.GetInt("shieldhalf") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 16) { if (PlayerPrefs.GetInt("bow") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 17) { if (PlayerPrefs.GetInt("shieldviking") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 18) { if (PlayerPrefs.GetInt("staff") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 19) { if (PlayerPrefs.GetInt("sword") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 20) { if (PlayerPrefs.GetInt("katana") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 21) { if (PlayerPrefs.GetInt("axe") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 22) { if (PlayerPrefs.GetInt("shieldknight") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 23) { if (PlayerPrefs.GetInt("swordbroken") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunmeitem") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunmeitem") == 24) { if (PlayerPrefs.GetInt("saber") == 1) { kbt[PlayerPrefs.GetInt("secimgorunmeitem")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunmeitem") - 1].SetActive(false); kbt[0].SetActive(false); }
        

    }
}
