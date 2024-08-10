using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class TurnController : MonoBehaviour
{
    [SerializeField] private DialogueRunner _dialogueRunner;
    [SerializeField] private CH2UI _ch2Ui;
    private List<Dictionary<string, object>> _data = new();
    [SerializeField] private int _turn = 0;
    [SerializeField] string _location = null;

    private void Awake()
    {
        _data = CSVReader.Read("BIC_Move");
        _ch2Ui.TurnController = this;
    }

    public void GetInitialLocation()
    {
        List<string> loc = GetAvailableLocations();
        if (loc.Count != 1)
        {
            Debug.LogError("Location is not unique.");
        }

        AdvanceTurnAndMoveLocation(loc[0]);
    }

    public void AdvanceTurnAndMoveLocation(string location)
    {
        _turn++;
        _location = location;
        _ch2Ui.SetLocationTxt(_location);
        InitiateDialogue();
    }

    private void InitiateDialogue()
    {
        _dialogueRunner.StartDialogue(GetDialogueName());
    }

    private string GetDialogueName()
    {
        // 현재 턴수와 장소에 맞는 다이얼로그 이름 가져오기
        foreach (var row in _data)
        {
            if (row.ContainsKey("Turn") && (int)row["Turn"] == _turn)
            {
                if (row.ContainsKey(_location))
                {
                    return row[_location].ToString();
                }
            }
        }
        return null;
    }

    private List<string> GetAvailableLocations()
    {
        // 이동 가능한 장소 리스트 가져오기
        List<string> loc = new();

        foreach (var row in _data)
        {
            if (row.ContainsKey("Turn") && (int)row["Turn"] == _turn + 1)
            {
                foreach (var col in row)
                {
                    if (col.Value is string value && value != "X" && value != (_turn + 1).ToString())
                    {
                        loc.Add((string)col.Key);
                    }
                }
            }
        }

        return loc;
    }

    public void DisplayAvailableLocations()
    {
        _ch2Ui.SetLocationOptions(GetAvailableLocations());
    }
}