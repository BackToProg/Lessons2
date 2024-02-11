using UnityEngine;

namespace Task2_NPC_.Scripts
{
    public class InputHandler: MonoBehaviour
    {
        public IPoint MoveTarget { get; private set; }

        public void ClearMoveTarget() => MoveTarget = null;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                MoveTarget = new WorkPoint();
            }
            
            if (Input.GetKeyDown(KeyCode.S))
            {
                MoveTarget = new HomePoint();
            }
        }
    }
}