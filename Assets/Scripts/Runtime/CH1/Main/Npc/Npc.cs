using Runtime.Interface;
using UnityEngine;

namespace Runtime.CH1.Main
{
    public class Npc : MonoBehaviour
    {
        private SpriteRenderer _spriteRenderer;
        private NpcInteraction _interaction;
        public IAnimation Anim { get; private set; }

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _interaction = GetComponent<NpcInteraction>();
            Anim = new NpcAnimation(GetComponent<Animator>());

            // 현재 방향을 알아야 함
            // _interaction.OnInteract += (direction) => _spriteRenderer.flipX = direction.x < 0;
        }
    }
}
