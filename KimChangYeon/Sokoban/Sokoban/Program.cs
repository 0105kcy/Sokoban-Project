﻿using Sokoban;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;
using System.Xml;

namespace sokoban
{
    class Program
    {
        static void Main()
        {
            GameSet.SetGame();
            Render.RenderTitle();
            
            GameScene.Scene1();

        }
    }
}

