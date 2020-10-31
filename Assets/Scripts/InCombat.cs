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
            playerController.PlayerCinemachineCameraObjects[0].SetActive(true);
            playerController.CombatAiming.enabled.Equals(true);
            return base.Start();
        }

        public override IEnumerator Update()
        {
            return base.Update();
        }

        public override IEnumerator ExitState()
        {
            playerController.PlayerCinemachineCameraObjects[0].SetActive(false);
            playerController.CombatAiming.enabled.Equals(false);
            return base.ExitState();
        }
    }
}