using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinMovementSystem
{
    public interface IState
    {

        public void StateEnter();
        public void StateExit();

        //  If u want core, u can use ICore?
        public void StateCore();

        public void StateFixedCore();
    }
}
