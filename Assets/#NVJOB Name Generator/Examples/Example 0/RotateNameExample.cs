using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RotateNameExample : MonoBehaviour
{
    [Header("Normal English Names")]
    public bool femaleOld;
    public bool femaleNew;
    public bool maleOld;
    public bool maleNew;
    [Header("Fantastic names")]
    public bool scifi;
    public bool femaleFantasy;
    public bool maleFantasy;

    Text curName;
    int typeName;

    void Awake()
    {
        curName = GetComponent<Text>();
        StartCoroutine(ChName());        
    }

    IEnumerator ChName()
    {
        while (true)
        {
            if (femaleOld == true) typeName = 1;
            else if (femaleNew == true) typeName = 2;
            else if (maleOld == true) typeName = 3;
            else if (maleNew == true) typeName = 4;
            else if (femaleFantasy == true) typeName = 5;
            else if (maleFantasy == true) typeName = 6;
            else if (scifi == true) typeName = 7;
            else typeName = 0;

            string name = NVJOBNameGen.GiveAName(typeName);

            // NVJOBNameGen.GiveAName(typeName). typeName - Get the name according to the selected type.
            // typeName:
            // 1 - Female Old Name
            // 2 - Female New Name
            // 3 - Male Old Name
            // 4 - Male New Name
            // 5 - Female Fantasy Name
            // 6 - Male Fantasy Name
            // 7 - Sci Fi Name
            // 8 > - Over time, new types of names will be added
            // Example: curName.text = NVJOBNameGen.GiveAName(1);

            curName.text = NVJOBNameGen.Uppercase(name);

            // NVJOBNameGen.Uppercase() - Get the first letter of the string in uppercase.
            // Example: curName.text = NVJOBNameGen.Uppercase("anna");

            yield return new WaitForSeconds(2.0f);
        }

    }
}
