using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace LearnOpenTK
{
    public class Window : GameWindow
    {
        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
            : base(gameWindowSettings, nativeWindowSettings)
        { }

        protected override void OnLoad()
        {
            base.OnLoad();

            Title += ": OpenGL Version: " + GL.GetString(StringName.Version);

            // This will be the color of the background after we clear it, in normalized colors.
            // Normalized colors are mapped on a range of 0.0 to 1.0, with 0.0 representing black, and 1.0 representing
            // the largest possible value for that channel.
            // This is a deep green.
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);

            // Update the opengl viewport
            Vector2i fb = this.FramebufferSize;
            GL.Viewport(0, 0, fb.X, fb.Y);

        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            // This clears the image, using what you set as GL.ClearColor earlier.
            // OpenGL provides several different types of data that can be rendered.
            // You can clear multiple buffers by using multiple bit flags.
            // However, we only modify the color, so ColorBufferBit is all we need to clear.
            GL.ClearColor(0.2f, 0.2f, 0.2f, 1.0f);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);




            SwapBuffers();
        }

        protected override void OnTextInput(TextInputEventArgs e)
        {
            base.OnTextInput(e);

        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);
        }
    }
}
