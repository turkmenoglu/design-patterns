using FactoryMethod2.Abstract;

namespace FactoryMethod2.Concrete
{
    public class MobileScreenCreator : ScreenCreator
    {
        public override Screen Create()
        {
            return new MobileScreen();
        }
    }
}
