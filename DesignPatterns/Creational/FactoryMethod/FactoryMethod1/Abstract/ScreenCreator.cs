using FactoryMethod1.Concrete;
using FactoryMethod1.Concrete.Enum;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FactoryMethod1.Abstract
{
    public class ScreenCreator
    {
        public Screen Create(ScreenType screenType)
        {
            //Screen screen = null;

            //switch (screenType)
            //{
            //    case ScreenType.Mobile:
            //        screen = new MobileScreen();
            //        break;
            //    case ScreenType.Web:
            //        screen = new WebScreen();
            //        break;
            //    case ScreenType.Win:
            //        screen = new WinScreen();
            //        break;
            //    default:
            //        break;
            //}

            //return screen;

            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == $"{screenType}Screen");
            Screen screen = Activator.CreateInstance(type) as Screen;
            return screen;
        }
    }
}
