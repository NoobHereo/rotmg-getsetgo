using UnityEngine;
using UnityEngine.UI;

public enum ClassType
{
    Rogue,
    Archer,
    Wizard,
    Priest,
    Warrior,
    Knight,
    Paladin,
    Assassin,
    Necromancer,
    Huntress,
    Mystic,
    Trickster,
    Sorcerer,
    Ninja,
    Samurai,
    Bard
}

public class PlayerClassButton : MonoBehaviour
{
    private Button _button;
    public ClassType Type;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(setSelectedClass);
    }

    private void setSelectedClass()
    {
        UIManager.Instance.SetPortrait(Type);
    }
}