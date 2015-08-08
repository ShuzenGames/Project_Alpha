using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Project_Alpha
{
    public class BaseUI
    {

        public float Id { get; private set; }

        public Vector2 Pos { get; private set; }

        public bool Hidden { get; private set; }

        public bool Active { get; private set; }

        public BaseUI()
        {
            
        }

        public virtual void Init() 
        {
            
        }

        public virtual void Update()
        {

        }

        public virtual void Draw()
        {

        }

        public virtual void OnLoad()
        {

        }

    }
}
