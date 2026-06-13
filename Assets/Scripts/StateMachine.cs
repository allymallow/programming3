using System;
using Player_States;

[Serializable]
public class StateMachine 
{
    private PlayerController _playerController;
    public IState CurrentState { get; private set; }
    
    public WalkState WalkState;
    public IdleState IdleState;
    public RunState RunState;
    public HidingState HidingState;
    
    public void Initialize(IState startingState)
    {
        CurrentState = startingState;
        startingState.Enter();
    }

    public void Transition(IState nextState)
    {
        CurrentState?.Exit();
        CurrentState = nextState;
        nextState?.Enter();
    }

    public void ExecuteState()
    {
        if (CurrentState != null)
        {
            CurrentState.Execute();
        }
    }

    public StateMachine(PlayerController player)
    {
        this.WalkState = new WalkState(player);
        this.IdleState = new IdleState(player);
        this.RunState = new RunState(player);
        this.HidingState = new HidingState(player);
    }
}
