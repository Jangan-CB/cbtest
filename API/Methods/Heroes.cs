using ClashBot.Execution.API.Wrappers;
using ClashBot.Execution.Data.Identifiers.Generic;
using ClashBot.Execution.Data.Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ClashBot.Execution.API.Methods
{
    class Heroes
    {
        public const Bitmap King = Properties.Resources.troopdeploy_King;

        public Hero get(Bitmap bitmap)
        {
            return new Hero(bitmap);
        }
    }
}
