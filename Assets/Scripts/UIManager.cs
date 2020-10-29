using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Sprite[] ClassPortraits = new Sprite[16];
    public static UIManager Instance;
    public Sprite ClassPortrait;
    public TextMeshProUGUI SelectedClassText;

    private void Start()
    {
        Instance = this;
    }

    public void SetPortrait(ClassType classType)
    {
        int spriteId = (int)classType;
        SelectedClassText.text = "Playing as " + classType;
        ClassPortrait = ClassPortraits[spriteId];
    }

    public Sprite GetIcon()
    {
        if (ClassPortrait == null)
            Debug.Log("Portrait not set yet");

        return ClassPortrait;
    }
}