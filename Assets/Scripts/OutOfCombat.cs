using System.Collections;
using System.Linq;

namespace StateStuff
{
    public class OutOfCombat : State
    {
        public OutOfCombat(PlayerController playerController) : base(playerController)
        {
        }

        public override IEnumerator Start()
        {
            //TODO: Not properly enabling and disabling game objects in either state
            playerController.PlayerCinemachineCameraObjects[1].SetActive(true);
            //TODO: Does out of combat really need a different input action map? What actions would be restricted?
            //playerController.PlayerInput.SwitchCurrentActionMap("OutOfCombat");
            return base.Start();
        }

        public override IEnumerator Update()
        {
            return base.Update();
        }

        public override IEnumerator ExitState()
        {
            playerController.PlayerCinemachineCameraObjects[1].SetActive(false);
            return base.ExitState();
        }
    }
}