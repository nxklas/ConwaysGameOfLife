namespace ConwaysGameOfLife.Translators
{
    public abstract class Translator
    {
        protected Translator()
        {
        }

        public abstract void Translate(Frame frame);
    }
}
