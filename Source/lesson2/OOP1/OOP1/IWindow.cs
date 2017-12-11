using System.Drawing;

namespace OOP1
{
    public interface IWindow
    {
        string Title { get; set; }

        void Draw();
        void Draw(Point Params, int width, int height);
        void Open();
    }
}