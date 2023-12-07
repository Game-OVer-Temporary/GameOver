using Runtime.ETC;
using System.Collections;
using UnityEngine;

namespace Runtime.CH1.Pacmom
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class Pacmom : MonoBehaviour
    {
        public PacmomGameController gameController;
        public Movement movement;
        public bool isVacuumMode = false;

        private SpriteAnimation spriteAnim;
        private SpriteRenderer spriteRenderer;

        [SerializeField]
        private Sprite vacuumSpr;
        [SerializeField]
        private Sprite[] dieSpr;

        private void Awake()
        {
            spriteAnim = GetComponent<SpriteAnimation>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Start()
        {
            movement.spriteRotation.canRotate = true;
            movement.spriteRotation.canFlip = true;

            ResetState();
        }

        public void ResetState()
        {
            if (gameObject.activeInHierarchy == false)
            {
                gameObject.SetActive(true);
            }
            movement.ResetState();
        }

        private void FixedUpdate()
        {
            movement.Move();
        }

        public void VacuumMode(bool mode)
        {
            SetRotateToZero();

            isVacuumMode = mode;
            movement.spriteRotation.canRotate = !isVacuumMode;

            if (isVacuumMode)
            {
                spriteAnim.enabled = false;
                spriteRenderer.sprite = vacuumSpr;
            }
            else
            {
                spriteAnim.enabled = true;
                spriteAnim.RestartAnim();
            }
        }

        public void PacmomDead()
        {
            StartCoroutine("DeadAnim");
        }

        private IEnumerator DeadAnim()
        {
            SetRotateToZero();

            spriteAnim.enabled = false;

            movement.speed = 0;
            movement.enabled = false;

            for (int i=0; i<dieSpr.Length; i++)
            {
                spriteRenderer.sprite = dieSpr[i];
                yield return new WaitForSeconds(0.3f);
            }
        }

        private void SetRotateToZero()
        {
            transform.rotation = Quaternion.Euler(Vector3.zero);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Step step = other.GetComponent<Step>();

            if (step != null)
            {
                int index = Random.Range(0, step.availableDirections.Count);

                // 거꾸로 가기 방지
                if (step.availableDirections[index] == -1 * movement.direction && step.availableDirections.Count > 1)
                {
                    index++; // 랜덤으로 대신 +1

                    if (index >= step.availableDirections.Count)
                        index = 0;
                }

                movement.SetNextDirection(step.availableDirections[index]);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer(GlobalConst.PlayerStr))
            {
                if (isVacuumMode)
                {
                    gameController.RapleyEaten();
                }
                else
                {
                    gameController.PacmomEaten();
                }
            }
        }
    }
}
