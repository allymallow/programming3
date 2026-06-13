namespace Tic_States
{
    public class ActiveTicState : IState
    {
    
        private PlayerController _player;
        public ActiveTicState(PlayerController player)
        {
            this._player = player;
        }
        public void Enter()
        {
            
        }

        public void Execute()
        {
        
        }

        public void Exit()
        {
        
        }
    }
}
