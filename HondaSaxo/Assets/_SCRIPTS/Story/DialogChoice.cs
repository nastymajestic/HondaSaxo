﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Experimental.UIElements;

namespace Assets._SCRIPTS.Story
{
    public class DialogChoice : IDialog
    {
        private List<Choice> _choices;

        public DialogChoice()
        {
            this._choices = new List<Choice>();
        }

        public void Display()
        {
        }
    }
}
