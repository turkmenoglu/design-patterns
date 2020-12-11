using FactoryMethod2.Abstract;

namespace FactoryMethod2.Concrete
{
    public class WinScreenCreator : ScreenCreator
    {
        public override Screen Create()
        {
            return new WinScreen();
        }
    }
}
