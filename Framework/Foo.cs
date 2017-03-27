using Framework.Properties;

namespace Framework
{
    public class Foo : IFoo
    {
        public virtual string GiveMeAFoo()
        {
            return Resources.Foo1;
        }

        public virtual string[] GiveMeTwoFoos()
        {
            return new[] { Resources.Foo1, Resources.Foo2 };
        }
    }
}
