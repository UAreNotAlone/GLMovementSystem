using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenshinMovementSystem
{
    public class PlayerMovementStateMachine : MSStateMachineBase<PlayerMovementState>
    {
        #region Properties
        public PlayerIdleState IdlingState { get { return _idlingState; } }
        public PlayerRunningState RunningState { get { return _runningState; } }
        public PlayerSprintingState SprintingState { get { return _sprintingState; } }
        public PlayerWalkingState WalkingState { get { return _walkingState; } }
        #endregion Properties


        #region Fields
        private readonly PlayerIdleState _idlingState;
        private readonly PlayerRunningState _runningState;
        private readonly PlayerSprintingState _sprintingState;
        private readonly PlayerWalkingState _walkingState;
        #endregion Fields

        public PlayerMovementStateMachine()
        {
            _idlingState = new PlayerIdleState();
            _runningState = new PlayerRunningState();
            _sprintingState = new PlayerSprintingState();
            _walkingState = new PlayerWalkingState();
        }

        public void HandleInput()
        {
            _currentState?.HandleInput();
        }

    }
}
