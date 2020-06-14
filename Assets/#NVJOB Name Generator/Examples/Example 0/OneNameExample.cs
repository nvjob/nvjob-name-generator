using UnityEngine;
using UnityEngine.UI;

public class OneNameExample : MonoBehaviour
{
    public int typeName;

    void OnEnable()
    {
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

        GetComponent<Text>().text = NVJOBNameGen.Uppercase(name);

        // NVJOBNameGen.Uppercase() - Get the first letter of the string in uppercase.
        // Example: curName.text = NVJOBNameGen.Uppercase("anna");
    }

}
