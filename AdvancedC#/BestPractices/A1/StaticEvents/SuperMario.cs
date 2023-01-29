using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class SuperMario
    {
        public delegate void Mushroom( int a_mushroomPoint );
        public event Mushroom GainedMushroom; 

        public void GainSpecialStar( int a_point )
        {
            GainedMushroom?.Invoke( a_point );
        }
    }
    
    public class Music
    {
        private List<int> musicIds = new List<int>() { 0, 1, 2 };
        private int m_currentMusicId = 0;

        public void ChangeMusic( int a_point )
        {
            var index = a_point / 10;
            m_currentMusicId = musicIds[index];
            
            Console.WriteLine( $"Current music id is  {m_currentMusicId}" );
        }
    }

    public class Speed
    {
        private int m_currentSpeed = 2;
        public void SpeedUp( int a_point )
        {
            m_currentSpeed *= a_point;  
            Console.WriteLine( $"{ m_currentSpeed} is the new speed of the hero" );
        }
    }
}
