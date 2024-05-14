using UnityEngine;

namespace Runtime.CH1.Main
{
    [System.Serializable]
    public class LocationArray
    {
        public Vector3[] Locations;
    }

    // 세이브 데이터 불러올 때 달러, 파머, 알투몬 위치
    public class NpcPosition : MonoBehaviour
    {
        [SerializeField] private GameObject[] _npcs;
        public LocationArray[] NpcLocations;
        // 0:초기 1:씬1 이후 2:씬2 시작 3:씬2 이동자리

        public void LoadNpcPosition()
        {
            Debug.Log("NpcPosition:");
            if (Managers.Data.Scene == 0)
            {
                SetNpcPosition(0);
                Debug.Log("초기 세팅");
            }
            if (Managers.Data.Scene == 1)
            {
                SetNpcPosition(1);
                Debug.Log("씬1으로 세팅");
            }
        }

        public void SetNpcPosition(int idx)
        {
            for (int i=0; i<_npcs.Length; i++)
            {
                _npcs[i].transform.position = NpcLocations[i].Locations[idx];
            }
        }
    }
}