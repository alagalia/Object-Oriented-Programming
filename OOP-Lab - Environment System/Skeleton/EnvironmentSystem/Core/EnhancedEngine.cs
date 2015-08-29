using System;
using EnvironmentSystem.Interfaces;
using EnvironmentSystem.Models;

namespace EnvironmentSystem.Core
{
    public class EnhancedEngine : Engine
    {
        private IController controller;
        private bool IsPaused;

        public EnhancedEngine(IController controller)
            :base()
        {
            this.controller = controller;
            this.AttachContolEvent();
        }

        private void AttachContolEvent()
        {
            this.controller.Pause += controller_Pause;
        }

        void controller_Pause(object sender, EventArgs e)
        {
            this.IsPaused = !IsPaused;
        }

        protected override void ExecuteEnvironmentLoop()
        {
            this.controller.ProcessInput();
            if (!this.IsPaused)
            {
                base.ExecuteEnvironmentLoop();                
            }
        }

        public override void Run()
        {
            base.Run();
        }

        protected override void Insert(EnvironmentObject obj)
        {
            if (obj==null)
            {
                throw new ArgumentNullException("obj","Object cannot be null!");
            }
            base.Insert(obj);
        }
    }
}
