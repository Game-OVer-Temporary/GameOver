using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ArioManager : MonoBehaviour
{
    #region instance

    public static ArioManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    #endregion

    public delegate void OnPlay(bool isPlay);
    public OnPlay onPlay;
    [SerializeField] private ArioUIController ui;

    public float gameSpeed = 1;
    public bool isPlay;
    private GameObject startText;
    private string stageInfo;
    private int coinCnt;

    private void Start()
    {
        StartCoroutine(WaitStart());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !isPlay)
            StartGame();
    }
    
    private IEnumerator WaitStart()
    {
        yield return new WaitForSeconds(0.5f);
        StartGame();
    }

    private void StartGame()
    {
        stageInfo = "WORLD\n1-1";
        ui.ChangeCoinText("RAPLEY\n" + coinCnt);
        ui.ChangeStageText(stageInfo);
        ui.ActiveRestartText(false);
        ui.ChangeItemSprite(false);
        ChangeHeartUI(1);
        isPlay = true;
        onPlay.Invoke(isPlay);
    }

    private void GameOver()
    {
        ui.ActiveRestartText(true);
        isPlay = false;
        onPlay.Invoke(isPlay);
    }

    public void ChangeHeartUI(int life)
    {
        ui.ChangeHeartUI(life);
        if(life == 0)
            GameOver();
    }

    public void GetCoin()
    {
        coinCnt++;
        ui.ChangeCoinText("RAPLEY\n" + coinCnt);
    }
}