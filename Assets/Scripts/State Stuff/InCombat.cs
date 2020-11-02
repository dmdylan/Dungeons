using System;
using System.Collections;

namespace StateStuff
{
    public class InCombat : State
    {
        public InCombat(PlayerController playerController) : base(playerController)
        {
        }

        public override IEnumerator Start()
        {
            playerController.PlayerCinemachineCameras[0].enabled = true;
            return base.Start();
        }

        public override IEnumerator Update()
        {
            return base.Update();
        }

        public override IEnumerator ExitState()
        {
            playerController.PlayerCinemachineCameras[0].enabled = false;
            return base.ExitState();
        }
    }
}