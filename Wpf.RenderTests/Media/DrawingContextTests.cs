﻿namespace Avalonia.RenderTests.Media
{
#if TEST_WPF
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
#else
    using Avalonia.Controls;
    using Avalonia.Media;
#endif

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DrawingContextTests : TestBase
    {
        public DrawingContextTests()
            : base(@"Media\DrawingContext")
        {
        }

        [TestMethod]
        public void DrawRectangle_Fill()
        {
            UserControl userControl = new UserControl();
            userControl.Width = 200;
            userControl.Height = 200;

            TestControl testControl = new TestControl();
            testControl.Brush = new SolidColorBrush(Colors.Red);
            userControl.Content = testControl;

            this.RenderToFile(userControl);
            this.CompareImages();
        }

        [TestMethod]
        public void DrawRectangle_Stroke_1px()
        {
            UserControl userControl = new UserControl();
            userControl.Width = 200;
            userControl.Height = 200;

            TestControl testControl = new TestControl();
            testControl.Pen = new Pen(new SolidColorBrush(Colors.Red), 1);
            userControl.Content = testControl;

            this.RenderToFile(userControl);
            this.CompareImages();
        }

        [TestMethod]
        public void DrawRectangle_Stroke_2px()
        {
            UserControl userControl = new UserControl();
            userControl.Width = 200;
            userControl.Height = 200;

            TestControl testControl = new TestControl();
            testControl.Pen = new Pen(new SolidColorBrush(Colors.Red), 2);
            userControl.Content = testControl;

            this.RenderToFile(userControl);
            this.CompareImages();
        }

        [TestMethod]
        public void DrawRectangle_Fill_Transparent_Stroke()
        {
            UserControl userControl = new UserControl();
            userControl.Width = 200;
            userControl.Height = 200;

            TestControl testControl = new TestControl();
            testControl.Brush = new SolidColorBrush(Colors.Red);
            testControl.Pen = new Pen(new SolidColorBrush(Colors.Transparent), 3);
            userControl.Content = testControl;

            this.RenderToFile(userControl);
            this.CompareImages();
        }

        [TestMethod]
        public void DrawRectangle_Fill_Stroke()
        {
            UserControl userControl = new UserControl();
            userControl.Width = 200;
            userControl.Height = 200;

            TestControl testControl = new TestControl();
            testControl.Brush = new SolidColorBrush(Colors.Red);
            testControl.Pen = new Pen(new SolidColorBrush(Colors.Yellow), 5);
            userControl.Content = testControl;

            this.RenderToFile(userControl);
            this.CompareImages();
        }

        private class TestControl : FrameworkElement
        {
            public Brush Brush { get; set; }

            public Pen Pen { get; set; }

            protected override void OnRender(DrawingContext drawingContext)
            {
                drawingContext.DrawRectangle(
                    this.Brush,
                    this.Pen,
                    new Rect(10, 10, 180, 180.5));
            }
        }
    }
}