namespace GenshinMovementSystem
{
    public abstract class MSStateMachineBase<T> : ICore where T : IState
    {
        #region Field
        protected T _currentState;
        #endregion Field
        #region Properties
        //  Properties
        public T CurrentState { get { return _currentState; } }
        #endregion Properties

        public void ChangeState(T newState)
        {
            if (_currentState != null)
            {
                _currentState.StateExit();
            }

            _currentState = newState;
            if(_currentState != null)
            {
                _currentState.StateEnter();
            }
        }

        #region Interface
        public void Core()
        {
            OnCore();
        }

        public void FixedCore()
        {
            OnFixedCore();
        }

        public void Enable()
        {
            OnEnable();
        }

        public void Disable()
        {
            OnDisable();
        }
        #endregion Interface

        protected virtual void OnEnable()
        {

        }

        protected virtual void OnDisable()
        {
            ChangeState(null);
        }

        protected virtual void OnCore()
        {
            _currentState?.StateCore();
        }

        protected virtual void OnFixedCore()
        {
            _currentState?.StateFixedCore();
        }
    }
}
