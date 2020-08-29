﻿using Cronometro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Cronometro
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer dispatcherTimer;
        Chrono chrono;
        public MainWindow()
        {
            InitializeComponent();

            // Setup the timer
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1);

            chrono = new Chrono();
        }
        // When the timer tick
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            lblTimer.Content = chrono.ToString();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            chrono.Play();
            dispatcherTimer.Start();
 
        }

        private void BtnPause_Click(object sender, RoutedEventArgs e)
        {

            chrono.Pause();
            dispatcherTimer.Stop();

        }

        private void BtnStop_Click(object sender, RoutedEventArgs e)
        {

            chrono.Pause();
            chrono.Reset();
            dispatcherTimer.Stop();
            lblTimer.Content = "00::00::00";
        }

    }
    }

   
