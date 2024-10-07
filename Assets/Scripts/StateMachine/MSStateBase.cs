using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinMovementSystem
{
    public abstract class MSStateBase : IState
    {
        public void StateCore()
        {
            OnStateCore();
        }

        public void StateEnter()
        {
            OnStateEnter();
        }

        public void StateExit()
        {
            OnStateExit();
        }

        public void StateFixedCore()
        {
            OnStateFixedCore();
        }


        protected virtual void OnStateCore() {; }

        protected virtual void OnStateFixedCore() {; }

        protected virtual void OnStateEnter() {; }

        protected virtual void OnStateExit() {; }
    }
}
