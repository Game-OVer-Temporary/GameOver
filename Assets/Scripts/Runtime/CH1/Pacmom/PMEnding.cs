using Runtime.InGameSystem;
using System.Collections;
using UnityEngine;

namespace Runtime.CH1.Pacmom
{
    public class PMEnding : MonoBehaviour
    {
        [SerializeField]
        private SceneSystem sceneSystem;
        [SerializeField]
        private PMShader PMShader;
        [SerializeField]
        private GameObject Timeline_3;
        [SerializeField]
        private SpriteControl[] spriteControls = new SpriteControl[6];
        public bool isGameClear { get; private set; } // 저장 필요

        public void RapleyWin()
        {
            Debug.Log("라플리 승리");
            Timeline_3.SetActive(true);
            isGameClear = true;
        }

        public void PacmomWin()
        {
            Debug.Log("팩맘 승리");
            Time.timeScale = 0;
            StartCoroutine("ToMain");
        }

        public void GetAllNormalSprite()
        {
            for (int i = 0; i < spriteControls.Length; i++)
            {
                spriteControls[i].GetNormalSprite();
            }
        }

        public void GetAllVacuumModeSprite()
        {
            for (int i = 0; i < spriteControls.Length; i++)
            {
                spriteControls[i].GetVacuumModeSprite();
            }
        }

        IEnumerator ToMain()
        {
            Time.timeScale = 0;
            PMShader.ChangeBleedAmount();

            yield return new WaitForSecondsRealtime(3f);

            Time.timeScale = 1f;
            sceneSystem.LoadScene("Main");
        }
    }
}