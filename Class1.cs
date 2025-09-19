using BepInEx;
using UnityEngine;

[BepInPlugin("KomiroFT.PhotoModeCharacterToggler", "PhotoModeCharacterToggler", "1.0.1")]
public class Plugin : BaseUnityPlugin
{
    GameObject pmct;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (pmct == null)
                pmct = FindEnviroment();
            if (pmct != null)
                pmct.SetActive(!pmct.activeSelf);
        }
    }

    GameObject FindEnviroment()
    {
        foreach (var go in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            if (go.name == "Enviroment")
                return go;
        }
        return null;
    }
}
