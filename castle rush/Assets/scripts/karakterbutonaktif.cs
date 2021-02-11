using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakterbutonaktif : MonoBehaviour
{
    public GameObject[] kbt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("secimgorunme") == 0) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); kbt[30].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 1) { if (PlayerPrefs.GetInt("bard") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 2) { if (PlayerPrefs.GetInt("blackbeard") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 3) { if (PlayerPrefs.GetInt("cowboy") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 4) { if (PlayerPrefs.GetInt("druid") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 5) { if (PlayerPrefs.GetInt("engcaptain") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 6) { if (PlayerPrefs.GetInt("geisha") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 7) { if (PlayerPrefs.GetInt("goblinchef") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 8) { if (PlayerPrefs.GetInt("goblinshaman") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 9) { if (PlayerPrefs.GetInt("goblinwarrior") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 10) { if (PlayerPrefs.GetInt("grunt") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 11) { if (PlayerPrefs.GetInt("gypsy") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 12) { if (PlayerPrefs.GetInt("iskeletor") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 13) { if (PlayerPrefs.GetInt("iskeletorsoldier1") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 14) { if (PlayerPrefs.GetInt("iskeletorsoldier2") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 15) { if (PlayerPrefs.GetInt("iskeletorwarrior") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 16) { if (PlayerPrefs.GetInt("king") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 17) { if (PlayerPrefs.GetInt("knight") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 18) { if (PlayerPrefs.GetInt("kuin") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 19) { if (PlayerPrefs.GetInt("piratecaptain") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 20) { if (PlayerPrefs.GetInt("rogue") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 21) { if (PlayerPrefs.GetInt("rockgolem") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 22) { if (PlayerPrefs.GetInt("samurai") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 23) { if (PlayerPrefs.GetInt("sherif") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 24) { if (PlayerPrefs.GetInt("sorcerer") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 25) { if (PlayerPrefs.GetInt("viking") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 26) { if (PlayerPrefs.GetInt("vikingwarrior") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 27) { if (PlayerPrefs.GetInt("villageman") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 28) { if (PlayerPrefs.GetInt("warrior") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 29) { if (PlayerPrefs.GetInt("witch") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[PlayerPrefs.GetInt("secimgorunme") + 1].SetActive(false); }
        if (PlayerPrefs.GetInt("secimgorunme") == 30) { if (PlayerPrefs.GetInt("wizard") == 1) { kbt[PlayerPrefs.GetInt("secimgorunme")].SetActive(true); } kbt[PlayerPrefs.GetInt("secimgorunme") - 1].SetActive(false); kbt[0].SetActive(false); }

    }
}
