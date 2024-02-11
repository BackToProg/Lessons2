using Task3_Mediator_.Scripts.Player;

namespace Task3_Mediator_.Scripts
{
    public class Level
    {
        public Level(Character character)
        {
            Character = character;
        }
        
        public Character Character { get; private set; }

        public void Start()
        {
            Character.ResetData();
        }

        public void Restart()
        {
            Start();
        }
    }
}
