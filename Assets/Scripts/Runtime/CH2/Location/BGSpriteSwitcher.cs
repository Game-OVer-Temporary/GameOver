using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Runtime.CH2.Location
{
    public class BGSpriteSwitcher : MonoBehaviour
    {
        [SerializeField] private Image _bgImg;
        [SerializeField] private TextMeshProUGUI _locationTxt;
        [SerializeField] private Sprite[] _bgSprites;
        private Dictionary<string, string> _locationTexts = new Dictionary<string, string>
        {
            { "Entrance", "마을 입구" },
            { "Square", "광장" },
            { "Temple", "신전" },
            { "Statue", "달러 동상" },
            { "Cave", "동굴" },
            { "Base", "기지" },
            { "Storage", "창고" },
            { "In Storage", "창고 내부" },
            { "Temple Room", "신전 방" },
            { "Backstreet", "골목길" },
            { "DallorHouse", "달러의 집" },
            { "Passage", "통로" },
            { "In Statue", "달러 동상 내부" },
            { "StatueCrack", "달러 동상 틈새" }
        };

        private Dictionary<string, int> _locationSprites = new Dictionary<string, int>
        {
            { "Entrance", 0 },        // 마을 입구
            { "Square", 1 },          // 광장
            { "Temple", 2 },          // 신전
            { "Statue", 3 },          // 달러 동상
            { "Cave", 4 },            // 동굴
            { "Base", 5 },            // 기지
            { "Storage", 6 },         // 창고
            { "In Storage", 7 },      // 창고 내부
            { "Temple Room", 8 },     // 신전 방
            { "Backstreet", 9 },      // 골목길
            { "DallorHouse", 10 },    // 달러의 집
            { "Passage", 11 },        // 통로
            { "In Statue", 12 },      // 달러 동상 내부
            { "StatueCrack", 13 }     // 달러 동상 틈새
        };

        public void SetLocationUI()
        {
            string loc = Managers.Data.CH2.Location;

            if (_locationTexts.TryGetValue(loc, out string locationText))
            {
                _locationTxt.text = locationText;
            }
        }

        public void SetBG()
        {
            string loc = Managers.Data.CH2.Location;

            if (_locationSprites.TryGetValue(loc, out int spriteIndex) && spriteIndex < _bgSprites.Length)
            {
                _bgImg.sprite = _bgSprites[spriteIndex];
            }
        }
    }
}