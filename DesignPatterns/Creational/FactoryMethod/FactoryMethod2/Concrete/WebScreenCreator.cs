using FactoryMethod2.Abstract;

namespace FactoryMethod2.Concrete
{
    public class WebScreenCreator : ScreenCreator
    {
        public override Screen Create()
        {
            return new WebScreen();
        }
    }
}
