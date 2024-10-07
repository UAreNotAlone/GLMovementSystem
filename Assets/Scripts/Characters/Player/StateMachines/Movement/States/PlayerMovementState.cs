using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovementSystem
{
    public class PlayerMovementState : MSStateBase
    {

        public void HandleInput()
        {
            OnHandleInput();
        }

        protected virtual void OnHandleInput() {; }

    }
}
