﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._SCRIPTS.Story
{
    public class DialogLine : IDialog
    {
        public string Text { get; private set; }

        public DialogLine(string text)
        {
            Text = text;
        }

        public void Display(GameObject canvas, Vector2 position)
        {
            var newText = new GameObject("Text");
            newText.transform.SetParent(canvas.transform);

            var newTextComp = newText.AddComponent<Text>();
            newTextComp.text = Text;
            newTextComp.font = Font.CreateDynamicFontFromOSFont("Arial", 12);
            newTextComp.color = Color.black;
            newTextComp.fontSize = 16;
            newTextComp.transform.position = position;
            
            Debug.Log("No jest cos");
        }
    }
}
