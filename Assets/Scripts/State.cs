using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateStuff
{
    public abstract class State
    {
        //Need reference field to pass to other state related classes
        //Set it up with public constructor
        protected PlayerController playerController; 

        public State(PlayerController playerController)
        {
            this.playerController = playerController;
        }

        public virtual IEnumerator Start()
        {
            yield break;
        }

        public virtual IEnumerator Update()
        {
            yield break;
        }

        public virtual IEnumerator ExitState()
        {
            yield break;
        }
    }
}