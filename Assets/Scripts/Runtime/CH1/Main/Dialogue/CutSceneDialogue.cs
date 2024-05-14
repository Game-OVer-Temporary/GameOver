using Runtime.CH1.Main.Player;
using Runtime.CH1.Main;
using UnityEngine;
using DG.Tweening;
using Runtime.ETC;

public class CutSceneDialogue : MonoBehaviour
{
    public NpcPosition NpcPos;
    [Header("=Player=")]
    [SerializeField] public TopDownPlayer Player;
    [SerializeField] private Vector3 _location;
    [Header("=Npc=")]
    [SerializeField] private Npc[] _npc = new Npc[3];
    [Header("=Mamago=")]
    [SerializeField] private Npc _mamago;
    [SerializeField] private Vector3[] _mamagoLocation;
    [Header("=Else=")]
    [SerializeField] private GameObject _illerstrationParent;
    [SerializeField] private GameObject[] _illerstration = new GameObject[1];
    [SerializeField] private GameObject _lucky;
    [SerializeField] private GameObject _stage2;
    [SerializeField] private BridgeController _bridge;
    private Sequence _shakeTween;

    public void GetTranslationPack()
    {
        Managers.Data.HaveTranslationPack = true;
    }

    public void PanpareSFX()
    {
        Managers.Sound.Play(Sound.SFX, "PanpareSFX");
    }

    public void MamagoJump()
    {
        Vector3 nowPos = _mamago.transform.position;
        _mamago.transform.DOJump(nowPos, 0.3f, 1, 0.4f).SetEase(Ease.Linear);
    }

    public void MamagoMove1()
    {
        string state = PlayerState.Move.ToString();

        _mamago.Anim.SetAnimation(state, Vector2.right);
        _mamago.transform.DOMove(_mamagoLocation[0], 3f).SetEase(Ease.Linear);
    }

    public void MamagoMove2()
    {
        string state = PlayerState.Move.ToString();

        _mamago.Anim.SetAnimation(state, Vector2.up);
        _mamago.transform.DOMove(_mamagoLocation[1], 1f).SetEase(Ease.Linear);
    }

    public void MamagoEnter()
    {
        _mamago.gameObject.SetActive(false);
    }

    public void SetNpcPosition(int i)
    {
        if (i == 0) // 3매치 깬 후 위치
        {
            NpcPos.SetNpcPosition(5);
        }
        else if (i == 1) // 맵3 위치
        {
            NpcPos.SetNpcPosition(7);
        }
    }

    public void BreakBridge()
    {
        Managers.Sound.Play(Sound.SFX, "Boom Sfx");
        _bridge.ActiveBrokenBridge();
    }

    public void ShakeMap(bool shake)
    {
        if (shake)
        {
            _shakeTween = DOTween.Sequence();
            _shakeTween.Append(_stage2.transform.DOShakePosition(5000f, new Vector3(0.1f, 0.1f, 0)));
        }
        else
        {
            _shakeTween.Kill();
        }
    }

    #region Character Anim
    public void NpcJump(int idx)
    {
        Vector3 nowPos = _npc[idx].transform.position;

        _npc[idx].transform.DOJump(nowPos, 0.3f, 1, 0.4f).SetEase(Ease.Linear);
    }

    public void CharactersMove(int num)
    {
        switch (num)
        {
            case 1:
                CharactersMove1();
                break;
            case 2:
                CharactersMove2();
                break;
            case 3:
                CharactersMove3();
                break;
            case 4:
                CharactersMove4();
                break;
            default:
                Debug.LogError("Invalid Move Number");
                break;
        }
    }

    private void CharactersMove4()
    {
        // 라플리 빼고 맵3으로
        for (int i = 0; i < _npc.Length; i++)
        {
            string state = PlayerState.Move.ToString();
            _npc[i].Anim.SetAnimation(state, Vector2.right);
            _npc[i].transform.DOMove(NpcPos.NpcLocations[i].Locations[6], 5f).SetEase(Ease.Linear);
        }
    }

    private void CharactersMove3()
    {
        // 라플리 빼고 다리 건너기
        for (int i = 0; i < _npc.Length; i++)
        {
            string state = PlayerState.Move.ToString();
            _npc[i].Anim.SetAnimation(state, Vector2.right);
            _npc[i].transform.DOMove(NpcPos.NpcLocations[i].Locations[4], 5f).SetEase(Ease.Linear);
        }
    }

    private void CharactersMove2()
    {
        // 라플리 빼고 동굴 앞으로 이동
        for (int i = 0; i < _npc.Length; i++)
        {
            string state = PlayerState.Move.ToString();
            _npc[i].Anim.SetAnimation(state, Vector2.right);
            _npc[i].transform.DOMove(NpcPos.NpcLocations[i].Locations[3], 5f).SetEase(Ease.Linear);
        }
    }

    private void CharactersMove1()
    {
        string state = PlayerState.Move.ToString();

        Player.Animation.SetAnimation(state, Vector2.right);
        Player.transform.DOMove(_location, 5f).SetEase(Ease.Linear);

        for (int i = 0; i < _npc.Length; i++)
        {
            _npc[i].Anim.SetAnimation(state, Vector2.right);
            _npc[i].transform.DOMove(NpcPos.NpcLocations[i].Locations[1], 5f).SetEase(Ease.Linear);
        }
    }

    public void CharactersStop(int num)
    {
        switch (num)
        {
            case 1:
                CharactersStop1();
                break;
            case 2:
                CharactersStop2();
                break;
            case 3:
                CharactersStop3();
                break;
            default:
                Debug.LogError("Invalid Move Number");
                break;
        }
    }

    public void CharactersStop3()
    {
        string state = PlayerState.Idle.ToString();

        for (int i = 0; i < 3; i++)
        {
            _npc[i].Anim.SetAnimation(state, Vector2.down);
        }
    }

    public void CharactersStop2()
    {
        string state = PlayerState.Idle.ToString();

        for (int i = 0; i < 3; i++)
        {
            _npc[i].Anim.SetAnimation(state, Vector2.left);
        }
    }

    public void CharactersStop1()
    {
        string state = PlayerState.Idle.ToString(); // 하나로 옮기기

        Player.Animation.SetAnimation(state, Vector2.down);

        _npc[0].Anim.SetAnimation(state, Vector2.right);
        _npc[1].Anim.SetAnimation(state, Vector2.up);
        _npc[2].Anim.SetAnimation(state, Vector2.left);
    }
    #endregion

    #region else
    public void GetLucky()
    {
        Managers.Sound.Play(Sound.SFX, "[Ch1] Lucky_SFX_Dog&Key");
        _lucky.SetActive(false);
        Managers.Data.MeetLucky = true;
        Managers.Data.SaveGame();
    }

    public void ShowIllustration(int num)
    {
        _illerstrationParent.SetActive(true);

        for (int i = 0; i < _illerstration.Length; i++)
        {
            if (i == num)
                _illerstration[i].SetActive(true);
            else
                _illerstration[i].SetActive(false);
        }
    }

    public void HideIllustration()
    {
        _illerstrationParent.SetActive(false);
    }
    #endregion

}
