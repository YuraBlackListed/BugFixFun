using System;
using SFML.Graphics;
using SFML.Audio;
using ZelenskiyGame.KeyEventArgsExtensions;
using SFML.Window;
using System.Collections.Generic;
using System.Linq;


namespace ZelenskiyGame
{
    class Controller
    {
        public Controller(Hero HeroToControll, PlayerKeys PlayerInput)
        {
            hero = HeroToControll;
            InputKeys = PlayerInput;
            MoveDirection = new Dictionary<KeyEventArgs, Direction>()
            {
                {PlayerInput.up, Direction.up },
                {PlayerInput.down, Direction.down },
                {PlayerInput.left, Direction.left },
                {PlayerInput.right, Direction.right }
            };
        }

        private PlayerKeys InputKeys;
        private Hero hero;
        private Dictionary<KeyEventArgs, Direction> MoveDirection;
        
        public void Controll(KeyEventArgs e)
        {
            if (hero == null)
                return;

            CheckInputForMove(e, hero);

            if (e == InputKeys.shoot)
                hero.Shoot();
        }
        private void CheckInputForMove(KeyEventArgs reftypeKey, Hero hero)
        {
            KeyEventArgs valtypeKey = MoveDirection.Keys.Cast<KeyEventArgs>().ToArray().GetContainsByVatuesKey(reftypeKey);
            if (valtypeKey == null)
                return;

            hero.body.direction = MoveDirection[valtypeKey];

            hero.Move();
        }

        
    }
}
