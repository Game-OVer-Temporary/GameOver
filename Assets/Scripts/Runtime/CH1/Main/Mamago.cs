using UnityEngine;

namespace Runtime.CH1.Main
{
    public class Mamago : MonoBehaviour
    {
        public void CheckMamago()
        {
            if (Managers.Data.Scene <= 4)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }
}