﻿using System;
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
    public class CardBorder : ContentControl
    {
        static CardBorder()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CardBorder),
                new FrameworkPropertyMetadata(typeof(CardBorder)));
        }

    }
}
