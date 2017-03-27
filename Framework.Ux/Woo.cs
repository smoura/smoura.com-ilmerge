using Framework.Ux.Properties;

namespace Framework.Ux
{
    public class Woo : Foo
    {
        public override string GiveMeAFoo()
        {
            return Resources.Woo1;
        }

        public override string[] GiveMeTwoFoos()
        {
            return new[] { Resources.Woo1, Resources.Woo2 };
        }
    }
}
