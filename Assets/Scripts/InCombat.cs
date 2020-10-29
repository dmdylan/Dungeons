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
            playerController.PlayerCinemachineCameraObjects[0].SetActive(true);
            return base.Start();
        }

        public override IEnumerator Update()
        {
            return base.Update();
        }

        public override IEnumerator ExitState()
        {
            playerController.PlayerCinemachineCameraObjects[0].SetActive(false);
            return base.ExitState();
        }
    }
}