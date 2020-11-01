using System;
using System.Collections;

namespace StateStuff
{
    public class InCombat : State
    {
        public InCombat(PlayerController playerController) : base(playerController)
        {
        }

        public event Action OnEnterCombat;

        public override IEnumerator Start()
        {
            //Not properly enabling/disabling gameobjects and components in any state. 
            OnEnterCombat?.Invoke();
            playerController.PlayerCinemachineCameras[0].enabled = true;
            //playerController.CombatAiming.enabled = true;
            return base.Start();
        }

        public override IEnumerator Update()
        {
            return base.Update();
        }

        public override IEnumerator ExitState()
        {
            playerController.PlayerCinemachineCameras[0].enabled = false;
            //playerController.CombatAiming.enabled = false;
            return base.ExitState();
        }
    }
}