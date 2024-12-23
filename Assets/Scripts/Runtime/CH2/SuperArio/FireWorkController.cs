using System;
using System.Collections;
using UnityEngine;

namespace Runtime.CH2.SuperArio
{
    public class FireworkController : MonoBehaviour
    {
        private Transform[] _fireworks;

        private void Awake()
        {
            _fireworks = new Transform[4];
            for (int i = 0; i < 4; i++)
            {
                _fireworks[i] = transform.GetChild(i);
            }
        }

        public void PlayFireworks()
        {
            int lastDigit = ArioManager.instance.CoinCnt % 10; // 1의 자릿수 구하기
            int repeatCount = 1; // 기본 반복 횟수

            // 1의 자릿수에 따라 반복 횟수 결정
            if (lastDigit >= 6)
                repeatCount = 6;
            else if (lastDigit >= 3)
                repeatCount = 3;
            else if (lastDigit >= 0)
                repeatCount = 1;

            StartCoroutine(FireworkSequence(repeatCount));
        }

        private IEnumerator FireworkSequence(int repeatCount)
        {
            yield return new WaitForSeconds(1.5f);
            
            for (int i = 0; i < repeatCount; i++)
            {
                // 4개의 자식 오브젝트를 순환하면서 활성화
                int fireworkIndex = i % 4;
            
                _fireworks[fireworkIndex].gameObject.SetActive(true);
            
                yield return new WaitForSeconds(0.5f);
            }

            yield return new WaitForSeconds(1f);
        
            foreach (Transform firework in _fireworks)
            {
                firework.gameObject.SetActive(false);
            }
            
            // 보상방 이동
            ArioManager.instance.EnterReward();
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Ario ario))
            {
                PlayFireworks();
            }
        }
    }
}