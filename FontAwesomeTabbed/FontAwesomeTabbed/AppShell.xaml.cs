﻿using FontAwesomeTabbed.ViewModels;
using FontAwesomeTabbed.Views;
using FontAwesomeTabbed.Views.DataTemplates;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FontAwesomeTabbed
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}