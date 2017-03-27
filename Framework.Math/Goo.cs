using Framework.Math.Properties;

namespace Framework.Math
{
    public class Goo : Foo
    {
        public override string GiveMeAFoo()
        {
            return Resources.Goo2;
        }

        public override string[] GiveMeTwoFoos()
        {
            return new[] { Resources.Goo1, Resources.Goo2 };
        }
    }
}
