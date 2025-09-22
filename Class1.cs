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
            var env = FindEnviroment(); 
            if (env != null)
                env.SetActive(!env.activeSelf);
            else
                Logger.LogInfo("Enviroment not found (probably not in Photo Mode).");
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
