using Mirror;

namespace StateStuff
{
    public abstract class PlayerStateMachine : NetworkBehaviour
    {
        protected State state;
        
        public void SetState(State state)
        {
            this.state = state;
            StartCoroutine(this.state.Start());
        }
    }
}
