namespace SimplePaint
{
    public interface IEditor
    {
        void SaveImageAs(string fileName);
        void LoadImage(string fileName);
        void Exit();
        void ClearCanvas();
    }
}