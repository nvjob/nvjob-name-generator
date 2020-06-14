using System.Collections;
using UnityEngine;

public class TextMeshName : MonoBehaviour
{
    public int typeName;
    TextMesh curName;

    void Awake()
    {
        curName = GetComponent<TextMesh>();
        StartCoroutine(ChName());
    }

    IEnumerator ChName()
    {
        while (true)
        {
            string name = NVJOBNameGen.GiveAName(typeName);
            curName.text = name.ToUpper(); // string.ToUpper() - Uppercase all letters

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

            yield return new WaitForSeconds(3.0f);
        }
    }

}
