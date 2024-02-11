using UnityEngine;

namespace Task2_NPC_.Scripts
{
    public class HomePoint : IPoint
    {
        public Vector3 Position { get; } = new(0,1,0);
    }
}