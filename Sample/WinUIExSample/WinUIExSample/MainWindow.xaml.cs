﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinUIEx;

namespace WinUIExSample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : WindowEx
    {
        TrayIcon tray;
        public MainWindow()
        {
            this.InitializeComponent();
            //this.SetWindowSize(1024, 768);
            // var icon = WinUIEx.Icon.ExclamationIcon();
            // tray = new TrayIcon();
            // tray.SetIcon(icon);
            // tray.TrayIconLeftMouseDown += (s, e) => this.BringToFront();
        }

        private void Center_Click(object sender, RoutedEventArgs e)
        {
            this.CenterOnScreen();
        }
    }
}