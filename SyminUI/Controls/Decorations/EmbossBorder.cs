﻿using System;
using System.Collections;
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

namespace SyminUI.Controls.Decorations
{
    public class EmbossBorder : ContentControl
    {
        static EmbossBorder()
        {

            DefaultStyleKeyProperty.OverrideMetadata(typeof(EmbossBorder),
                new FrameworkPropertyMetadata(typeof(EmbossBorder)));
        }

        /// <summary>
        /// Weight of emboss effect, Range 0~1
        /// 浮现高度比例，范围0~1
        /// </summary>
        public double Intensity
        {
            get { return (double)GetValue(IntensityProperty); }
            set { SetValue(IntensityProperty, value); }
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        /// <summary>
        /// Enable or disable the border effect
        /// </summary>
        public bool ShaderEnabled
        {
            get { return (bool)GetValue(ShaderEnabledProperty); }
            set { SetValue(ShaderEnabledProperty, value); }
        }

        public SolidColorBrush LightBrush
        {
            get { return (SolidColorBrush)GetValue(LightBrushProperty); }
            set { SetValue(LightBrushProperty, value); }
        }

        public SolidColorBrush ShadowBrush
        {
            get { return (SolidColorBrush)GetValue(ShadowBrushProperty); }
            set { SetValue(ShadowBrushProperty, value); }
        }


        #region Dependency Properties

        // Using a DependencyProperty as the backing store for Intensity.
        public static readonly DependencyProperty IntensityProperty =
            DependencyProperty.Register("Intensity",
                typeof(double), typeof(EmbossBorder),
                new PropertyMetadata(1.0));

        // Using a DependencyProperty as the backing store for CornerRadius.
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius",
                typeof(CornerRadius), typeof(EmbossBorder),
                new PropertyMetadata(new CornerRadius(4)));

        // Using a DependencyProperty as the backing store for ShaderEnabled.
        public static readonly DependencyProperty ShaderEnabledProperty =
            DependencyProperty.Register("ShaderEnabled",
                typeof(bool), typeof(EmbossBorder),
                new PropertyMetadata(true));

        // Using a DependencyProperty as the backing store for LightBrush.
        public static readonly DependencyProperty LightBrushProperty =
            DependencyProperty.Register("LightBrush",
                typeof(SolidColorBrush), typeof(EmbossBorder));

        // Using a DependencyProperty as the backing store for ShadowBrush.
        public static readonly DependencyProperty ShadowBrushProperty =
            DependencyProperty.Register("ShadowBrush",
                typeof(SolidColorBrush), typeof(EmbossBorder));

        #endregion

    }
}

